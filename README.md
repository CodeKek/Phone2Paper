# Phone2Paper

Eine komfortable Software, um Fotopapier direkt vom Handy-Display zu belichten.

Die Software läuft auf einem Windows-PC/Notebook. 
Die Belichtung des Fotopapiers erfolgt durch ein Handy-Display, welches entweder mittels eines Objektivs eines Vergrößerungsgerätes projiziert wird oder direkt auf dem Fotopapier aufliegt. 
Ein weiteres Tablet/Handy kann als Interface benutzt werden.

![Overview](https://raw.githubusercontent.com/CodeKek/Phone2Paper/master/Overview.jpg)

Auf dem Tablet kann ein Bild aus einem PC-Ordner gewählt werden. Dieses wird gespiegelt, in Graustufen umgewandelt und auf dem Handydisplay für eine einstellbare Belichtungszeit gezeigt. Das Bild kann beliebig skaliert, positioniert und rotiert werden. Dabei kann zusätzlich der Gamma-Wert geändert werden, um mit Papier unterschiedlicher Härte arbeiten zu können.
Außerdem ist eine Kalibrationsfunktion eingebaut, mit der eine Belichtungsreihe mit verschiedenen Zeiten sowie unterschiedlichen Gamma-Werten gefahren werden kann.
Die Software erstellt eine Log-Datei, in die für jeden Abzug ein Eintrag mit Zeitstempel, Bildname, Belichtungszeit, Gamma-Wert und Zoom-Werten abgelegt werden. Für den Fall, dass man mit einem Bild nicht zufrieden ist, kann man so die Belichtungsparameter nachvollziehen und entsprechend korrigieren.

Die Qualität der Bilder steht und fällt natürlich mit der Auflösung des Handy-Displays. Die Schärfe von Abzügen von Negativ-Filmen wird insbesondere bei größeren Formaten nicht erreicht, aber je nach Anspruch und Verwendungszweck lassen sich recht komfortabel sehr ordentliche Abzüge von digitalen Bildern anfertigen. Gerade das Hineinzoomen in ein Bild passiert mit ein paar Klicks, ohne den Abstand und damit die Belichtungszeit ändern zu müssen.

## Installation 

Die Software läuft unter **Windows** und kann [hier](https://github.com/CodeKek/Phone2Paper/blob/master/Phone2Paper.exe) heruntergeladen werden. Alternativ steht der Quellcode für eigene Anpassungen zur Verfügung. 

Um Handy und Tablet anzuschließen, muss die Software Spacedesk sowohl auf dem PC als auch auf dem Handy (**Android** oder **iPhone**) installiert sein.
Download und Anleitung  [hier](https://www.spacedesk.net/de/).

## Vorbereitung

Die größte Herausforderung ist die Projektion des Handy-Dispays auf das Fotopapier. Bei meinem alten Mittelformat-Vergrößerungsgerät kann der obere Aufsatz mit Lampe abgenommen werden und das Handy einfach aufgelegt werden.

Wenn die Treiber und Apps von Spacedesk installiert sind, wird die Phone2Paper-Software gestartet. Es erscheint ein kleines Hauptfenster, das rot-schwarze Interface-Fenster und das Belichtungsfenster. Die beiden letzteren Fenster werden auf die jeweiligen Geräte verschoben und mit dem Klick im Hauptfenster maximiert.

Beim Handy sind folgende Einstellungen sinnvoll:
* Spacedesk Bildqualität auf Maximum
* Spacedesk Menu ausblenden
* Bildschirm Helligkeit auf Maximum
* Benachrichtigungen ausschalten

Beim Tablet sollte lediglich die Helligkeit auf ein Minimum reduziert werden. 

Falls der Windows-PC in der Dunkelkammer steht, sollten die Monitore ausgeschaltet werden. Da alle drei Geräte per WLAN kommunizieren, kann der PC natürlich auch außerhalb stehen. 

Jetzt kann in der Dunkelkammer das Licht ausgemacht werden und der Spaß beginnen. 

## Belichtung

Die Software ist (hoffentlich) selbsterklärend. Am oberen Bildrand befinden sich drei Buttons, die unterschiedliche Seiten zeigen:

### Image 
Hier kann ein Bild aus einem Ordner des PCs geladen werden. Mit den Buttons links und rechts kann im Verzeichnis weitergeblättert werden.

### Exposure
Hier werden Belichtungszeit, Gamma-Wert (Bild-Härte), Zoomfaktor und Bildposition eingestellt.
Die Belichtung kann entweder getestet (Display immer an) oder zeitlich gesteuert werden.

### Calibrate
Die Software kann Belichtungs- und Gamma-Reihen erzeugen. Das Belichtungsmuster kann ebenfalls in Größe und Position angepasst und vorher getestet werden.
![Belichtungsreihe](https://github.com/CodeKek/Phone2Paper/blob/master/B-Reihe.jpg)





