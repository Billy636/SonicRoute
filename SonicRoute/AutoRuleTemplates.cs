using System;
using System.Collections.Generic;
using SonicRoute.Core.Models;

namespace SonicRoute
{
    // UI-only starter data. Selecting a template never reads storage or executes a rule.
    internal sealed class AutoRuleTemplate
    {
        internal string Id { get; }
        internal string NameKey { get; }
        internal string DescriptionKey { get; }
        private readonly AutoRuleTrigger _trigger;
        private readonly Func<AutoRuleStep[]> _steps;
        private readonly string? _dailyTime;

        internal AutoRuleTemplate(string id, string key, AutoRuleTrigger trigger, Func<AutoRuleStep[]> steps, string? dailyTime = null)
        {
            Id = id;
            NameKey = "Template." + key + ".Name";
            DescriptionKey = "Template." + key + ".Description";
            _trigger = trigger;
            _steps = steps;
            _dailyTime = dailyTime;
        }

        internal AutoRule CreateDraft(string name)
        {
            var rule = new AutoRule { Name = name, Trigger = _trigger, Enabled = false };
            if (_dailyTime != null)
            {
                rule.ScheduleMode = 1;
                rule.ScheduleTime = _dailyTime;
            }
            rule.SetSteps(_steps());
            return rule;
        }
    }

    internal static class AutoRuleTemplates
    {
        internal static IReadOnlyList<AutoRuleTemplate> All { get; } = new[]
        {
            new AutoRuleTemplate("app_start_route_output", "Game", AutoRuleTrigger.AppStart, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.SetAppOutput, DelayMs = 3000 },
                new AutoRuleStep { Action = AutoRuleAction.SetAppVolume, Volume = 50 }
            }),
            new AutoRuleTemplate("app_switch_route_input", "Meeting", AutoRuleTrigger.AppSwitch, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.SetAppInput }
            }),
            new AutoRuleTemplate("hotkey_sound_setup", "Sound", AutoRuleTrigger.Hotkey, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.SetSystemOutput },
                new AutoRuleStep { Action = AutoRuleAction.SetSystemVolume, Volume = 35 }
            }),
            new AutoRuleTemplate("startup_tools", "Tools", AutoRuleTrigger.Startup, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.LaunchProgram, LaunchMode = 0 }
            }),
            new AutoRuleTemplate("app_exit_speakers", "ExitSpeakers", AutoRuleTrigger.AppExit, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.SetSystemOutput }
            }),
            new AutoRuleTemplate("app_switch_music_volume", "Music", AutoRuleTrigger.AppSwitch, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.SetAppVolume, Volume = 20 }
            }),
            new AutoRuleTemplate("daily_quiet_volume", "Night", AutoRuleTrigger.Schedule, () => new[]
            {
                new AutoRuleStep { Action = AutoRuleAction.SetSystemVolume, Volume = 15 }
            }, dailyTime: "22:00")
        };
    }
}
