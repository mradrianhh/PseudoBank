using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseudoBank.Common.DataModels
{
    [PrimaryKey(nameof(ProduktTjenesteKode))]
    public sealed class ProduktTjeneste
    {
        [Required]
        [Column(TypeName = "NVARCHAR(3)")]
        public string ProduktTjenesteKode { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime Fradato { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime Tildato { get; set; }

        [Column(TypeName = "DECIMAL(13,2)")]
        public decimal Beløp { get; set; }

    }
}
