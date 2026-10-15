<!-- Generated from docs/readme/shared.json and docs/readme/locales/ko-KR.json. Edit those sources, then run node docs/readme/generate.cjs. -->
# 🎧 SonicRoute

[简体中文](README.md) | [English](README.en.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어** | [Deutsch](README.de.md) | [Français](README.fr.md) | [Español](README.es.md) | [Русский](README.ru.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Afdian에서 후원](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**앱마다 원하는 오디오 장치를 지정하세요.**

SonicRoute는 Windows 알림 영역에 상주하는 오디오 유틸리티입니다. 앱마다 출력 및 입력 장치를 선택해 음악은 스피커로, 게임이나 통화는 헤드셋으로 들을 수 있습니다. 단축키, 알림 영역 휠 또는 패널로 오디오를 제어하고, 자주 하는 작업을 자동화 규칙으로 묶어 보세요.

📥 [최신 릴리스 다운로드](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) · [사용자 가이드](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Wiki(중국어 간체)](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64 (실험적) · 인터페이스 9개 언어 지원 · MIT 라이선스

<div>
<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="사용자 가이드(중국어 간체)"><img src="docs/images/mascot-panel-peek.png" width="104" align="middle" alt="마스코트를 클릭해 사용자 가이드 열기"></a>
<br>
<a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" align="top" alt="SonicRoute 빠른 패널: 위쪽의 출력 장치와 앱별 볼륨 제어"></a>
<a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" align="top" alt="SonicRoute 테마 설정: 모양, 강조 색상 및 배경 불투명도"></a>
</div>

<sub>인터페이스 예시: 빠른 패널에서 앱별 볼륨과 라우팅을 제어하고, 테마 설정에서 모양을 바꿀 수 있습니다.</sub>

## ✨ SonicRoute의 주요 기능

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7" title="기능"><img src="docs/images/mascot-music-hoodie.png" width="68" align="right" alt="마스코트를 클릭해 SonicRoute 기능 살펴보기"></a>

- **앱을 찾는 시간을 줄입니다.** 현재 오디오 앱의 볼륨과 음소거를 조절하고 장치를 바꿀 수 있습니다.
- **앱별로 장치를 지정합니다.** 음악은 스피커로, 게임은 헤드폰으로 보내고 마이크도 각각 선택할 수 있습니다.
- **설정을 여는 횟수를 줄입니다.** 단축키, 알림 영역 휠, 빠른 패널로 자주 쓰는 작업을 처리해 Windows 설정을 반복해서 열지 않아도 됩니다.
- **반복 작업을 줄입니다.** 장치 전환, 볼륨 조절, 프로그램 실행을 자동화 규칙으로 묶을 수 있습니다.

## 🎮 일상적인 활용

게임 중 음악이 너무 큰가요? 게임 볼륨은 그대로 두고 음악 앱의 볼륨만 낮추세요.

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99" title="자동화"><img src="docs/images/mascot-automation-kr.png" width="48" align="middle" alt="작은 로봇을 클릭해 자동화 규칙 알아보기"></a> 게임이 시작되면 헤드셋으로 자동 전환하고 음성 채팅 앱을 엽니다. [자동화 설정](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99)

## 🚀 다운로드 및 시작하기

**현재 릴리스: [v1.23](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.23)** · 2026-10-15 · [릴리스 노트(중국어 간체)](docs/release-v1.23.md)

대부분의 Windows x64 사용자에게는 간편한 설치와 자동 업데이트를 제공하는 Microsoft Store 버전을 권장합니다. 단일 실행 파일을 원하면 Lite x64, .NET 8 설치가 어렵다면 Legacy x64를 선택하세요. 위 다운로드 링크는 항상 최신 릴리스를 가리키며, 아래 직접 링크는 v1.23용입니다.

| 에디션 | 다운로드 | 요구 사항 |
|---|---|---|
| Lite x64 | [단일 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-x64.exe) | x64 .NET 8 Desktop Runtime |
| Lite ARM64 (실험적) | [단일 EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-arm64.exe) | ARM64 .NET 8 Desktop Runtime |
| Legacy x64 | [전체 ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Legacy-x64.zip) | .NET Framework 4.8; 실행 전에 ZIP 전체 압축을 푸세요 |
| Microsoft Store | [Store에서 설치](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64; 자동 업데이트; Store에서 제공 중인 버전을 확인할 수 있습니다 |

Lite에는 호환되는 [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)이 필요합니다. Legacy에는 .NET 8이 필요하지 않습니다.

1. SonicRoute를 시작한 뒤 Windows 알림 영역에서 아이콘을 찾으세요(숨겨진 아이콘에 있을 수 있습니다). 아이콘을 두 번 클릭하면 전체 인터페이스가 열립니다.
2. 설정에서 원하는 출력 및 입력 장치를 선택하세요.
3. 알림 영역 아이콘을 클릭해 패널을 열거나 단축키를 설정하세요. 여러 작업을 조합하려면 자동화 규칙을 만드세요.

`sr`을 처음 사용하기 전에 SonicRoute를 일반 실행해 명령을 등록한 다음 터미널을 다시 여세요. 장치 전환이 예상대로 작동하지 않으면 [자주 묻는 질문](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)를 참고하세요.

1.23에서는 알림 영역에서 기본 출력 장치를 바로 선택하고, 고정한 현재 앱의 볼륨·음소거·라우팅을 제어하며, 모든 마이크를 음소거할 수 있습니다. 재시작 후에도 유지되는 알림 영역 휠 일시 중지 설정도 추가했습니다. 시스템 기본 볼륨의 기본 단축키는 Ctrl+Alt+Shift+휠이며 현재 앱의 기본 Ctrl+Alt+휠 단축키와 구분됩니다. 설정 토글 배치를 조정하고 페이지를 필요할 때 불러오도록 개선했습니다. 이전 변경 사항은 [버전 기록](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2)에서 확인하세요.

## 📚 문서

자세한 Wiki는 현재 중국어 간체로 제공됩니다.

| 주제 | 가이드 |
|---|---|
| 설치, 패널 및 일상적인 제어 | [사용자 가이드](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [기능](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| 기본 키, 할당 및 제어 대상 | [단축키](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| 트리거, 작업 및 스크립트 연동 | [자동화](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [명령줄](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| 설치 및 문제 해결 | [자주 묻는 질문](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| 소스, 빌드 및 릴리스 | [소스 및 빌드](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [릴리스 정보](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [버전 기록](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 로드맵

- **v1.24 · 성능 및 안정성:** 백그라운드 리소스 사용량, 응답성 및 호환성을 개선합니다.
- **향후 단계:** 의견을 바탕으로 기존 기능을 계속 다듬습니다. 계획은 피드백에 따라 변경될 수 있습니다.

[아이디어 공유 또는 문제 제보](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose).

## 🧩 다른 프로젝트와 함께 사용하기

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**: Windows용 오디오 플레이어입니다. 자동화의 ‘프로그램 실행’ 동작과 함께 사용하면 단축키로 효과음을 재생할 수 있습니다. [설정 가이드(중국어 간체)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**: Windows 오디오 장치, 세션, 앱별 라우팅, 이벤트 및 CLI 접근을 위한 .NET 라이브러리입니다.

---

<a href="EASTER_EGGS.md" title="어제와 내일의 이스터 에그"><img src="docs/images/mascot-cozy-knit.png" width="56" align="right" alt="쉬고 있는 마스코트를 클릭해 이스터 에그 찾기"></a>

SonicRoute를 사용해 주셔서 감사합니다. [가이드 읽기(중국어 간체)](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [문제 제보](https://github.com/kunkunkunQoQ/SonicRoute/issues).

**제작자: [Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
