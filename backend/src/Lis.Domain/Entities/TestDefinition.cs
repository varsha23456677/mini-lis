using Lis.Domain.Common;

namespace Lis.Domain.Entities;

public class TestDefinition : BaseEntity
{
    public string Code { get; set; } = string.Empty;        // e.g. "HGB"
    public string Name { get; set; } = string.Empty;        // e.g. "Hemoglobin"
    public string SampleType { get; set; } = string.Empty;  // e.g. "Blood"
    public string? Unit { get; set; }                       // e.g. "g/dL"
    public decimal? ReferenceLow { get; set; }
    public decimal? ReferenceHigh { get; set; }
    public bool IsActive { get; set; } = true;
}