# Architecture

## Tjenester

- Innlån

## Innlån arkitektur

Innlån består av et kjernekomponent som drives regelmessig på satte intervaller.
Innlån består også av et online-komponent i form av en API.
Både online-komponentet og kjernekomponentet er koblet til samme SQL-database,
og når de begge forsøker å hente samme data, skal online-komponentet ha prioritet.

Online-komponentet er ansvarlig for alle transaksjoner. Det vil si alle innbetalinger,
alle transaksjoner som medfører endringer på kontoens egenskaper og alle transaksjoner som 
medfører korrigeringer, også framover og bakover i tid, på kontoen.

Framvaluterte transaksjoner er henholdsvis lett å håndtere, da de kun trenger å lagres mot kontoen med en valuteringsdato satt fram i tid.
Tilbakevaluterte transaksjoner er vanskeligere, og "staffel"-konseptet som benyttes i dag må kanskje benyttes i en evt. ny løsning også.

Kjernekomponentet er ansvarlig for alt som ikke er responsivt, men som heller forekommer regelmessig i jevne intervaller(f.eks daglig, ukentlig, etc.).
Det vil si at alle gebyrer med unntak av transaksjonsgebyrer vil forekomme i kjernekomponentet. Avhengig av metode for renteberegning, så vil mest sannsynlig den også
forekomme i kjernekomponentet. Regelmessige kapitaliseringer av gebyrer/renter/provisjoner forekommer også regelmessig i jevne intervaller, og vil derfor også tilhøre kjernekomponentet.

Utfordingen med kjernekomponentet, er at det kan være avhengigheter mot andre systemer, og man må derfor være sikker på at Task A kun skjer etter Task B er ferdig. Dette kan mest sannsynlig oppnås ved å bruke verktøy som f.eks Azure Scheduler eller Tivoli, men den beste løsningen hadde såklart vært å fjerne disse avhengighetene slik at alle systemene er fullstendig uavhengige. 