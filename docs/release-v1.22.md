# SonicRoute v1.22 正式版

2026-10-11 · [下载正式版](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.22)

## 更新内容

- **精简依赖**：精简商店自启动接口，缩小 Lite 程序体积。
- **开机自启**：商店版与普通版使用两个独立自启项，分别控制；修复两版窗口激活混用，改进开关与系统状态的同步。
- **窗口加载**：自动化页面首次进入时加载，切换页面时复用控件。
- **统一菜单**：托盘、自动化和音量预设菜单采用统一样式，移除默认灰色区域与图标留白。
- **命令复制**：修复“复制执行命令”卡顿，增加后台重试和失败提示。
- **多语言**：修正九种语言的用词、语法与标点，使表达更自然。

## 下载

| 版本 | 下载 | 运行要求 |
|---|---|---|
| Lite x64 | [单个 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64（实验） | [单个 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [完整 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) | .NET Framework 4.8 |

支持 Windows 10 2004+ / Windows 11。Lite 请安装对应架构的 Desktop Runtime；Legacy 请完整解压后运行。

## 升级

退出旧版本后替换 Lite EXE，或解压完整 Legacy 文件夹。原有设置、自动化规则和外置语言继续使用，无需重新配置。

[使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [完整 Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT)
