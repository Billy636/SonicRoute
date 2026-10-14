<!-- Generated from docs/readme/shared.json and docs/readme/locales/de-DE.json. Edit those sources, then run node docs/readme/generate.cjs. -->
# 🎧 SonicRoute

[简体中文](README.md) | [English](README.en.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md) | **Deutsch** | [Français](README.fr.md) | [Español](README.es.md) | [Русский](README.ru.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Unterstützung auf Afdian](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**Leite den Ton jeder App an das gewünschte Gerät weiter.**

Lass Musik über deine Lautsprecher laufen und Spiele oder Anrufe über dein Headset. SonicRoute ist ein Windows-Audiowerkzeug im Infobereich: Wähle für einzelne Apps Ausgabe- und Eingabegeräte, steuere den Ton per Tastenkürzel, Mausrad im Infobereich oder Panel und kombiniere wiederkehrende Aktionen zu Automatisierungsregeln.

📥 [Neueste Version herunterladen](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) · [Benutzerhandbuch](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Wiki (Chinesisch)](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64 (experimentell) · Neun Sprachen · MIT-Lizenz

<div>
<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="Benutzerhandbuch (Chinesisch)"><img src="docs/images/mascot-panel-peek.png" width="104" align="middle" alt="Klicke auf das Maskottchen, um das Benutzerhandbuch zu öffnen"></a>
<br>
<a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" align="top" alt="SonicRoute-Schnellpanel mit Ausgabegerät und Lautstärkereglern pro App"></a>
<a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" align="top" alt="SonicRoute-Designeinstellungen für Erscheinungsbild, Akzentfarbe und Hintergrunddeckkraft"></a>
</div>

<sub>Oberflächenbeispiele: Schnellpanel für App-Lautstärke und Audiozuweisung; Designeinstellungen für das Erscheinungsbild.</sub>

## ✨ Das bietet SonicRoute

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7" title="Funktionen"><img src="docs/images/mascot-headphones.png" width="68" align="right" alt="Klicke auf das Maskottchen, um die SonicRoute-Funktionen zu entdecken"></a>

- **Audio je App weiterleiten.** Weise Apps eigene Wiedergabe- und Aufnahmegeräte zu, wechsle Geräte für laufende Apps oder ändere die Windows-Standardgeräte. Windows behält die App-Zuweisungen auch nach dem Beenden von SonicRoute bei.
- **Die gerade verwendete App steuern.** Ermittle die aktuelle App anhand der Vordergrundaktivität und der Audiositzungen. Im Modus „Zuletzt aktiv“ folgt SonicRoute der zuletzt im Vordergrund aktiven App mit einer Audiositzung; „Zuletzt gesteuert“ merkt sich die zuletzt von dir bediente App. Auch eine festgelegte App lässt sich auswählen. Filtere und benenne bevorzugte Geräte um und wechsle per Tastenkürzel zwischen ihnen.
- **Tastenkürzel und Mausrad im Infobereich.** Belege Tastenkombinationen, seitliche Maustasten und Mausrad-Kombinationen. Passe die Lautstärke der aktuellen App durch Scrollen im Infobereich der Taskleiste an oder weise eine separate Tastenkombination zum Stummschalten aller Mikrofone zu.
- **Zwei Panels mit unterschiedlichen Aufgaben.** Im Schnellpanel verwaltest du Apps in einzelnen Zeilen und steuerst oben das gewählte Ausgabegerät; das App-Panel konzentriert sich auf die aktuelle App. OSD-Rückmeldungen, Audioanzeigen pro App und Mikrofon-Stummschaltanzeigen machen den Status sichtbar.
- **Ein Auslöser, mehrere Aktionen.** 6 Auslöser und 18 Aktionen decken Gerätewechsel, Lautstärke, Stummschaltung, Programmstarts, PowerShell und OSD ab. Lege für jeden Schritt eine Verzögerung oder Abbruch bei Fehlern fest, rufe eine andere Regel auf oder führe mit `sr "Regelname oder ID"` eine Regel in einer bereits laufenden SonicRoute-Instanz aus.
- **Gestalte SonicRoute nach deinem Geschmack.** Passe helle und dunkle Designs, Akzentfarben, Deckkraft und Panelposition an. Die neun integrierten Sprachen unterstützen den Import und Export von JSON-Dateien.

## 🎮 Für den Alltag

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99" title="Automatisierung"><img src="docs/images/mascot-automation.png" width="48" align="middle" alt="Klicke auf den kleinen Roboter, um mehr über Automatisierungsregeln zu erfahren"></a> Stelle ein Spiel beim Start auf dein Headset um oder speichere mehrere Aktionen als eine Regel. [Automatisierung einrichten](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99).

| Deine Situation | Das kannst du tun |
|---|---|
| Musik, Spiele und Sprachchat gleichzeitig nutzen | Für jede App eigene Ausgabe- oder Eingabegeräte wählen und die Lautstärke einzeln anpassen |
| Zwischen Lautsprechern und Headset wechseln | Bevorzugte Geräte auswählen und das Gerät der aktuellen App per Tastenkürzel wechseln |
| Die gerade verwendete App anpassen | Im Modus „Zuletzt aktiv“ der Vordergrund-App mit Audiositzung folgen und sie per Tastenkürzel oder Mausrad im Infobereich steuern |
| Beim Start einer App immer dieselben Einstellungen vornehmen | Beim App-Start eine Regel auslösen, die Geräte, Lautstärke und weitere Aktionen festlegt |
| Eine Audiokonfiguration per Skript oder anderem Werkzeug aufrufen | Eine Regel erstellen und mit `sr "Regelname oder ID"` in einer laufenden SonicRoute-Instanz aufrufen |

## 🚀 Herunterladen und loslegen

**Aktuelle Version: [v1.22](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.22)** · 2026-10-11 · [Versionshinweise (Chinesisch)](docs/release-v1.22.md)

Für die meisten Windows-x64-Systeme bietet die Version aus dem Microsoft Store eine bequeme Installation mit automatischen Updates. Wähle Lite x64 für eine einzelne ausführbare Datei oder Legacy x64, wenn .NET 8 nicht infrage kommt. Der Download oben führt immer zur neuesten Version; die direkten Links unten beziehen sich auf v1.22.

| Version | Herunterladen | Voraussetzungen |
|---|---|---|
| Lite x64 | [Einzelne EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-x64.exe) | .NET 8 Desktop Runtime für x64 |
| Lite ARM64 (experimentell) | [Einzelne EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Lite-arm64.exe) | .NET 8 Desktop Runtime für ARM64 |
| Legacy x64 | [Vollständiges ZIP](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.22/SonicRoute-v1.22-Legacy-x64.zip) | .NET Framework 4.8; ZIP vor dem Start vollständig entpacken |
| Microsoft Store | [Aus dem Store installieren](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64; automatische Updates; verfügbare Version im Store angezeigt |

Lite benötigt die passende [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0). Legacy benötigt .NET 8 nicht.

1. Starte SonicRoute, suche das Symbol im Windows-Infobereich (möglicherweise unter den ausgeblendeten Symbolen) und öffne die vollständige Oberfläche per Doppelklick.
2. Wähle unter „Einstellungen“ deine bevorzugten Ausgabe- und Eingabegeräte aus.
3. Klicke auf das Symbol im Infobereich, um ein Panel zu öffnen oder Tastenkürzel einzurichten. Wenn du mehrere Aktionen kombinieren möchtest, erstelle eine Automatisierungsregel.

Bevor du `sr` zum ersten Mal verwendest, starte SonicRoute normal, damit der Befehl registriert wird, und öffne anschließend dein Terminal erneut. Wenn der Gerätewechsel nicht wie erwartet funktioniert, findest du Hilfe in den [Häufige Fragen](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98).

Version 1.22 synchronisiert den Status des automatischen Windows-Starts zuverlässiger und trennt die Autostart-Einstellungen der Store- und portablen Version. Außerdem wird die Automatisierung nun bei Bedarf geladen, Menüs sind einheitlicher gestaltet, das Kopieren von Befehlen wurde verbessert und Formulierungen in neun Sprachen wurden überarbeitet. Frühere Änderungen findest du im [Versionsverlauf](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2).

## 📚 Dokumentation

Das Wiki ist derzeit auf vereinfachtem Chinesisch.

| Thema | Anleitungen |
|---|---|
| Installation, Panels und alltägliche Bedienung | [Benutzerhandbuch](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Funktionen](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| Standardtasten, Belegungen und Steuerungsziele | [Tastenkürzel](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| Auslöser, Aktionen und Skriptintegration | [Automatisierung](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [Befehlszeile](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| Installation und Fehlerbehebung | [Häufige Fragen](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| Quellcode, Builds und Versionen | [Technische Umsetzung](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [Informationen zur Version](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [Versionsverlauf](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 Roadmap

- **v1.23 · Leistung und Stabilität:** Ressourcenverbrauch im Hintergrund, Reaktionsfähigkeit und Kompatibilität verbessern.
- **Weitere Schritte:** Bestehende Funktionen anhand von Rückmeldungen weiterentwickeln. Die Pläne können sich mit dem Feedback ändern.

[Idee teilen oder Problem melden](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose).

## 🧩 Weitere Projekte und Kombinationen

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**: Ein Audioplayer für Windows. Kombiniere ihn mit der Programmstart-Aktion der Automatisierung, um Soundeffekte per Tastenkürzel abzuspielen. [Einrichtungsanleitung (Chinesisch)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**: Eine .NET-Bibliothek für Windows-Audiogeräte, Sitzungen, App-Audiozuweisung, Ereignisse und CLI-Zugriff.

---

<a href="EASTER_EGGS.md" title="Ein Easter Egg: gestern und morgen"><img src="docs/images/mascot-footer.png" width="56" align="right" alt="Entdecke ein Easter Egg"></a>

Danke, dass du SonicRoute verwendest. [Anleitungen lesen (Chinesisch)](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [Problem melden](https://github.com/kunkunkunQoQ/SonicRoute/issues).

**Autor: [Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
