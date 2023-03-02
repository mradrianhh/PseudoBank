# PseudoBank Data Models

Format specifications for DB2 entities.

## Customer

- Kundenr.: INT PRIMARY KEY
- Navn: NVARCHAR(150).
- Addresse: NVARCHAR(100)
- Postnummer: INT
- By: NVARCHAR(50)
- Land: NVARCHAR(50)

## Account

- Kontonr: INT PRIMARY KEY.
- ProduktKode: NVARCHAR(8) FOREIGN KEY.
- Bokfsaldo: DECIMAL(13,2).
- Motverdi: DECIMAL(13,2).
- Åpningsdato: DATE.
- Forfallsdato: DATE.


## CustomerAccount

- Kundenr: INT
- Kontonr: INT
- COMPOUND KEY(Kundenr, Kontonr)

## Produkt

- ProduktKode: NVARCHAR(8) PRIMARY KEY.

## ProduktTjeneste

- ProduktTjenesteKode: NVARCHAR(3) PRIMARY KEY.
- Fradato: DATE.
- Tildato: DATE.
- Beløp: DECIMAL(13,2).

## ProduktProduktTjeneste

- ProduktKode. NVARCHAR(8).
- ProduktTjenesteKode. NVARCHAR(3).
- COMPOUND KEY(ProduktKode, ProduktTjenesteKode).