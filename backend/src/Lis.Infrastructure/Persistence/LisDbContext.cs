using Lis.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lis.Infrastructure.Persistence;

public class LisDbContext : DbContext
{
    public LisDbContext(DbContextOptions<LisDbContext> options) : base(options) { }

    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<TestDefinition> TestDefinitions => Set<TestDefinition>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LisDbContext).Assembly);
    }
}