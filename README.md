# 🎧 音跃 SonicRoute

**简体中文** | [English](README.en.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE)
[![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases)
[![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases)
[![爱发电](https://img.shields.io/badge/赞助-爱发电-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**无需反复打开 Windows 声音设置，快速控制当前应用的声音。**

SonicRoute 是一款开源的 Windows 托盘音频工具，支持按应用切换输入 / 输出设备、调整音量与静音。通过快捷键、托盘区域滚轮、快速面板和 OSD，在游戏或全屏应用中也能便捷操作；需要时还可配置自动化规则。

<table>
  <tr>
    <th width="35%" align="left">快速面板</th>
    <th width="65%" align="left">主题与设置</th>
  </tr>
  <tr>
    <td valign="top"><a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" alt="SonicRoute 快速面板：设备切换、应用音量与实时声音活动"></a></td>
    <td valign="top"><a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" alt="SonicRoute 主题设置：主题模式、强调色与背景透明度"></a></td>
  </tr>
</table>

Windows 10 2004+ / Windows 11 · x64 / ARM64（实验） · C# / WPF

📥 [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) ｜ [GitHub Releases](https://github.com/kunkunkunQoQ/SonicRoute/releases) ｜ [Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

---

## ✨ 核心功能

- 🎯 **按应用切换设备**：切换当前应用、运行中应用或系统默认的输出 / 输入设备。
- ⌨️ **快捷键与托盘滚轮**：用全局快捷键调音量、切换设备或控制静音；在系统托盘通知区域滚动滚轮，可调整当前应用音量。
- 🖱 **托盘快速面板**：集中控制设备、音量和静音，查看应用实时声音活动，提供快捷面板与应用面板两种布局。
- 🖥 **OSD 操作提示**：显示音量及麦克风静音状态，可自定义外观、位置与提示效果。
- 🤖 **自动化与命令行**：通过应用事件、快捷键、定时或启动触发多步规则；也可用 `sr "规则名称或ID"` 调用正在运行的 SonicRoute 中的规则（首次登记命令后需重新打开终端）。
- 🎨 **个性化设置**：深浅主题、九种语言、设备筛选与自定义名称。

## 🚀 下载与快速开始

**推荐：** 普通 Windows x64 用户优先选择 **Microsoft Store**（自动更新）；希望使用单个 EXE 可选择 **Lite x64**；不方便安装 .NET 8 时可选择 **Legacy x64**。

**获取最新版：** [GitHub Releases](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · 以下提供 **v1.22（2026-10-11）** 下载直链及 [更新说明](docs/release-v1.22.md)。

| 版本 | 适用说明 | 下载 |
|---|---|---|
| Microsoft Store（x64） | 安装方便，支持自动更新 | [前往商店](https://apps.microsoft.com/detail/9NQZGRTPM1NT) |
| Lite x64 | 单 EXE，需 .NET 8 Desktop Runtime（x64） | [下载 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) |
| Legacy x64 | .NET Framework 4.8，完整解压后运行，无需 .NET 8 | [下载 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) |
| Lite ARM64（实验） | 单 EXE，需 .NET 8 Desktop Runtime（ARM64） | [下载 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) |

Microsoft Store 的实际在架版本可能与 GitHub 发布进度不同，以商店页面为准。

**首次使用：**

1. 选择对应版本。Lite 用户需先安装匹配架构的 [Microsoft .NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)（请选择 **Desktop Runtime**）；Legacy 用户需完整解压 ZIP。
2. 启动 SonicRoute，在 Windows 任务栏通知区域找到托盘图标（可能位于隐藏图标中），打开快速面板或主界面。
3. 根据需要配置快捷键、托盘区域滚轮和应用设备切换。具体操作参见 [使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97)。

> **兼容性提示：** ARM64 仍属实验版本，尚未完成充分的实体设备验证。个别应用的音频行为可能影响设备切换效果，遇到问题可查看 [常见问题](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)。

v1.22 主要修复命令复制卡顿，统一菜单布局，并优化自启动和自动化页面加载。旧版下载及完整变更记录参见 [Releases](https://github.com/kunkunkunQoQ/SonicRoute/releases)。

## 📚 使用文档

- **入门：** [使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [功能特性](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) · [快捷键](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE)
- **进阶：** [自动化规则](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [命令行调用](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) · [技术实现](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0)
- **帮助：** [常见问题](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) · [版本历史](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) · [完整 Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

## 📌 后续计划

后续改进将分阶段持续推出，计划可能根据反馈调整。

- **v1.23 · 性能与稳定性**：继续改善后台资源占用、响应速度与兼容性。
- **后续阶段**：围绕现有功能与用户反馈持续打磨。

💡 有建议或发现问题？欢迎 [提交反馈](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose)。

---

## 🧩 其他作品

- 🎧 **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)** — 轻量静默的 Windows 音频播放器；可与 SonicRoute [组合使用](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)。
- 📦 **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)** — SonicRoute 使用的 Windows 音频控制库（.NET）。

---

**作者主页 ‖ [哔哩哔哩](https://b23.tv/TDqSAKM) ‖ [爱发电](https://www.ifdian.net/a/koukou021) ‖ [GitHub](https://github.com/kunkunkunQoQ)**
