# SonicRoute v1.22 正式版

2026-10-11 · [GitHub Release](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.22)

本版采用精简商店接口实现，改进自启状态同步，减少首次主窗口创建的控件数量，并修正菜单、命令复制及九语文案。产品信息版本为纯数字 **1.22**。

## 下载与升级

| 版本 | 下载 | 要求 |
|---|---|---|
| Lite x64 | [单EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64（实验） | [单EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime；未完成真机完整验证 |
| Legacy x64 | [完整ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) | .NET Framework 4.8；完整解压后运行 |

支持 Windows 10 2004+ / Windows 11。升级前正常退出旧实例，Lite替换EXE，Legacy解压完整目录；设置、规则和外置语言沿用 `%LocalAppData%\SonicRoute`，单实例、CLI管道及绿色自启登记名与旧正式版兼容。试验版的ExperimentData不自动迁入正式目录。

## 主要变化

- **精简接口依赖**：只生成StartupTask所需商店接口，Lite x64文件约3.78MiB。包体缩小不等于运行内存按同一比例下降。
- **自启状态**：状态已满足时不重复请求；系统用户禁用、策略限制及未知状态保留正确提示。异常后回读可获取的真实状态，失败时显示最后已知状态；设置未变不重复保存。
- **窗口控件**：自动化页首次进入才创建，同一打开窗口内切换复用，关闭解除订阅，再开创建独立窗口。
- **菜单与命令复制**：统一WPF菜单模板，去掉默认灰色区域和图标空栏，保留勾选及收藏；剪贴板写入使用短时后台STA线程有限重试，持续占用时明确提示失败。
- **九语文案**：修正含义、语法、动作范围、繁体术语、韩语助词和欧洲语言标点；保留即时语言绑定刷新。没有母语人士及全界面溢出验收。
- **文档整理**：使用说明以现行Wiki为正文，旧主题/自动化页面改为入口；v1.21阶段验证集中到历史发布附录。

## 本次发布验证

Lite x64、Lite ARM64、Legacy x64均编译发布成功。现有及生成代码警告仍存在，不能称零警告。

- 64项隔离自启状态、模拟登记与正式数据路径检查通过；不读写真实注册表或生产自启任务。
- 88项菜单、语言及界面夹具回归，25项命令复制/菜单断言通过；系统剪贴板与真实音频未操作。
- Lite x64和Legacy x64发布EXE各通过九语帮助入口，共18项；只证明语言加载及CLI入口，不代表真实鼠标全界面验收。
- x64商店包使用既有Name/Publisher及StartupTask身份，版本1.22.0.0，47个图标资产和PRI完整；包内EXE与正式Lite x64产物哈希相同。已构建未签名MSIX供商店提交，尚未提交Partner Center或宣称商店上架。

本轮未重复ARM64真机、真实开机登录及正式WindowsApps安装验证。

## 性能与已知边界

此前本机隔离精简构建的页面按需创建对照，首次主窗口到Dispatcher空闲中位数211.008→202.126ms（约−4.2%），创建期间线程分配减少约7.6%；首次进入自动化页约增加5.7ms。测量范围重叠，终点不是屏幕首帧；CPU中位数没有降低，私有提交低于30MB目标未达成。本次正式身份与版本元数据调整没有重新测量性能，不能将旧测值称为正式交付EXE的新测值。

透明度设为0%时窗口空白处可能鼠标穿透、无法拖拽，该问题仍保留。需要拖动时使用非零透明度。商店实际版本以上架状态为准。

当前使用方法见 [Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki)，旧版验证记录见 [v1.21](release-v1.21.md)。
