# 🎧 SonicRoute

[简体中文](README.md) | **English**

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE)
[![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases)
[![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases)
[![Support on Afdian](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**Control the audio of your current app without digging through Windows sound settings.**

SonicRoute is an open-source Windows audio utility that lives in the system tray. Route input/output devices for individual apps, adjust volume, and mute audio using hotkeys, scrolling in the system tray area, a quick panel, and OSD feedback — including while gaming or using fullscreen apps. Automation rules are available when you need them.

<table>
  <tr>
    <th width="35%" align="left">Quick panel</th>
    <th width="65%" align="left">Theme and settings</th>
  </tr>
  <tr>
    <td valign="top"><a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" alt="SonicRoute quick panel with device selection, per-app volume, and live audio activity"></a></td>
    <td valign="top"><a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" alt="SonicRoute theme settings with appearance mode, accent color, and background opacity"></a></td>
  </tr>
</table>

Windows 10 2004+ / Windows 11 · x64 / ARM64 (experimental) · C# / WPF

📥 [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | [GitHub Releases](https://github.com/kunkunkunQoQ/SonicRoute/releases) | [Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

---

## ✨ Core features

- 🎯 **Per-app device routing**: Switch input/output devices for the current app, running apps, or Windows defaults.
- ⌨️ **Hotkeys and tray scrolling**: Use global hotkeys for volume, device switching, and muting; scroll in the system tray notification area to adjust the current app's volume.
- 🖱 **Tray quick panels**: Control devices, volume, and mute; view live app audio activity in Quick or App panel layouts.
- 🖥 **OSD feedback**: Show volume and microphone mute status with customizable appearance, positioning, and feedback effects.
- 🤖 **Automation and CLI**: Trigger multi-step rules on app events, hotkeys, schedules, or startup. Use `sr "Rule name or ID"` to invoke rules in an already-running SonicRoute instance (reopen the terminal after the command is first registered).
- 🎨 **Personalization**: Light/dark themes, nine languages, device filtering, and custom names.

## 🚀 Download and quick start

**Recommended:** For most Windows x64 users, choose the **Microsoft Store** build for automatic updates. Choose **Lite x64** for a single executable, or **Legacy x64** if installing .NET 8 is not convenient.

**Get the latest release:** [GitHub Releases](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · Direct downloads below are for **v1.22 (2026-10-11)**; [release notes (Chinese)](docs/release-v1.22.md).

| Edition | Requirements / when to use | Download |
|---|---|---|
| Microsoft Store (x64) | Easy installation and automatic updates | [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) |
| Lite x64 | Single EXE; requires .NET 8 Desktop Runtime (x64) | [Download EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) |
| Legacy x64 | .NET Framework 4.8; extract the whole ZIP; no .NET 8 required | [Download ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) |
| Lite ARM64 (experimental) | Single EXE; requires .NET 8 Desktop Runtime (ARM64) | [Download EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) |

The version currently available on Microsoft Store may differ from the latest GitHub release; check the Store listing for its version.

**Getting started:**

1. Download an edition for your system. Lite users need the matching [Microsoft .NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0) (choose **Desktop Runtime**, not the basic .NET Runtime). Legacy users should extract the full ZIP first.
2. Launch SonicRoute and find its icon in the Windows notification area (it may be under hidden icons). Open the quick panel or main window from the tray.
3. Set up hotkeys, scrolling in the system tray area, and per-app routing as needed. See the [user guide (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) for details.

> **Compatibility:** ARM64 is experimental and has not been thoroughly validated on physical hardware. Audio routing behavior can vary by app; see the [FAQ (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) if device switching does not work as expected.

v1.22 fixes stalls when copying commands, aligns menu layouts, and improves startup handling and on-demand automation loading. For older versions and full changelogs, see [Releases](https://github.com/kunkunkunQoQ/SonicRoute/releases).

## 📚 Documentation

The following guides are currently in Chinese.

- **Start here:** [User guide](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Features](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) · [Hotkeys](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE)
- **Advanced:** [Automation rules](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [CLI rules](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) · [Technical implementation](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0)
- **Help:** [FAQ](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) · [Version history](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) · [Full Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

## 📌 Roadmap

Improvements will continue in stages; plans may change based on feedback.

- **v1.23 · Performance and stability**: Improve background resource usage, responsiveness, and compatibility.
- **Later stages**: Keep refining existing features based on user feedback.

💡 Have a suggestion or found a bug? [Open an issue](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose).

---

## 🧩 Other projects

- 🎧 **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)** — A lightweight Windows audio player that can be [paired with SonicRoute (Chinese)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad).
- 📦 **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)** — The .NET Windows audio control library used by SonicRoute.

---

**Author: [Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
