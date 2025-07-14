using Microsoft.EntityFrameworkCore;

namespace Supermarket.Infraestructure.Orm.Shared;
public class SupermarketDbContext : DbContext
{
    public SupermarketDbContext(DbContextOptions options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(SupermarketDbContext).Assembly;

        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
}
