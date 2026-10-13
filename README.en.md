# 🎧 SonicRoute

[简体中文](README.md) | **English**

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Support on Afdian](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="User guide (Chinese)"><img src="docs/images/mascot-welcome.png" width="96" align="right" alt="SonicRoute mascot welcoming you to the user guide"></a>

**Send each app's audio to the device you choose.**

Keep music on your speakers and games or calls on your headset. SonicRoute is a Windows audio utility that lives in the system tray: choose output and input devices for individual apps, control audio with hotkeys, the tray wheel or a panel, and combine routine actions into automation rules.

📥 [Download the latest release](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) | [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | [User guide](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) | [Wiki (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64 (experimental) · Nine languages · MIT licensed

<div>
<img src="docs/images/mascot-panel-peek.png" width="104" align="middle" alt="The mascot peeks over the Quick panel and points to its controls">
<br>
<a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" align="top" alt="SonicRoute Quick panel: output device and per-app volume controls"></a>
<a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" align="top" alt="SonicRoute theme settings: appearance, accent color and background opacity"></a>
</div>

<sub>Interface examples: Quick panel for app volume and routing; theme settings for appearance.</sub>

## ✨ What SonicRoute offers

<img src="docs/images/mascot-headphones.png" width="68" align="right" alt="Listening along while you choose app audio devices">

- **Route audio for individual apps.** Choose each app's playback and recording devices, switch devices for running apps, or change the Windows defaults. Windows keeps app routing settings after SonicRoute exits.
- **Control the app you're using.** Resolve the current app from foreground activity and audio sessions, with recent, last-used and specified-app modes. Filter and rename your preferred devices, then cycle through them with the same hotkey.
- **Hotkeys and the tray wheel.** Bind keyboard combinations, mouse side buttons and wheel combinations. Scroll over the taskbar's notification area to adjust the current app's volume, and assign a separate shortcut to mute all microphones.
- **Two panels with different roles.** The Quick panel manages apps in individual rows and controls the selected output device at the top; the App panel focuses on the current app. OSD feedback, app audio meters and microphone mute indicators make the state easy to see.
- **One trigger, multiple actions.** Six triggers and 18 actions cover device switching, volume, mute, program launches, PowerShell and OSD. Add a delay or stop-on-failure setting to each step, call another rule, or invoke a rule in an already-running SonicRoute instance with `sr "Rule name or ID"`.
- **Make it your own.** Adjust light/dark themes, accent colors, opacity and panel position. Nine built-in languages support JSON import and export.

## 🎮 Everyday uses

<img src="docs/images/mascot-automation.png" width="48" align="middle" alt="The mascot plays an automation robot"> Set a game to use your headset when it starts, or save several actions as one rule. [Set up automation](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99).

| Your situation | What you can do |
|---|---|
| Music, games and voice chat running together | Choose separate output or input devices and adjust each app's volume |
| Switching between speakers and a headset | Select your preferred devices and cycle the current app's device with a hotkey |
| Adjusting the app you're working in | In Recent mode, follow the foreground app when it has an audio session, then use hotkeys or the tray wheel |
| Repeating the same setup whenever an app starts | Trigger a rule on app startup to set devices, volume and other actions |
| Calling an audio setup from a script or another tool | Create a rule and invoke it with `sr "Rule name or ID"` |

## 🚀 Download and get started

**Current release: [v1.22](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.22)** · 2026-10-11 · [Release notes (Chinese)](docs/release-v1.22.md)

For most Windows x64 users, the Microsoft Store build offers convenient installation and automatic updates. Choose Lite x64 for a single executable, or Legacy x64 if installing .NET 8 is not convenient. The download link above always points to the latest release; direct links below are for v1.22.

| Version | Download | Requirements |
|---|---|---|
| Lite x64 | [Single EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64 (experimental) | [Single EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [Complete ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) | .NET Framework 4.8; extract the entire archive |
| Microsoft Store | [Install from the Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64; automatic updates, with the version available on the Store |

Lite requires the matching [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0). Legacy does not require .NET 8.

1. Start SonicRoute, find its icon in the Windows notification area (it may be under hidden icons), and double-click it to open the full interface.
2. Select your preferred output and input devices in Settings.
3. Click the tray icon to open a panel, or set up your hotkeys. Create automation rules when you want to combine actions.

Before using `sr` for the first time, start SonicRoute normally to register the command, then reopen your terminal. See the [FAQ (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) if device switching does not work as expected.

Version 1.22 improves startup state handling and keeps Store and portable startup controls independent. It also loads automation on demand, unifies menu styling, improves command copying and refines wording in nine languages. See [version history](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) for earlier changes.

## 📚 Documentation

The Wiki is currently in Chinese.

| Topic | Guides |
|---|---|
| Installation, panels and everyday controls | [User guide](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Features](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| Default keys, bindings and control targets | [Hotkeys](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| Triggers, actions and script integration | [Automation](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [Command line](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| Installation and troubleshooting | [FAQ](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| Source, builds and releases | [Technical implementation](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [Release information](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [Version history](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 Roadmap

- **v1.23 · Performance and stability:** Improve background resource usage, responsiveness and compatibility.
- **Later stages:** Keep refining existing features based on feedback. Plans may change as feedback comes in.

[Share an idea or report an issue](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose).

## 🧩 Other projects and combinations

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**: A Windows audio player. Combine it with the Launch program action to play sound effects from hotkeys. [Setup guide (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**: A .NET library for Windows audio devices, sessions, per-app routing, events and CLI access.

---

<img src="docs/images/mascot-footer.png" width="56" align="right" alt="A resting mascot at the end of the guide">

Thanks for using SonicRoute. [Read the guides (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [Report an issue](https://github.com/kunkunkunQoQ/SonicRoute/issues).

**Author: [Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
