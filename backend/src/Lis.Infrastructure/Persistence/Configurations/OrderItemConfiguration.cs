using Lis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lis.Infrastructure.Persistence.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItems");

        builder.HasOne(i => i.Order)
               .WithMany(o => o.Items)
               .HasForeignKey(i => i.OrderId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(i => i.TestDefinition)
               .WithMany()
               .HasForeignKey(i => i.TestDefinitionId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(i => new { i.OrderId, i.TestDefinitionId }).IsUnique();
    }
}