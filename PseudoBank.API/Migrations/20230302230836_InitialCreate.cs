using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PseudoBank.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunde",
                columns: table => new
                {
                    Kundenr = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "NVARCHAR(150)", nullable: false),
                    Addresse = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    Postnummer = table.Column<int>(type: "INT", nullable: false),
                    By = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    Land = table.Column<string>(type: "NVARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunde", x => x.Kundenr);
                });

            migrationBuilder.CreateTable(
                name: "Produkt",
                columns: table => new
                {
                    ProduktKode = table.Column<string>(type: "NVARCHAR(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkt", x => x.ProduktKode);
                });

            migrationBuilder.CreateTable(
                name: "Konto",
                columns: table => new
                {
                    Kontonr = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktKode = table.Column<string>(type: "NVARCHAR(8)", nullable: false),
                    Bokfsaldo = table.Column<decimal>(type: "DECIMAL(13,2)", nullable: false),
                    Motverdi = table.Column<decimal>(type: "DECIMAL(13,2)", nullable: false),
                    Åpningsdato = table.Column<DateTime>(type: "DATE", nullable: false),
                    Forfallsdato = table.Column<DateTime>(type: "DATE", nullable: false),
                    Kundenr = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konto", x => x.Kontonr);
                    table.ForeignKey(
                        name: "FK_Konto_Kunde_Kundenr",
                        column: x => x.Kundenr,
                        principalTable: "Kunde",
                        principalColumn: "Kundenr");
                    table.ForeignKey(
                        name: "FK_Konto_Produkt_ProduktKode",
                        column: x => x.ProduktKode,
                        principalTable: "Produkt",
                        principalColumn: "ProduktKode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProduktTjeneste",
                columns: table => new
                {
                    ProduktTjenesteKode = table.Column<string>(type: "NVARCHAR(3)", nullable: false),
                    Fradato = table.Column<DateTime>(type: "DATE", nullable: false),
                    Tildato = table.Column<DateTime>(type: "DATE", nullable: false),
                    Beløp = table.Column<decimal>(type: "DECIMAL(13,2)", nullable: false),
                    ProduktKode = table.Column<string>(type: "NVARCHAR(8)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduktTjeneste", x => x.ProduktTjenesteKode);
                    table.ForeignKey(
                        name: "FK_ProduktTjeneste_Produkt_ProduktKode",
                        column: x => x.ProduktKode,
                        principalTable: "Produkt",
                        principalColumn: "ProduktKode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Konto_Kundenr",
                table: "Konto",
                column: "Kundenr");

            migrationBuilder.CreateIndex(
                name: "IX_Konto_ProduktKode",
                table: "Konto",
                column: "ProduktKode");

            migrationBuilder.CreateIndex(
                name: "IX_ProduktTjeneste_ProduktKode",
                table: "ProduktTjeneste",
                column: "ProduktKode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konto");

            migrationBuilder.DropTable(
                name: "ProduktTjeneste");

            migrationBuilder.DropTable(
                name: "Kunde");

            migrationBuilder.DropTable(
                name: "Produkt");
        }
    }
}
