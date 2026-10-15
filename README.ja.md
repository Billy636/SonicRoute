<!-- Generated from docs/readme/shared.json and docs/readme/locales/ja-JP.json. Edit those sources, then run node docs/readme/generate.cjs. -->
# 🎧 SonicRoute

[简体中文](README.md) | [English](README.en.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md) | [Deutsch](README.de.md) | [Français](README.fr.md) | [Español](README.es.md) | [Русский](README.ru.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Afdian で支援](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**アプリごとに、音声の出力先デバイスを選べます。**

SonicRoute は Windows の通知領域に常駐するオーディオツールです。アプリごとに出力・入力デバイスを選び、音楽はスピーカーで、ゲームや通話はヘッドセットで再生できます。ホットキー、通知領域のホイール、パネルで音声を操作し、日常の操作を自動化ルールにまとめられます。

📥 [最新リリースをダウンロード](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) · [ユーザーガイド](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Wiki（簡体字中国語）](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64（実験的） · 9 種類の UI 言語 · MIT ライセンス

<div>
<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="ユーザーガイド（簡体字中国語）"><img src="docs/images/mascot-panel-peek.png" width="104" align="middle" alt="マスコットをクリックしてユーザーガイドを開く"></a>
<br>
<a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" align="top" alt="SonicRoute クイックパネル：上部の出力デバイスとアプリごとの音量操作"></a>
<a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" align="top" alt="SonicRoute のテーマ設定：外観、アクセントカラー、背景の不透明度"></a>
</div>

<sub>画面例：クイックパネルでアプリごとの音量とルーティングを操作し、テーマ設定で外観を調整できます。</sub>

## ✨ SonicRoute の主な機能

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7" title="機能"><img src="docs/images/mascot-music-hoodie.png" width="68" align="right" alt="マスコットをクリックして SonicRoute の機能を見る"></a>

### 主な機能

- **アプリごとの音声ルーティング。** アプリごとに再生・録音デバイスを選び、実行中のアプリのデバイスを切り替えたり、Windows の既定デバイスを変更したりできます。SonicRoute を終了しても、アプリのルーティング設定は Windows に保持されます。
- **使用中のアプリを操作。** 「最近使用」モードでは、前面にありオーディオセッションがあるアプリを優先します。「最後に操作したアプリ」モードでは、最後に操作したアプリを記憶します。アプリを指定することもできます。好みのデバイスを絞り込んで名前を付け、同じホットキーで順番に切り替えられます。
- **ホットキーと通知領域のホイール。** キーの組み合わせ、マウスのサイドボタン、ホイールとの組み合わせを割り当てられます。タスクバーの通知領域でスクロールすると現在のアプリの音量を調整でき、すべてのマイクをミュートする専用ショートカットも設定できます。 通知領域メニューから Windows の既定出力デバイスを直接選択できます。現在のアプリを固定して音量、ミュート、ルーティングを操作したり、通知領域ホイールによる音量調整を一時停止したりできます。停止設定は再起動後も保持されます。
- **役割の異なる 2 種類のパネル。** クイックパネルではアプリを行ごとに管理し、上部で選択中の出力デバイスを操作できます。アプリパネルは現在のアプリに焦点を当てます。OSD、アプリの音量メーター、マイクのミュート表示で状態を確認できます。

### その他の機能

- **1 つのトリガーで複数の操作。** 6 種類のトリガーと 18 種類の操作で、デバイス切り替え、音量、ミュート、プログラム起動、PowerShell、OSD を組み合わせられます。各ステップに遅延や失敗時に停止する設定を追加したり、別のルールを呼び出したりできます。SonicRoute の実行中は `sr "ルール名または ID"` でルールを呼び出せます。
- **自分好みにカスタマイズ。** ライト／ダークテーマ、アクセントカラー、透明度、パネル位置を調整できます。内蔵の 9 言語に対応し、言語ファイルを JSON 形式でインポート・エクスポートできます。

## 🎮 日常での使い方

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99" title="自動化"><img src="docs/images/mascot-automation-jp.png" width="48" align="middle" alt="ロボットをクリックして自動化ルールを確認する"></a> ゲームの起動時にヘッドセットへ切り替えたり、複数の操作を 1 つのルールに保存したりできます。 [自動化を設定](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99)。

| 利用シーン | できること |
|---|---|
| 音楽、ゲーム、ボイスチャットを同時に使う | アプリごとに別の出力・入力デバイスを選び、それぞれの音量を調整する |
| スピーカーとヘッドセットを切り替える | 好みのデバイスを選び、ホットキーで現在のアプリのデバイスを切り替える |
| 作業中のアプリを調整する | 最近使用モードでは、音声セッションのある前面アプリに追従し、ホットキーや通知領域のホイールで操作する |
| アプリの起動時に同じ設定を繰り返す | アプリの起動をトリガーにして、デバイスや音量などを設定するルールを実行する |
| スクリプトや他のツールから音声設定を呼び出す | ルールを作成し、`sr "ルール名または ID"` で呼び出す |

## 🚀 ダウンロードと使い始め方

**現在のリリース：[v1.23](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.23)** · 2026-10-15 · [リリースノート（簡体字中国語）](docs/release-v1.23.md)

Windows x64 をお使いの方には、インストールが簡単で自動更新にも対応する Microsoft Store 版がおすすめです。単体の実行ファイルなら Lite x64、.NET 8 のインストールが難しい場合は Legacy x64 を選んでください。上のダウンロードリンクは常に最新リリースを示し、下の直接リンクは v1.23 用です。

| エディション | ダウンロード | 要件 |
|---|---|---|
| Lite x64 | [単体 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64（実験的） | [単体 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [完全版 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Legacy-x64.zip) | .NET Framework 4.8。実行前に ZIP 全体を展開してください |
| Microsoft Store | [Store からインストール](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64；自動更新；Store に現在提供中のバージョンが表示されます |

Lite には対応する [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0) が必要です。Legacy に .NET 8 は必要ありません。

1. SonicRoute を起動し、Windows の通知領域（隠れているアイコンの中にある場合があります）でアイコンを見つけて、ダブルクリックでメイン画面を開きます。
2. 設定で使いたい出力・入力デバイスを選びます。
3. 通知領域のアイコンをクリックしてパネルを開くか、ホットキーを設定します。複数の操作を組み合わせる場合は、自動化ルールを作成します。

`sr` を初めて使う前に、SonicRoute を通常起動してコマンドを登録し、ターミナルを開き直してください。デバイス切り替えが想定どおりに動作しない場合は [よくある質問](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) をご覧ください。

1.23 では通知領域から既定の出力デバイスを直接選べるようになり、固定した現在のアプリの音量・ミュート・ルーティング操作、全マイクのミュート、再起動後も保持される通知領域ホイールの一時停止設定を追加しました。システム既定音量のデフォルトのホットキーは Ctrl+Alt+Shift+ホイールで、現在のアプリ用のデフォルトの Ctrl+Alt+ホイールと区別されます。設定スイッチの配置を調整し、ページを必要に応じて読み込むようにしました。以前の変更は [バージョン履歴](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) をご覧ください。

## 📚 ドキュメント

詳細な Wiki は現在、簡体字中国語で公開されています。

| トピック | ガイド |
|---|---|
| インストール、パネル、日常の操作 | [ユーザーガイド](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [機能](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| 既定のキー、割り当て、操作対象 | [ホットキー](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| トリガー、アクション、スクリプト連携 | [自動化](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [コマンドライン](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| インストールとトラブルシューティング | [よくある質問](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| ソース、ビルド、リリース | [ソースコードとビルド](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [リリース情報](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [バージョン履歴](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 ロードマップ

- **v1.24 · パフォーマンスと安定性：** バックグラウンドのリソース使用量、応答性、互換性を改善します。
- **今後の段階：** フィードバックをもとに既存機能を継続的に改善します。計画はフィードバックに応じて変更される場合があります。

[アイデアの共有・問題の報告](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose)。

## 🧩 その他のプロジェクトと組み合わせ方

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**：Windows 向けオーディオプレーヤーです。「プログラムを起動」アクションと組み合わせると、ホットキーで効果音を再生できます。 [設定ガイド（簡体字中国語）](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**：Windows のオーディオデバイス、セッション、アプリごとのルーティング、イベント、CLI アクセスに対応する .NET ライブラリです。

---

<a href="EASTER_EGGS.md" title="昨日と明日のイースターエッグ"><img src="docs/images/mascot-cozy-knit.png" width="56" align="right" alt="休んでいるマスコットをクリックしてイースターエッグを見つける"></a>

SonicRoute をご利用いただきありがとうございます。 [ガイドを読む（簡体字中国語）](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [問題を報告](https://github.com/kunkunkunQoQ/SonicRoute/issues)。

**作者：[Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
