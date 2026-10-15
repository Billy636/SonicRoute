using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using ContextMenu = System.Windows.Controls.ContextMenu;
using MenuItem = System.Windows.Controls.MenuItem;
using SonicRoute.Core;

namespace SonicRoute
{
    public partial class App
    {
        private int _favoriteMenuRequest;

        private MenuItem BuildFavoriteRulesMenu(ContextMenu owner)
        {
            var lifetime = _trayMenuLifetime!;
            var favorites = ConvenienceMenus.Item(L10n.T("Auto.Favorites"));
            var empty = ConvenienceMenus.Item(L10n.T("Auto.FavoritesEmpty"));
            empty.IsEnabled = false;
            favorites.Items.Add(empty);
            owner.Opened += async (_, _) =>
            {
                int request = ++_favoriteMenuRequest;
                try
                {
                    var ids = new List<string>(ConfigService.Load().FavoriteRuleIds ?? new List<string>());
                    var rules = await lifetime.ReadAsync(() => ids.Distinct(StringComparer.Ordinal).Select(AutoRuleStore.Find)
                        .Where(rule => rule != null).Select(rule => rule!).ToList());
                    if (request != _favoriteMenuRequest || !owner.IsOpen || _trayMenu != owner || Dispatcher.HasShutdownStarted) return;
                    var byId = rules.ToDictionary(rule => rule.Id, StringComparer.Ordinal);
                    favorites.Items.Clear();
                    foreach (string id in ids.Distinct(StringComparer.Ordinal))
                    {
                        if (!byId.TryGetValue(id, out var rule)) continue;
                        var entry = ConvenienceMenus.Item(rule.Name.Replace("_", "__"));
                        entry.IsEnabled = !AutoRuleService.IsRunning(id);
                        entry.Click += async (_, _) =>
                        {
                            owner.IsOpen = false;
                            await RunFavoriteRuleAsync(id);
                        };
                        favorites.Items.Add(entry);
                    }
                    if (favorites.Items.Count == 0) favorites.Items.Add(empty);
                }
                catch { /* 菜单仍可用于打开设置和退出。 */ }
            };
            return favorites;
        }

        private async Task RunFavoriteRuleAsync(string id)
        {
            try
            {
                var rule = await Task.Run(() => AutoRuleStore.Find(id));
                if (rule == null) { ShowOsd(L10n.T("Auto.Favorites"), L10n.T("Auto.MissingRule")); return; }
                var result = await AutoRuleService.ExecuteWithResultAsync(rule);
                if (!Dispatcher.HasShutdownStarted) ShowOsd(rule.Name, AutoRuleService.DescribeResult(result));
            }
            catch { if (!Dispatcher.HasShutdownStarted) ShowOsd(L10n.T("Auto.Favorites"), L10n.T("Auto.RunFailed")); }
        }
    }
}
