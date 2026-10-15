<!-- Generated from docs/readme/shared.json and docs/readme/locales/es-ES.json. Edit those sources, then run node docs/readme/generate.cjs. -->
# 🎧 SonicRoute

[简体中文](README.md) | [English](README.en.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md) | [Deutsch](README.de.md) | [Français](README.fr.md) | **Español** | [Русский](README.ru.md)

[![License: MIT](https://img.shields.io/github/license/kunkunkunQoQ/SonicRoute?color=green)](LICENSE) [![Release](https://img.shields.io/github/v/release/kunkunkunQoQ/SonicRoute?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Downloads](https://img.shields.io/github/downloads/kunkunkunQoQ/SonicRoute/total?color=blue)](https://github.com/kunkunkunQoQ/SonicRoute/releases) [![Apoyar en Afdian](https://img.shields.io/badge/Support-Afdian-946CE6?logo=afdian&logoColor=white)](https://www.ifdian.net/a/koukou021)

**Envía el audio de cada aplicación al dispositivo que elijas.**

Escucha música por los altavoces y juegos o llamadas con los auriculares. SonicRoute es una utilidad de audio para Windows que permanece en el área de notificación: elige los dispositivos de salida y entrada de cada aplicación, controla el audio con atajos, la rueda del área de notificación o un panel, y combina acciones habituales en reglas de automatización.

📥 [Descargar la última versión](https://github.com/kunkunkunQoQ/SonicRoute/releases/latest) · [Microsoft Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) · [Guía de usuario](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Wiki (en chino)](https://github.com/kunkunkunQoQ/SonicRoute/wiki)

Windows 10 2004+ / Windows 11 · x64 / ARM64 (experimental) · Nueve idiomas de interfaz · Licencia MIT

<div>
<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97" title="Guía de usuario (en chino)"><img src="docs/images/mascot-panel-peek.png" width="104" align="middle" alt="Haz clic en la mascota para abrir la guía de usuario"></a>
<br>
<a href="docs/images/quick-panel.png"><img src="docs/images/quick-panel.png" width="275" align="top" alt="Panel rápido de SonicRoute: dispositivo de salida y controles de volumen por aplicación"></a>
<a href="docs/images/theme-settings.png"><img src="docs/images/theme-settings.png" width="500" align="top" alt="Ajustes de SonicRoute para la apariencia, el color de énfasis y la opacidad del fondo"></a>
</div>

<sub>Ejemplos de la interfaz: panel rápido para el volumen y el enrutamiento de audio por aplicación; ajustes de tema y apariencia.</sub>

## ✨ Qué ofrece SonicRoute

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7" title="Funciones"><img src="docs/images/mascot-music-hoodie.png" width="68" align="right" alt="Haz clic en la mascota para descubrir las funciones de SonicRoute"></a>

### Funciones principales

- **Enrutamiento de audio por aplicación.** Asigna distintos dispositivos de reproducción y grabación a cada aplicación, cambia los de las aplicaciones en ejecución o modifica los dispositivos predeterminados de Windows. Windows conserva la configuración de enrutamiento de las aplicaciones al cerrar SonicRoute.
- **Controla la aplicación que estás usando.** Identifica la aplicación actual mediante la actividad en primer plano y las sesiones de audio. El modo «Reciente» sigue a la aplicación en primer plano que tenga una sesión de audio; «Última usada» recuerda la última aplicación que controlaste. También puedes elegir una aplicación concreta. Filtra y cambia el nombre de tus dispositivos preferidos y altérnalos con el mismo atajo.
- **Atajos y rueda en el área de notificación.** Asigna combinaciones de teclas, botones laterales del ratón y combinaciones con la rueda. Desplázate por el área de notificación de la barra de tareas para ajustar el volumen de la aplicación actual y asigna un atajo independiente para silenciar todos los micrófonos. El menú del área de notificación permite elegir directamente el dispositivo de salida predeterminado de Windows. Puedes fijar la aplicación actual para controlar su volumen, silenciarla o cambiar su enrutamiento, y pausar el ajuste con la rueda; la opción se conserva tras reiniciar.
- **Dos paneles con funciones distintas.** El panel rápido organiza las aplicaciones en filas y permite controlar arriba el dispositivo de salida seleccionado; el panel de aplicación se centra en la aplicación actual. Los avisos OSD, los indicadores de audio por aplicación y el estado de silencio del micrófono muestran lo que ocurre.

### Funciones secundarias

- **Un desencadenante, varias acciones.** 6 desencadenantes y 18 acciones cubren el cambio de dispositivo, el volumen, el silencio, el inicio de programas, PowerShell y OSD. Añade una pausa o la detención en caso de error a cada paso, llama a otra regla o ejecuta una regla en una instancia de SonicRoute ya abierta con `sr "Nombre o ID de la regla"`.
- **Personaliza SonicRoute.** Ajusta los temas claros y oscuros, los colores de énfasis, la opacidad y la posición de los paneles. Los nueve idiomas integrados permiten importar y exportar archivos JSON.

## 🎮 Para el día a día

<a href="https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99" title="Automatización"><img src="docs/images/mascot-automation-es.png" width="48" align="middle" alt="Haz clic en el pequeño robot para conocer las reglas de automatización"></a> Haz que un juego use los auriculares al iniciarse o guarda varias acciones en una sola regla. [Configurar automatización](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99).

| Tu situación | Lo que puedes hacer |
|---|---|
| Usar música, juegos y chat de voz a la vez | Elegir dispositivos de salida o entrada distintos y ajustar el volumen de cada aplicación |
| Cambiar entre altavoces y auriculares | Seleccionar tus dispositivos preferidos y alternar el de la aplicación actual con un atajo |
| Ajustar la aplicación que estás usando | En el modo «Reciente», seguir a la aplicación en primer plano que tenga una sesión de audio y controlarla con atajos o la rueda del área de notificación |
| Repetir la misma configuración cada vez que se inicia una aplicación | Activar una regla al iniciar una aplicación para configurar dispositivos, volumen y otras acciones |
| Llamar a una configuración de audio desde un script u otra herramienta | Crear una regla y ejecutarla con `sr "Nombre o ID de la regla"` en una instancia de SonicRoute que ya esté abierta |

## 🚀 Descarga y primeros pasos

**Versión actual: [v1.23](https://github.com/kunkunkunQoQ/SonicRoute/releases/tag/v1.23)** · 2026-10-15 · [Notas de la versión (en chino)](docs/release-v1.23.md)

Para la mayoría de equipos Windows x64, la versión de Microsoft Store ofrece una instalación cómoda y actualizaciones automáticas. Elige Lite x64 si quieres un único ejecutable o Legacy x64 si no te resulta práctico instalar .NET 8. El enlace de descarga superior siempre lleva a la última versión; los enlaces directos de abajo corresponden a v1.23.

| Edición | Descargar | Requisitos |
|---|---|---|
| Lite x64 | [Un solo EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-x64.exe) | .NET 8 Desktop Runtime para x64 |
| Lite ARM64 (experimental) | [Un solo EXE](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Lite-arm64.exe) | .NET 8 Desktop Runtime para ARM64 |
| Legacy x64 | [ZIP completo](https://github.com/kunkunkunQoQ/SonicRoute/releases/download/v1.23/SonicRoute-v1.23-Legacy-x64.zip) | .NET Framework 4.8; extrae el ZIP completo antes de ejecutar |
| Microsoft Store | [Instalar desde Store](https://apps.microsoft.com/detail/9NQZGRTPM1NT) | x64; actualizaciones automáticas; la versión disponible se muestra en Store |

Lite necesita el [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/8.0) correspondiente. Legacy no requiere .NET 8.

1. Inicia SonicRoute, busca su icono en el área de notificación de Windows (puede estar entre los iconos ocultos) y haz doble clic para abrir la interfaz completa.
2. En Configuración, selecciona tus dispositivos de salida y entrada preferidos.
3. Haz clic en el icono del área de notificación para abrir un panel o configurar atajos. Crea reglas de automatización cuando quieras combinar varias acciones.

Antes de usar `sr` por primera vez, inicia SonicRoute con normalidad para registrar el comando y vuelve a abrir el terminal. Si el cambio de dispositivo no funciona como esperabas, consulta las [Preguntas frecuentes](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98).

La versión 1.23 permite elegir la salida predeterminada desde el área de notificación, controlar el volumen, el silencio y el enrutamiento de la aplicación actual fijada, silenciar todos los micrófonos y pausar la rueda con una opción que se conserva tras reiniciar. El atajo predeterminado para el volumen predeterminado del sistema es Ctrl+Alt+Mayús+rueda, distinto del atajo predeterminado Ctrl+Alt+rueda para la aplicación actual. Se ha reorganizado la disposición de los ajustes y las páginas se cargan bajo demanda. Consulta el [Historial de versiones](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) para ver cambios anteriores.

## 📚 Documentación

La Wiki está actualmente en chino simplificado.

| Tema | Guías |
|---|---|
| Instalación, paneles y controles habituales | [Guía de usuario](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97) · [Funciones](https://github.com/kunkunkunQoQ/SonicRoute/wiki/02-%E5%8A%9F%E8%83%BD%E7%89%B9%E6%80%A7) |
| Teclas predeterminadas, asignaciones y objetivos de control | [Atajos de teclado](https://github.com/kunkunkunQoQ/SonicRoute/wiki/03-%E5%BF%AB%E6%8D%B7%E9%94%AE) |
| Desencadenantes, acciones e integración con scripts | [Automatización](https://github.com/kunkunkunQoQ/SonicRoute/wiki/04-%E8%87%AA%E5%8A%A8%E5%8C%96%E8%A7%84%E5%88%99) · [Línea de comandos](https://github.com/kunkunkunQoQ/SonicRoute/wiki/05-%E5%91%BD%E4%BB%A4%E8%A1%8C%E6%89%A7%E8%A1%8C%E8%A7%84%E5%88%99) |
| Instalación y solución de problemas | [Preguntas frecuentes](https://github.com/kunkunkunQoQ/SonicRoute/wiki/06-%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98) |
| Código fuente, compilaciones y versiones | [Implementación técnica](https://github.com/kunkunkunQoQ/SonicRoute/wiki/07-%E6%8A%80%E6%9C%AF%E5%AE%9E%E7%8E%B0) · [Información de la versión](https://github.com/kunkunkunQoQ/SonicRoute/wiki/08-%E7%89%88%E6%9C%AC%E7%9B%B8%E5%85%B3) · [Historial de versiones](https://github.com/kunkunkunQoQ/SonicRoute/wiki/09-%E7%89%88%E6%9C%AC%E5%8E%86%E5%8F%B2) |

## 📌 Hoja de ruta

- **v1.24 · Rendimiento y estabilidad:** mejorar el uso de recursos en segundo plano, la capacidad de respuesta y la compatibilidad.
- **Etapas posteriores:** seguir perfeccionando las funciones existentes según los comentarios. Los planes pueden cambiar a medida que recibamos sugerencias.

[Comparte una idea o informa de un problema](https://github.com/kunkunkunQoQ/SonicRoute/issues/new/choose).

## 🧩 Otros proyectos y combinaciones

- **[SilentPlayer](https://github.com/kunkunkunQoQ/SilentPlayer)**: Un reproductor de audio para Windows. Combínalo con la acción de iniciar programas de la automatización para reproducir efectos de sonido mediante atajos. [Guía de configuración (en chino)](https://github.com/kunkunkunQoQ/SonicRoute/wiki/01-%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97#52-%E7%BB%84%E5%90%88%E5%9C%BA%E6%99%AFsilentplayer-%E9%9F%B3%E6%95%88%E6%9D%BF%E7%B1%BB%E4%BC%BC-soundpad)
- **[WinAudioRoute](https://github.com/kunkunkunQoQ/WinAudioRoute)**: Una biblioteca .NET para dispositivos y sesiones de audio de Windows, enrutamiento por aplicación, eventos y acceso mediante CLI.

---

<a href="EASTER_EGGS.md" title="Un huevo de Pascua: ayer y mañana"><img src="docs/images/mascot-cozy-knit.png" width="56" align="right" alt="Descubre un huevo de Pascua"></a>

Gracias por usar SonicRoute. [Leer las guías (en chino)](https://github.com/kunkunkunQoQ/SonicRoute/wiki) · [Informar de un problema](https://github.com/kunkunkunQoQ/SonicRoute/issues).

**Autor: [Bilibili](https://b23.tv/TDqSAKM) | [Afdian](https://www.ifdian.net/a/koukou021) | [GitHub](https://github.com/kunkunkunQoQ)**
