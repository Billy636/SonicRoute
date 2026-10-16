using System;
using System.Windows;
using System.Windows.Controls;
using Button = System.Windows.Controls.Button;
using ComboBox = System.Windows.Controls.ComboBox;
using TextBox = System.Windows.Controls.TextBox;

namespace SonicRoute
{
    public partial class MainWindow
    {
        internal Grid AutomationPage = null!;
        internal ScrollViewer AutomationScroll = null!;
        internal StackPanel AutoListPanel = null!;
        internal Button AutoNewButton = null!;
        internal Button AutoTemplatesButton = null!;
        internal TextBlock AutoTemplateHintText = null!;
        internal TextBox AutoSearchBox = null!;
        internal ComboBox AutoStateFilter = null!;
        internal ComboBox AutoTriggerFilter = null!;
        internal Button AutoListOptionsButton = null!;
        internal TextBlock AutoEmptyText = null!;
        internal ItemsControl AutoRuleList = null!;
        internal Border AutoEditCard = null!;
        internal TextBlock AutoEditTitle = null!;
        internal TextBox AutoNameBox = null!;
        internal ComboBox AutoTriggerCombo = null!;
        internal Grid AutoHotkeyPanel = null!;
        internal Button AutoHotkeyCapture = null!;
        internal TextBlock AutoHotkeyHintText = null!;
        internal Grid AutoTriggerAppPanel = null!;
        internal ComboBox AutoTriggerAppCombo = null!;
        internal StackPanel AutoSchedulePanel = null!;
        internal ComboBox AutoScheduleModeCombo = null!;
        internal ComboBox AutoScheduleHourCombo = null!;
        internal ComboBox AutoScheduleMinuteCombo = null!;
        internal StackPanel AutoScheduleWeekdayPanel = null!;
        internal WrapPanel AutoWeekdayPanel = null!;
        internal ItemsControl AutoStepsHost = null!;
        internal Button AutoAddStepBtn = null!;
        internal Button AutoCancelButton = null!;
        internal Button AutoSaveButton = null!;

        private static T FindAutomationControl<T>(Grid page, string name) where T : FrameworkElement =>
            LogicalTreeHelper.FindLogicalNode(page, name) as T
                ?? throw new InvalidOperationException("Missing automation control: " + name);

