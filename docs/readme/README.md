# README 维护 / Maintaining the READMEs

九份 README 是同一版式的静态 Markdown，GitHub 可直接显示。简体中文保留根 README.md，英文保留 README.en.md，另有繁体中文、日语、韩语、德语、法语、西班牙语和俄语入口。

| 需要更新的内容 | 唯一维护位置 |
|---|---|
| 版本、发布日期、下载及作者链接、语言导航 | [shared.json](shared.json) |
| 各语言简介、核心/次要功能、入门与替代文本 | [locales](locales/) 下对应语言 JSON；核心和次要功能分别使用 `featuresCore` 与 `featuresMore` |
| README 的同类应用对比入口 | `locales/<language>.json` 的 `comparison` 文案和 [shared.json](shared.json) 的 `wikiPages.comparison` 目标，由 [generate.cjs](generate.cjs) 统一生成 |
| 排版、徽章、图片尺寸与共同结构 | [generate.cjs](generate.cjs) |
| 详细操作与排障 | [Wiki](https://github.com/kunkunkunQoQ/SonicRoute/wiki) 或现有 docs 正文 |
| 某版本的变化及升级说明 | docs/release-vX.Y.md，shared.json 链接该文件 |
| 计划版本及触发/操作数量 | shared.json；相应说明保留在各语言文案 |

不要直接编辑生成的 README。使用 Node.js 24，无需安装依赖，从仓库根目录运行：

```powershell
node docs/readme/generate.cjs
node docs/readme/generate.cjs --check
```

第一条生成九份文件；第二条只检查，不写文件。检查缺少语言、字段、列表项数、占位符和生成结果不同步时返回非零退出码。GitHub Actions 会运行同一检查，不自动翻译或提交。

发布新版时统一更新 shared.json 中的 release、releaseDate、releaseNotes；由 release 自动拼出三个直链，不逐份手改。最新下载入口始终指向 Releases/latest，商店独立使用其在架版本。releaseSummary维护各语言的版本摘要；详细变化仍由现有发布说明维护。后续计划的版本号由 nextRelease 统一维护。

修改功能说明时，以实现和中文文案核对语义，再更新九种文案、生成并审读。核心功能与次要功能分别使用 `featuresCore`、`featuresMore`，由生成器统一排版；自动化和外观说明保留完整。各字段里的占位符必须保留；`{release}`、`{version}`、`{nextRelease}`统一版本，`{triggerCount}`、`{actionCount}`统一数量，`{arch}`、`{runtime}`、`{faq}`、`{history}`统一架构与链接，`{ruleCommand}`统一命令示例。`sr` 是命令名，只有示例规则名称可以本地化。翻译要符合当地表达，模式和控件名称参考 SonicRoute/Resources/Lang；JSON 结构检查不代表母语审校。

提交本目录的源文件、九份生成 README 以及检查流程。生成器不会读本地维护档案、用户配置或签名材料。既有功能特点、使用场景、下载、入门、版本摘要、文档表、后续计划、其他作品和看板娘均完整保留；这次调整的是同步维护方式，不是精简介绍。

---

The nine READMEs share one layout and link manifest. Edit shared.json for versions, links and common facts, locales/<language>.json for text, and generate.cjs for layout. Existing features, use cases, downloads, getting-started steps, release summary, documentation table, roadmap, other projects and artwork are retained in full.

Run the commands above with Node.js 24; no dependencies are needed. Commit both the sources and generated Markdown. `--check` is read-only and fails when a translation is incomplete or the generated files are stale. The workflow checks consistency; it does not translate, publish or commit changes.
