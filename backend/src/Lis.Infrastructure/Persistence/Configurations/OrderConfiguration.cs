using Lis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lis.Infrastructure.Persistence.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");

        builder.Property(o => o.OrderNumber).IsRequired().HasMaxLength(30);
        builder.HasIndex(o => o.OrderNumber).IsUnique();

        builder.Property(o => o.Status).HasConversion<string>().HasMaxLength(30);
        builder.Property(o => o.Priority).HasConversion<string>().HasMaxLength(20);
        builder.Property(o => o.Notes).HasMaxLength(1000);

        builder.HasOne(o => o.Patient)
               .WithMany(p => p.Orders)
               .HasForeignKey(o => o.PatientId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}