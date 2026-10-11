using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using ContextMenu = System.Windows.Controls.ContextMenu;

namespace SonicRoute
{
    public partial class App
    {
        private ContextMenu? _trayMenu;
        private HwndSource? _trayMenuHost;

        private void ShowTrayMenu()
        {
            if (_trayIcon == null || Dispatcher.HasShutdownStarted) return;
            CloseTrayMenu();
            CancelUiReclaim();
            _uiWorkingSetDirty = true;
            try
            {
                var menu = ConvenienceMenus.Create();
                _trayMenu = menu;
                AddTrayAction(menu, L10n.T("St.Settings"), ShowMainWindow);
                AddTrayAction(menu, L10n.T("Tray.OpenPanel"), ToggleQuickPanel);
                menu.Items.Add(BuildFavoriteRulesMenu(menu));
                var separator = new Separator();
                separator.SetResourceReference(Separator.StyleProperty, "ConvenienceMenuSeparator");
                menu.Items.Add(separator);
                AddTrayAction(menu, L10n.T("Tray.Exit"), Quit);

                // 托盘菜单需要前台宿主才能正常失焦关闭。仅在菜单打开时创建原生零尺寸窗口，
                // 不创建隐藏 WPF Window，不保留常驻视觉树或轮询。
                var cursor = System.Windows.Forms.Cursor.Position;
                _trayMenuHost = new HwndSource(new HwndSourceParameters("SonicRoute.TrayMenu")
                {
                    Width = 0, Height = 0, PositionX = cursor.X, PositionY = cursor.Y,
                    WindowStyle = unchecked((int)0x90000000), // WS_POPUP | WS_VISIBLE
                    ExtendedWindowStyle = 0x80 // WS_EX_TOOLWINDOW
                });
                _trayMenuHost.AddHook(TrayMenuHostHook);
                SetForegroundWindow(_trayMenuHost.Handle);
                menu.Placement = PlacementMode.MousePoint;
                menu.Opened += (_, _) => menu.Focus();
                menu.PreviewKeyDown += (_, args) =>
                {
                    // 原生宿主没有 WPF Window；明确保留 Esc 的逐级关闭行为。
                    if (args.Key != System.Windows.Input.Key.Escape) return;
                    var submenu = menu.Items.OfType<System.Windows.Controls.MenuItem>().FirstOrDefault(item => item.IsSubmenuOpen);
                    if (submenu != null) submenu.IsSubmenuOpen = false;
                    else menu.IsOpen = false;
                    args.Handled = true;
                };
                menu.Closed += (_, _) =>
                {
                    if (_trayMenu == menu) CloseTrayMenu();
                };
                menu.IsOpen = true;
            }
            catch { CloseTrayMenu(); }
        }

        private static void AddTrayAction(ContextMenu menu, string text, Action action)
        {
            var item = ConvenienceMenus.Item(text);
            item.Click += (_, _) => { menu.IsOpen = false; action(); };
            menu.Items.Add(item);
        }

        private IntPtr TrayMenuHostHook(IntPtr hwnd, int message, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            if (message == 0x001C && wParam == IntPtr.Zero && _trayMenuHost?.Handle == hwnd)
            {
                // 旧宿主的延迟失焦消息不能关闭随后打开的新菜单。
                var host = _trayMenuHost;
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    if (ReferenceEquals(_trayMenuHost, host)) CloseTrayMenu();
                }));
            }
            return IntPtr.Zero;
        }

        private void CloseTrayMenu()
        {
            var menu = _trayMenu;
            var host = _trayMenuHost;
            _trayMenu = null;
            _trayMenuHost = null;
            ++_favoriteMenuRequest; // 丢弃已关闭菜单的异步规则读取结果。
            if (menu != null) menu.IsOpen = false;
            if (host != null)
            {
                PostMessage(host.Handle, 0, IntPtr.Zero, IntPtr.Zero);
                host.Dispose();
                if (_trayIcon != null && !Dispatcher.HasShutdownStarted) ScheduleUiReclaim();
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);
    }
}
