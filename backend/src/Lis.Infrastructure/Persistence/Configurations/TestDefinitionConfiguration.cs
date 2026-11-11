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

        // Demo data only: generic adult reference ranges, not for clinical use
        builder.HasData(
            Seed(1, "HGB",  "Hemoglobin",                  "Blood", "g/dL",     12.0m,  17.5m),
            Seed(2, "WBC",  "White Blood Cell Count",      "Blood", "10^3/uL",   4.0m,  11.0m),
            Seed(3, "PLT",  "Platelet Count",              "Blood", "10^3/uL", 150.0m, 450.0m),
            Seed(4, "RBC",  "Red Blood Cell Count",        "Blood", "10^6/uL",   4.2m,   5.9m),
            Seed(5, "FBS",  "Fasting Blood Glucose",       "Blood", "mg/dL",    70.0m,  99.0m),
            Seed(6, "CHOL", "Total Cholesterol",           "Blood", "mg/dL",     0.0m, 200.0m),
            Seed(7, "CREA", "Serum Creatinine",            "Blood", "mg/dL",     0.6m,   1.3m),
            Seed(8, "TSH",  "Thyroid Stimulating Hormone", "Blood", "uIU/mL",    0.4m,   4.0m)
        );
    }

    // Fixed date: seed data must be identical every time EF builds the model
    private static readonly DateTime SeedDate = new(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    private static TestDefinition Seed(int id, string code, string name, string sampleType,
                                       string? unit, decimal? low, decimal? high) => new()
    {
        Id = id,
        Code = code,
        Name = name,
        SampleType = sampleType,
        Unit = unit,
        ReferenceLow = low,
        ReferenceHigh = high,
        IsActive = true,
        CreatedAtUtc = SeedDate
    };
}