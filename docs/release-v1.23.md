# SonicRoute v1.23 正式版

2026-10-15 · [下载正式版](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.23)

## 更新内容

- **托盘直接操作声音**：右键菜单新增系统默认输出设备选择、当前应用音量预设与静音、应用输出路由及全部麦克风静音。菜单打开时固定当前应用，操作过程中不会跟随切换到其他应用。
- **暂停托盘滚轮**：可在右键菜单暂停或恢复托盘区域的滚轮调音量，选择保存到配置，重启后继续生效；独立的全局音量快捷键仍可使用。
- **区分应用与系统音量**：当前应用音量的默认快捷键为 `Ctrl+Alt+滚轮上/下`；新增系统默认输出设备音量操作，默认快捷键为 `Ctrl+Alt+Shift+滚轮上/下`。已有自定义键位保留，也可在快捷键页自行调整。
- **设置更直观**：“同时监听默认输入静音”移到“麦克风静音时 OSD 常驻”下方，开启常驻后显示；OSD 的“更多选项”保留。“在快捷面板显示麦克风”移到麦克风选项下方，开启麦克风选项后显示；应用实时音量活动采用统一开关样式。
- **窗口与菜单加载**：更多设置页面按需创建，重复打开菜单时复用控件；关闭窗口和菜单后及时停止不再需要的界面读取，减少后台重复工作。
- **多语言与介绍**：同步九语界面文案，README 按核心功能和次要功能组织，继续共用版本、下载链接和生成版式。

## 下载

| 版本 | 下载 | 运行要求 |
|---|---|---|
| Lite x64 | [单个 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64（实验） | [单个 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [完整 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Legacy-x64.zip) | .NET Framework 4.8 |

支持 Windows 10 2004+ / Windows 11。Lite 请安装对应架构的 .NET 8 Desktop Runtime；Legacy 请完整解压后运行。文件校验值见发布附件 `SHA256SUMS.txt`。

Microsoft Store 提供安装和自动更新，实际版本以[商店页面](https://apps.microsoft.com/detail/9NQZGRTPM1NT)为准。

## 升级

退出旧版本后替换 Lite EXE，或解压完整 Legacy 文件夹。原有设置、自动化规则和外置语言继续使用。商店版与普通版的开机自启仍分开控制。

[使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [完整 Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT)
