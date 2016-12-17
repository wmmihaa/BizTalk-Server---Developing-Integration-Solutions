

1. Generera ett schema utifrån Mat.xml

För att aktivera Generate Schema from Well-know XML, kör C:\Program Files (x86)\Microsoft BizTalk Server 2013\SDK\Utilities\Schema Generator\InstallWFX.vbs

2. Importera schema Restaurang.xsd

3. Skapa en mappning mellan Mat och Restaurang

4. Signera projektet

5. Deploya projektet

6. Skapa en OneWay receive port för att kunna ta in Mat.xml
OBS! Uppdatera Mat med namnet på den restaurang du vill besöka på Fredag
OBS 2! Glöm inte att konfigurera mappningen

7. Skapa en OneWay send port som skall sända meddelanden till addressen 
https://a372wabs.servicebus.windows.net/Lunch
OBS! Glöm inte filter

8. Aktivera och starta portarna

9. Skicka meddelandet

