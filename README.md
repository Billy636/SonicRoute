# 🎧 音跃 SonicRoute

**简体中文** | [English](README.en.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![爱发电](https://img.shields.io/badge/赞助-爱发电-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="使用指南"><img src="docs/images/mascot-headphones.png" width="80" align="right" alt="音跃使用指南"></a>

**把每个应用的声音，送到你想要的设备。**

SonicRoute 是常驻托盘的 Windows 音频工具：为应用分别选择输出与输入设备，让音乐走音箱，游戏和通话走耳机。用快捷键、托盘区域滚轮或快速面板控制声音，再把常用操作组合成自动化规则。

📥 [下载正式版](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) ｜ [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) ｜ [使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) ｜ [Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64（实验） · 九种语言 · MIT 开源

<table>
  <tr>
    <th width="35%" align="left">快捷面板 · 应用音量与设备切换</th>
    <th width="65%" align="left">主题设置 · 按你的习惯调整</th>
  </tr>
  <tr>
    <td valign="top"><a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" alt="SonicRoute 快捷面板：所选输出设备、应用音量与实时声音活动"></a></td>
    <td valign="top"><a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" alt="SonicRoute 主题设置：主题模式、强调色与背景透明度"></a></td>
  </tr>
</table>

## ✨ SonicRoute 的特点

- **按应用分配声音**：分别设置应用的播放与录音设备，也能切换运行中应用的设备或 Windows 系统默认设备。应用路由由 Windows 保存，退出 SonicRoute 后仍会保留。
- **围绕当前应用操作**：根据前台与音频会话识别当前应用，支持最近使用、上次操作和指定应用。常用设备可筛选、改名，用同一组快捷键循环切换。
- **快捷键与托盘滚轮**：支持键盘组合、鼠标侧键与滚轮组合；在任务栏托盘区域滚动即可调整当前应用音量。全局麦克风静音也可单独绑定。
- **两种面板，各有侧重**：快捷面板逐行管理应用，顶部控制所选输出设备；应用面板集中控制当前应用。配合 OSD 操作提示、应用声音电平和麦克风静音提示，随时确认状态。
- **一次触发，多步完成**：六种触发、十八种操作，可组合设备切换、音量、静音、程序启动、PowerShell 和 OSD；每步可设延时及失败后停止，也能调用另一条规则。软件已运行时，可从脚本使用 `sr "规则名称或ID"` 执行。
- **按你的习惯设置**：深浅主题、强调色、透明度与面板位置可调；内置九种语言，支持语言 JSON 导入与导出。

## 🎮 这样使用

| 你的场景 | SonicRoute 可以做什么 |
|---|---|
| 音乐、游戏和语音软件同时使用 | 为各应用选择不同的输出或输入设备，并分别控制音量 |
| 在耳机与音箱之间切换 | 勾选常用设备，用快捷键循环切换当前应用的设备 |
| 想调整正在使用的应用 | 在最近使用模式下跟随有音频会话的前台应用，通过快捷键或托盘滚轮调节 |
| 每次打开某个应用都要重复设置 | 用应用启动触发规则，依次设置设备、音量和其他操作 |
| 用脚本或其他工具调用音频场景 | 创建多步规则，再用 `sr "规则名称或ID"` 调用 |

## 🚀 下载与开始使用

**当前正式版：[v1.22](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.22)** · 2026-10-11 · [更新说明](docs/release-v1.22.md)

普通 Windows x64 用户可优先选择 Microsoft Store，方便安装与自动更新；希望使用单个 EXE 可选择 Lite x64；不方便安装 .NET 8 时可选择 Legacy x64。上方“下载正式版”始终指向最新发布，下表直链对应 v1.22。

| 版本 | 下载 | 运行要求 |
|---|---|---|
| Lite x64 | [单个 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64（实验） | [单个 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [完整 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) | .NET Framework 4.8；完整解压后运行 |
| Microsoft Store | [商店安装](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64；支持自动更新，以商店在架版本为准 |

Lite 请安装对应架构的 [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)。Legacy 无需安装 .NET 8。

1. 启动后在系统托盘找到 SonicRoute（可能位于隐藏图标中），双击图标打开完整界面。
2. 在「设置 → 保留的设备」勾选常用输出与输入设备。
3. 单击托盘打开快速面板，或到快捷键页设置操作；需要组合操作时再创建自动化规则。

首次使用 `sr` 时，正常启动软件登记命令后重新打开终端。设备切换遇到问题时，可按 [常见问题](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) 排查。

1.22 改进自启状态同步，分开商店版与普通版自启控制；自动化页面按需加载，菜单样式统一，命令复制与九语文案同步改进。旧版变化见 [版本历史](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2)。

## 📚 使用文档

| 想了解什么 | 文档 |
|---|---|
| 安装、面板与常见操作 | [使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [功能特性](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| 默认按键、录制与作用范围 | [快捷键](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| 触发条件、多步操作与脚本调用 | [自动化规则](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [命令行](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| 安装与功能排障 | [常见问题](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| 源码、构建与版本记录 | [技术实现](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [版本相关](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [版本历史](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 后续计划

- **v1.23 · 性能与稳定性**：继续改善后台资源占用、响应速度与兼容性。
- **后续阶段**：根据反馈持续完善现有功能。计划可能随反馈调整。

[提交建议或问题](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose)。

## 🧩 其他作品与组合用法

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**：Windows 音频播放器；可搭配自动化「启动程序」实现按键播放音效。[查看组合教程](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**：Windows 音频控制库（.NET），提供设备、会话、按应用路由、事件与 CLI。

---

**作者主页：[哔哩哔哩](https://b23.tv/TDqSAKM) ｜ [爱发电](https://www.ifdian.net/a/koukou021) ｜ [GitHub](https://github.com/kunkunkunQoQ)**