        private void EnsureAutomationPage()
        {
            if (AutomationPageHost.Child != null) return;
            bool suppressed = _suppressAutoUi;
            _suppressAutoUi = true;
            try
            {
                // Keep one automation page per open window and reuse it on navigation.
                // The resource stays deferred until this method is called.
                var content = (Grid)Resources["AutomationPageContent"];
                AutomationPage = FindAutomationControl<Grid>(content, nameof(AutomationPage));
                if (FindName(nameof(AutomationPage)) == null) RegisterName(nameof(AutomationPage), AutomationPage);
                AutomationScroll = FindAutomationControl<ScrollViewer>(content, nameof(AutomationScroll));
                if (FindName(nameof(AutomationScroll)) == null) RegisterName(nameof(AutomationScroll), AutomationScroll);
                AutoListPanel = FindAutomationControl<StackPanel>(content, nameof(AutoListPanel));
                if (FindName(nameof(AutoListPanel)) == null) RegisterName(nameof(AutoListPanel), AutoListPanel);
                AutoNewButton = FindAutomationControl<Button>(content, nameof(AutoNewButton));
                if (FindName(nameof(AutoNewButton)) == null) RegisterName(nameof(AutoNewButton), AutoNewButton);
                AutoTemplatesButton = FindAutomationControl<Button>(content, nameof(AutoTemplatesButton));
                if (FindName(nameof(AutoTemplatesButton)) == null) RegisterName(nameof(AutoTemplatesButton), AutoTemplatesButton);
                AutoTemplateHintText = FindAutomationControl<TextBlock>(content, nameof(AutoTemplateHintText));
                if (FindName(nameof(AutoTemplateHintText)) == null) RegisterName(nameof(AutoTemplateHintText), AutoTemplateHintText);
                AutoSearchBox = FindAutomationControl<TextBox>(content, nameof(AutoSearchBox));
                if (FindName(nameof(AutoSearchBox)) == null) RegisterName(nameof(AutoSearchBox), AutoSearchBox);
                AutoStateFilter = FindAutomationControl<ComboBox>(content, nameof(AutoStateFilter));
                if (FindName(nameof(AutoStateFilter)) == null) RegisterName(nameof(AutoStateFilter), AutoStateFilter);
                AutoTriggerFilter = FindAutomationControl<ComboBox>(content, nameof(AutoTriggerFilter));
                if (FindName(nameof(AutoTriggerFilter)) == null) RegisterName(nameof(AutoTriggerFilter), AutoTriggerFilter);
                AutoListOptionsButton = FindAutomationControl<Button>(content, nameof(AutoListOptionsButton));
                if (FindName(nameof(AutoListOptionsButton)) == null) RegisterName(nameof(AutoListOptionsButton), AutoListOptionsButton);
                AutoEmptyText = FindAutomationControl<TextBlock>(content, nameof(AutoEmptyText));
                if (FindName(nameof(AutoEmptyText)) == null) RegisterName(nameof(AutoEmptyText), AutoEmptyText);
                AutoRuleList = FindAutomationControl<ItemsControl>(content, nameof(AutoRuleList));
                if (FindName(nameof(AutoRuleList)) == null) RegisterName(nameof(AutoRuleList), AutoRuleList);
                AutoEditCard = FindAutomationControl<Border>(content, nameof(AutoEditCard));
                if (FindName(nameof(AutoEditCard)) == null) RegisterName(nameof(AutoEditCard), AutoEditCard);
                AutoEditTitle = FindAutomationControl<TextBlock>(content, nameof(AutoEditTitle));
                if (FindName(nameof(AutoEditTitle)) == null) RegisterName(nameof(AutoEditTitle), AutoEditTitle);
                AutoNameBox = FindAutomationControl<TextBox>(content, nameof(AutoNameBox));
                if (FindName(nameof(AutoNameBox)) == null) RegisterName(nameof(AutoNameBox), AutoNameBox);
                AutoTriggerCombo = FindAutomationControl<ComboBox>(content, nameof(AutoTriggerCombo));
                if (FindName(nameof(AutoTriggerCombo)) == null) RegisterName(nameof(AutoTriggerCombo), AutoTriggerCombo);
                AutoHotkeyPanel = FindAutomationControl<Grid>(content, nameof(AutoHotkeyPanel));
                if (FindName(nameof(AutoHotkeyPanel)) == null) RegisterName(nameof(AutoHotkeyPanel), AutoHotkeyPanel);
                AutoHotkeyCapture = FindAutomationControl<Button>(content, nameof(AutoHotkeyCapture));
                if (FindName(nameof(AutoHotkeyCapture)) == null) RegisterName(nameof(AutoHotkeyCapture), AutoHotkeyCapture);
                AutoHotkeyHintText = FindAutomationControl<TextBlock>(content, nameof(AutoHotkeyHintText));
                if (FindName(nameof(AutoHotkeyHintText)) == null) RegisterName(nameof(AutoHotkeyHintText), AutoHotkeyHintText);
                AutoTriggerAppPanel = FindAutomationControl<Grid>(content, nameof(AutoTriggerAppPanel));
                if (FindName(nameof(AutoTriggerAppPanel)) == null) RegisterName(nameof(AutoTriggerAppPanel), AutoTriggerAppPanel);
                AutoTriggerAppCombo = FindAutomationControl<ComboBox>(content, nameof(AutoTriggerAppCombo));
                if (FindName(nameof(AutoTriggerAppCombo)) == null) RegisterName(nameof(AutoTriggerAppCombo), AutoTriggerAppCombo);
                AutoSchedulePanel = FindAutomationControl<StackPanel>(content, nameof(AutoSchedulePanel));
                if (FindName(nameof(AutoSchedulePanel)) == null) RegisterName(nameof(AutoSchedulePanel), AutoSchedulePanel);
                AutoScheduleModeCombo = FindAutomationControl<ComboBox>(content, nameof(AutoScheduleModeCombo));
                if (FindName(nameof(AutoScheduleModeCombo)) == null) RegisterName(nameof(AutoScheduleModeCombo), AutoScheduleModeCombo);
                AutoScheduleHourCombo = FindAutomationControl<ComboBox>(content, nameof(AutoScheduleHourCombo));
                if (FindName(nameof(AutoScheduleHourCombo)) == null) RegisterName(nameof(AutoScheduleHourCombo), AutoScheduleHourCombo);
                AutoScheduleMinuteCombo = FindAutomationControl<ComboBox>(content, nameof(AutoScheduleMinuteCombo));
                if (FindName(nameof(AutoScheduleMinuteCombo)) == null) RegisterName(nameof(AutoScheduleMinuteCombo), AutoScheduleMinuteCombo);
                AutoScheduleWeekdayPanel = FindAutomationControl<StackPanel>(content, nameof(AutoScheduleWeekdayPanel));
                if (FindName(nameof(AutoScheduleWeekdayPanel)) == null) RegisterName(nameof(AutoScheduleWeekdayPanel), AutoScheduleWeekdayPanel);
                AutoWeekdayPanel = FindAutomationControl<WrapPanel>(content, nameof(AutoWeekdayPanel));
                if (FindName(nameof(AutoWeekdayPanel)) == null) RegisterName(nameof(AutoWeekdayPanel), AutoWeekdayPanel);
                AutoStepsHost = FindAutomationControl<ItemsControl>(content, nameof(AutoStepsHost));
                if (FindName(nameof(AutoStepsHost)) == null) RegisterName(nameof(AutoStepsHost), AutoStepsHost);
                AutoAddStepBtn = FindAutomationControl<Button>(content, nameof(AutoAddStepBtn));
                if (FindName(nameof(AutoAddStepBtn)) == null) RegisterName(nameof(AutoAddStepBtn), AutoAddStepBtn);
                AutoCancelButton = FindAutomationControl<Button>(content, nameof(AutoCancelButton));
                if (FindName(nameof(AutoCancelButton)) == null) RegisterName(nameof(AutoCancelButton), AutoCancelButton);
                AutoSaveButton = FindAutomationControl<Button>(content, nameof(AutoSaveButton));
                if (FindName(nameof(AutoSaveButton)) == null) RegisterName(nameof(AutoSaveButton), AutoSaveButton);
                AutomationPageHost.Child = content;
                AutoTriggerAppCombo.DropDownOpened += AppCombo_DropDownOpened;
                AutoStepsHost.SizeChanged += (_, _) => { if (_autoDragging) EndAutoDrag(commit: false); };
                InitializeAutoExtras();
            }
            finally { _suppressAutoUi = suppressed; }
        }
    }
}
