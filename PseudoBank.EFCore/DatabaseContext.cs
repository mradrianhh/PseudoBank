using Microsoft.EntityFrameworkCore;
using PseudoBank.Common.DataModels;

namespace PseudoBank.EFCore;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Kunde> Kunde { get; set; } = null!;

    public DbSet<Konto> Konto { get; set; } = null!;

    public DbSet<Produkt> Produkt { get; set; } = null!;

    public DbSet<ProduktTjeneste> ProduktTjeneste { get; set; } = null!;
}
