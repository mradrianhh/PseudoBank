using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseudoBank.Common.DataModels
{
    [PrimaryKey(nameof(ProduktKode))]
    public sealed class Produkt
    {
        [Required]
        [Column(TypeName = "NVARCHAR(8)")]
        public string ProduktKode { get; set; } = string.Empty;

        public List<ProduktTjeneste>? ProduktTjenester { get; set; }

    }
}
