Dies ist das Beispielprojekt zu meinem Vortrag auf der betterCode() .NET 7.

Zum ausf�hren des Quellcodes wird [Visual Studio 2022 17.4](https://visualstudio.microsoft.com/de/vs/) 
inklusive des Workloads Mobile Entwicklung mit .NET ben�tigt.

Die Anwendung demonstriert folgendes:

- Navigation mit der .NET MAUI-Shell
- Darstellung von Icons �ber Icon-Fonts
- Darstellung von Listen mit dem CollectionView
- Darstellung von Schatten und abgerundeten Ecken �ber die Elemente Shadow und Border
- Aufruf von plattformspzeifischem Code �ber Pr�prozessoranweisungen, partielle Klassen und Dependency Injection
- MVVM mit dem CommunityToolkit
- Einfacher Einsatz des .NET MAUI Community Toolkit (Converter, Extensions und Toasts)
- Einsatz von Styles
- Unterst�tzung des Darkmodes
- Positionieren des Anwendungsfensters (nur unter Windows)
- Anzeige von Anwedungsmen�s (nur unter Windows und macOS)
- Kontextmen�s (nur unter Windows und macOS)
- Tooltips (nur unter Windows und macOS)
- Pointer-Events (nur unter Windows und macOS)
- Prim�rer und sekund�rer Klick (rechtsklick) (nur unter Windows und macOS)
- Darstellung von Karten (nicht unter Windows, da dies unter .NET MAUI 7 dort nicht unterst�zt wird)

Unter Android muss f�r die Darstellung von Karten ein API-Key in der Datei `AndroidManifest.xml` hinterlegt werden.

Bei Fragen:

https://twitter.com/codemurai