using System;
using System.Windows.Controls;
using MenuItem = System.Windows.Controls.MenuItem;

namespace SonicRoute
{
    /// <summary>所有音量滑块共用档位菜单；写入继续走原来的 ValueChanged 流程。</summary>
    internal static class VolumePresets
    {
        private static readonly int[] Percentages = { 25, 50, 75, 100 };

        internal static void Populate(ItemCollection items, Action<int> apply, bool staysOpenOnClick = false)
        {
            foreach (int percent in Percentages)
            {
                var item = ConvenienceMenus.Item(percent + "%");
                item.IsCheckable = true;
                item.StaysOpenOnClick = staysOpenOnClick;
                item.Tag = percent;
                item.Click += (_, _) => apply(percent);
                items.Add(item);
            }
        }

        internal static void Update(ItemCollection items, double current, bool enabled)
        {
            foreach (MenuItem item in items)
            {
                item.IsEnabled = enabled;
                item.IsChecked = Math.Abs(current - (int)item.Tag) < 0.5;
            }
        }

        internal static void Attach(Slider slider)
        {
            var menu = ConvenienceMenus.Create();
            slider.ContextMenuOpening += (_, _) =>
            {
                // 仅第一次右键时创建菜单项，列表加载不为每行预建四个控件。
                if (menu.Items.Count != 0) return;
                Populate(menu.Items, percent => { if (slider.IsEnabled) slider.Value = percent; });
            };
            menu.Opened += (_, _) =>
            {
                Update(menu.Items, slider.Value, slider.IsEnabled);
            };
            slider.ContextMenu = menu;
        }
    }
}
