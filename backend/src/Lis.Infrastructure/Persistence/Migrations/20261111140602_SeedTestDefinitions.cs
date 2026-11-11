using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lis.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestDefinitions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TestDefinitions",
                columns: new[] { "Id", "Code", "CreatedAtUtc", "IsActive", "Name", "ReferenceHigh", "ReferenceLow", "SampleType", "Unit", "UpdatedAtUtc" },
                values: new object[,]
                {
                    { 1, "HGB", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Hemoglobin", 17.5m, 12.0m, "Blood", "g/dL", null },
                    { 2, "WBC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "White Blood Cell Count", 11.0m, 4.0m, "Blood", "10^3/uL", null },
                    { 3, "PLT", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Platelet Count", 450.0m, 150.0m, "Blood", "10^3/uL", null },
                    { 4, "RBC", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Red Blood Cell Count", 5.9m, 4.2m, "Blood", "10^6/uL", null },
                    { 5, "FBS", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Fasting Blood Glucose", 99.0m, 70.0m, "Blood", "mg/dL", null },
                    { 6, "CHOL", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Total Cholesterol", 200.0m, 0.0m, "Blood", "mg/dL", null },
                    { 7, "CREA", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Serum Creatinine", 1.3m, 0.6m, "Blood", "mg/dL", null },
                    { 8, "TSH", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), true, "Thyroid Stimulating Hormone", 4.0m, 0.4m, "Blood", "uIU/mL", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TestDefinitions",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
