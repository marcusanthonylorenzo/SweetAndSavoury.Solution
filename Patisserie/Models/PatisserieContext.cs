using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Patisserie.Models
{
  public class PatisserieContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Flavour> Flavours { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<FlavourTreat> FlavourTreat { get; set; }

    public PatisserieContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}