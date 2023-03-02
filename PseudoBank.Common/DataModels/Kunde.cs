using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PseudoBank.Common.DataModels
{
    [PrimaryKey(nameof(Kundenr))]
    public sealed class Kunde
    {
        [Required]
        [Column(TypeName = "INT")]
        public int Kundenr { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(150)")]
        public string Navn { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "NVARCHAR(100)")]
        public string Addresse { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "INT")]
        public int Postnummer { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string By { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "NVARCHAR(50)")]
        public string Land { get; set; } = string.Empty;

        public List<Konto>? Kontoer { get; set; }

    }
}
