using Microsoft.EntityFrameworkCore;
using PseudoBank.Common.DataModels;

namespace PseudoBank.EFCore;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<Kunde> Kunde { get; set; } = null!;
}
