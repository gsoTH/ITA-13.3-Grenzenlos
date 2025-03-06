# Grenzenlos
Eine existierende Software zur Verwaltungen der Buchungen von Flugtickets soll robust werden, indem die vorhandenen Testfälle auf Vollständigkeit geprüft und ggf. erweitert werden.

## Fachliche Beschreibung
Wir, die AeroFlopp AG sind ein kleines Flugunternehmen mit Sitz am Flughafen Düsseldorf. 

Jede Buchung besteht aus Abflugzeit, Sitzplatz und einer Person.
- Durch das Nachtflugverbot darf die Abflugzeit einer Buchung nur zwischen 6 und 22 Uhr liegen.
- Alle unsere Flugzeuge haben eine gleiche Anzahl an Sitzplätzen, die sich Reihen mit den Nummern 1 bis 100 Reihen mit je 6 Plätzen (A bis F) verteilen. Jeder Sitzplatz hat eine zugehörige Nummer für die Reihe und einem Buchstaben für den Platz. Der Sitzplatz 86C liegt beispielsweise in der 86. Reihe, direkt am Gang. Die Sitzplätze 1A und 1F wären in der ersten Reihe jeweils am Fenster. Die Reihen 1-25 sind sogenannte VIP-Plätze. Die Notausgänge befinden sich in Reihe 50.
- Jede Person kann ein Kind und/oder VIP oder keins von beidem sein. VIPs dürfen nicht auf normalen Sitzplätzen buchen und umgekehrt. Kinder dürfen nicht in den Reihen des Notausgangs am Fenster sitzen.
