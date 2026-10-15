<!-- Generated from docs/readme/shared.json and docs/readme/locales/zh-TW.json. Edit those sources, then run node docs/readme/generate.cjs. -->
# 🎧 音躍 SonicRoute

[简体中文](README.md) | [English](README.en.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md) | [Deutsch](README.de.md) | [Français](README.fr.md) | [Español](README.es.md) | [Русский](README.ru.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![在 Afdian 支援我們](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**將每個應用程式的音訊輸出至您選擇的裝置。**

SonicRoute 是常駐於 Windows 系統匣的音訊工具：可為個別應用程式選擇輸出與輸入裝置，讓音樂從喇叭播放，遊戲或通話則使用耳機。透過快速鍵、系統匣滾輪或面板控制音訊，並將日常操作組合成自動化規則。

📥 [下載最新版本](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) · [使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Wiki（簡體中文）](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64（實驗性） · 支援九種介面語言 · MIT 授權

<div>
<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="使用指南（簡體中文）"><img src="docs/images/mascot-panel-peek.png" width="104" align="middle" alt="點擊看板娘開啟使用指南"></a>
<br>
<a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" align="top" alt="SonicRoute 快捷面板：頂端輸出裝置與各應用程式音量控制"></a>
<a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" align="top" alt="SonicRoute 主題設定：外觀、強調色與背景透明度"></a>
</div>

<sub>介面範例：快捷面板管理各應用程式音量與路由；主題設定可調整外觀。</sub>

## ✨ SonicRoute 的功能

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7" title="功能"><img src="docs/images/mascot-music-hoodie.png" width="68" align="right" alt="點擊看板娘瀏覽 SonicRoute 功能"></a>

### 核心功能

- **為個別應用程式設定音訊路由。** 為每個應用程式選擇播放與錄音裝置、切換執行中應用程式的裝置，或變更 Windows 預設裝置。結束 SonicRoute 後，Windows 仍會保留應用程式的路由設定。
- **控制目前使用的應用程式。** 根據前景活動與音訊工作階段判斷目前應用程式。「最近使用」模式會優先選擇位於前景且有音訊工作階段的應用程式；「上次操作」模式會記住最後操作的應用程式，也可指定應用程式。篩選並重新命名偏好的裝置，再用同一組快速鍵輪替切換。
- **快速鍵與系統匣滾輪。** 指定鍵盤組合、滑鼠側鍵及滾輪組合。在工作列的系統匣區域上滾動，可調整目前應用程式的音量；也可另外指定快速鍵來靜音所有麥克風。系統匣選單可直接選擇系統預設輸出裝置，也能固定目前應用程式後調整音量、靜音或切換路由；亦可暫停系統匣滾輪調整，設定會在重新啟動後保留。
- **兩種面板，各有不同用途。** 快捷面板逐列管理應用程式，並可在頂端控制所選輸出裝置；應用程式面板則聚焦於目前使用的應用程式。OSD 提示、應用程式音訊電平與麥克風靜音指示器，讓狀態一目了然。

### 次要功能

- **一次觸發，多項操作。** 6 種觸發條件與 18 種操作涵蓋裝置切換、音量、靜音、啟動程式、PowerShell 與 OSD。每個步驟都可加入延遲或設定失敗時停止，也可呼叫其他規則，或在 SonicRoute 執行中使用 `sr "規則名稱或 ID"` 呼叫規則。
- **打造自己的使用風格。** 調整淺色／深色主題、強調色、透明度與面板位置。內建九種語言，支援以 JSON 匯入與匯出語言檔。

→ [同類應用功能比較](https://github.com/kunkunkunQoQ/SonicRoute/wiki/10-%E5%90%8C%E7%B1%BB%E5%BA%94%E7%94%A8%E5%AF%B9%E6%AF%94)

## 🎮 日常使用情境

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99" title="自動化"><img src="docs/images/mascot-automation.png" width="48" align="middle" alt="點擊小機器人了解自動化規則"></a> 設定遊戲啟動時切換至耳機，或將多項操作儲存為一條規則。 [設定自動化](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99)。

| 使用情境 | 可以怎麼做 |
|---|---|
| 同時使用音樂、遊戲與語音聊天 | 為各應用程式選擇不同的輸出或輸入裝置，並分別調整音量 |
| 在喇叭與耳機之間切換 | 選擇偏好的裝置，並用快速鍵輪替目前應用程式的裝置 |
| 調整目前正在使用的應用程式 | 在「最近使用」模式下，跟隨有音訊工作階段的前景應用程式，再用快速鍵或系統匣滾輪調整 |
| 每次啟動應用程式時重複相同設定 | 設定應用程式啟動時觸發規則，以設定裝置、音量及其他操作 |
| 從指令碼或其他工具呼叫音訊設定 | 建立規則並使用 `sr "規則名稱或 ID"` 呼叫 |

## 🚀 下載與快速入門

**目前版本：[v1.23](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.23)** · 2026-10-15 · [發布說明（簡體中文）](docs/release-v1.23.md)

大多數 Windows x64 使用者可優先選擇 Microsoft Store 版本，安裝方便並支援自動更新。需要單一執行檔可選 Lite x64；不方便安裝 .NET 8 則可選 Legacy x64。上方下載連結一律指向最新版本；下方的直連下載對應 v1.23。

| 版本 | 下載 | 需求 |
|---|---|---|
| Lite x64 | [單一 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64（實驗性） | [單一 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [完整 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Legacy-x64.zip) | .NET Framework 4.8；執行前請解壓縮整個 ZIP |
| Microsoft Store | [從 Store 安裝](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64；自動更新；Store 上會顯示目前提供的版本 |

Lite 需要相符的 [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)。Legacy 不需要 .NET 8。

1. 啟動 SonicRoute，在 Windows 系統匣中找到它的圖示（可能位於隱藏圖示中），然後按兩下以開啟完整介面。
2. 在設定中選擇偏好的輸出與輸入裝置。
3. 點擊系統匣圖示開啟面板，或設定快速鍵。需要組合多項操作時，再建立自動化規則。

首次使用 `sr` 前，請先正常啟動 SonicRoute 以註冊指令，然後重新開啟終端機。若裝置切換未如預期運作，請參閱 [常見問題](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)。

1.23 新增從系統匣直接選擇預設輸出、固定目前應用程式的音量／靜音／路由控制、靜音所有麥克風，以及重新啟動後仍會保留的系統匣滾輪暫停設定。系統預設音量的預設快速鍵為 Ctrl+Alt+Shift+滾輪，與控制目前應用程式的預設快速鍵 Ctrl+Alt+滾輪區分。設定開關配置已調整，頁面改為按需載入。舊版變更請參閱 [版本紀錄](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2)。

## 📚 文件

詳細 Wiki 目前以簡體中文提供。

| 主題 | 指南 |
|---|---|
| 安裝、面板與日常操作 | [使用指南](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [功能](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| 預設按鍵、綁定與控制目標 | [快速鍵](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| 觸發條件、操作與指令碼整合 | [自動化](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [命令列](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| 安裝與疑難排解 | [常見問題](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| 原始碼、建置與發布 | [原始碼與建置](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [發布資訊](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [版本紀錄](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 開發規劃

- **v1.24 · 效能與穩定性：** 改善背景資源使用量、回應速度與相容性。
- **後續階段：** 根據回饋持續改進現有功能。計畫可能隨回饋調整。

[分享想法或回報問題](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose)。

## 🧩 其他專案與組合用法

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**：Windows 音訊播放器。搭配「啟動程式」動作，即可透過快速鍵播放音效。 [設定指南（簡體中文）](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**：供 Windows 音訊裝置、工作階段、各應用程式路由、事件與 CLI 存取使用的 .NET 程式庫。

---

<a href="EASTER_EGGS.md" title="昨日與明日的彩蛋"><img src="docs/images/mascot-cozy-knit.png" width="56" align="right" alt="發現彩蛋"></a>

感謝使用 SonicRoute。 [閱讀指南（簡體中文）](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [回報問題](https://github.com/kunkunkunQoQ/SonicRoute/issues)。

**作者：[Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
