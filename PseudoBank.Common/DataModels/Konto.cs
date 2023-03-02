using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseudoBank.Common.DataModels
{
    [PrimaryKey(nameof(Kontonr))]
    public sealed class Konto
    {
        [Required]
        [Column(TypeName = "INT")]
        public int Kontonr { get; set; }

        [Required]
        public Produkt? Produkt { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(13,2)")]
        public decimal Bokfsaldo { get; set; } 

        [Required]
        [Column(TypeName = "DECIMAL(13,2)")]
        public decimal Motverdi { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime Åpningsdato { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime Forfallsdato { get; set; }
    }
}
