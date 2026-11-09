using Lis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lis.Infrastructure.Persistence.Configurations;

public class TestDefinitionConfiguration : IEntityTypeConfiguration<TestDefinition>
{
    public void Configure(EntityTypeBuilder<TestDefinition> builder)
    {
        builder.ToTable("TestDefinitions");

        builder.Property(t => t.Code).IsRequired().HasMaxLength(20);
        builder.HasIndex(t => t.Code).IsUnique();

        builder.Property(t => t.Name).IsRequired().HasMaxLength(200);
        builder.Property(t => t.SampleType).IsRequired().HasMaxLength(50);
        builder.Property(t => t.Unit).HasMaxLength(30);
        builder.Property(t => t.ReferenceLow).HasPrecision(10, 3);
        builder.Property(t => t.ReferenceHigh).HasPrecision(10, 3);
    }
}