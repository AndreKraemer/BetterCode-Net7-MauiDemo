Dies ist das Beispielprojekt zu meinem Vortrag auf der betterCode() .NET 7.

Zum ausführen des Quellcodes wird [Visual Studio 2022 17.4](https://visualstudio.microsoft.com/de/vs/) 
inklusive des Workloads Mobile Entwicklung mit .NET benötigt.

Die Anwendung demonstriert folgendes:

- Navigation mit der .NET MAUI-Shell
- Darstellung von Icons über Icon-Fonts
- Darstellung von Listen mit dem CollectionView
- Darstellung von Schatten und abgerundeten Ecken über die Elemente Shadow und Border
- Aufruf von plattformspzeifischem Code über Präprozessoranweisungen, partielle Klassen und Dependency Injection
- MVVM mit dem CommunityToolkit
- Einfacher Einsatz des .NET MAUI Community Toolkit (Converter, Extensions und Toasts)
- Einsatz von Styles
- Unterstützung des Darkmodes
- Positionieren des Anwendungsfensters (nur unter Windows)
- Anzeige von Anwedungsmenüs (nur unter Windows und macOS)
- Kontextmenüs (nur unter Windows und macOS)
- Tooltips (nur unter Windows und macOS)
- Pointer-Events (nur unter Windows und macOS)
- Primärer und sekundärer Klick (rechtsklick) (nur unter Windows und macOS)
- Darstellung von Karten (nicht unter Windows, da dies unter .NET MAUI 7 dort nicht unterstüzt wird)

Unter Android muss für die Darstellung von Karten ein API-Key in der Datei `AndroidManifest.xml` hinterlegt werden.

Bei Fragen:

https://twitter.com/codemurai