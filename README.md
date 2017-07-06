# edhouse
Captchta úkol "Smajlíci"
-----------------------------

Zadanim byla captcha ze zadane sady "smajliku" poslanych ve word dokumentu. Tuto sestavu 9ks pomichanych ctvercu poskladat pomoci C# kodu v rozumnem case. Pravdepodobne - do podoby usmivajicich se obliceju stejne barvy. Me reseni je patrno z png, jpg a pdf souboru vyse.


Vice uvadim v komentarich meho kodu. Jedna se o pracovni verzi, ktera nema vubec vypracovane GUI. Snazil jsem o max strucnost.

Princip castecneho reseni:
-------------------------

1.) Pouzil jsem Heap algoritmus pro vypocet P(9) = 9! = 362 880 permutaci pri 1 danem otoceni ctvercu

2.) Kazdy ctvereck muze rotovat 0 nebo 90 nebo 180 nebo 270 stupnu = 4^9 moznosti = 262 144 moznosti * 9! = 9,5 E10 ruznych desek !!

3.) Proto jsem se omezil v kodu na vyber 4 nebo 6 nebo 8 smajliku = cas do 6min, dalsi moznosti 10 nebo 12 smajliku = cca 3.2 dny jsou zakomentovane (mozno odzkouset na jinem PC).

4.) Jedna se pouze o Debug - ve Visual Studiu zapnout Debug Listener, hlasi do konzoly pocty Permutaci a Cas vypoctu

5.) Pripraveno diskuzi nad projektem.


Cas straveny na projektu - 16hod

6.7.2017

DJ





