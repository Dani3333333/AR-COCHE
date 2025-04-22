# ⚡️ Lightning Run AR

**Lightning Run AR** és un videojoc de *realitat augmentada* per a dispositius Android, desenvolupat amb **Unity** i **AR Foundation**. El jugador controla a **Rayo McQueen** mentre fuig d’una gran cosechadora, esquivant obstacles projectats sobre l'entorn real a través de la càmera del dispositiu. És com *Temple Run* o *Subway Surfers*, però amb RA

L’objectiu és simple però addictiu: recórrer la màxima distància possible esquivant tractors i altres obstacles, mentre et persegueix una cosechadora gegant. Si xoques... game over!

Funcionament del joc:
- Es fa una detecció de l'entorn gràcies al AR Raycast Manager, i un cop tenim una superfície plana apareix la carretera, el cotxe i la cosetxadora a darrere.
- El cotxe comença a córrer, tenim un joystick a la banda dreta de la pantalla, que serveix perque el cotxe giri a la dreta o a l'esquerra respectivament.
- Al llarg de la carretera apareixen obstacles aleatòriament, en tres espais diferents a la carretera, la carretera està dividida en 3 seccions, (esquerre, centre i dreta).
- Darrere el cotxe tenim una cosetxadora que el persegueix, aquesta porta una velocitat menor al cotxe, i només és un personatge per psoar pressió, tal i com ho fa el olicia al Subway Surfers.
- Finalment, si el cotxe toca un obstacle, o, surt de la carretera, apareix un panell de "GAME OVER", i un botó per reinciciar la partida.


Com funciona cada element?

**Cotxe:**
El cotxe té un CarController controla la velocitat amb la que correr endavant i amb la que gira.
També conté un CarCollisionHandler que actua quan el cotxe toca algun objecte amb el Tag "Obstacle" o "OutofBounds", i fa apareixer el panell de "GAME OVER".
També hi ha un contador de distància per donar més joc a la cursa, i poder crear competiions entre els amics.

**Cosetxadora:**
Conté un codi sencill anomenat "Harvester" que té la funcinalitat de correr endavant amb una velocitat asignada (menor a la del cotxe) i a la vegada tenir un objectiu per perseguir que és el Rayo McQueen.

**La carretera:**
No té cap codi intern ja que fa d'escenari solament. Si que conté dos box colliders als costats que porten el Tag de "OutofBounds" i si el cotxe surt de la carretera, s'activa el "GAME OVER"

**Obstacles:**
Tenim un Empty Object que l'he anomenat ObjectSpawner, i és l'encarregat de fer spawnejar el prefab de l'objecte amb el Tag "Obstacle". El codi que conté aquest EmptyObject, també delimita la distància en que es comencen a spawnejar objectes, i la velocitat.

**GameManager:**
Té un codi que activa el game over, quan el cotxe toca els objectes mencionats anteriorment

## 👥 Equip de desenvolupament

| Nom              | Aportació principal |
|------------------|---------------------|
| **Daniel Gubianas** | Tota la programació del moviment del vehicle, detecció de col·lisions, escalat, RA... i README |
| **Armand Puertos** | Direcció artística, narrativa i ambientació |
| **Pablo Torres** | Disseny de mecàniques, i presentació |
| **Oscar Garcia** | Disseny de mecàniques, memòria i presentació |



Per acabar, com t'he dit a classe, i després de molts intents amb diferents ordinadors, no hem pogut fer la build del joc, espero que amb el Unity et puguis fer una idea del que hem volgut trasmetre. Gràcies
