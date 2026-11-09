using Lis.Domain.Common;

namespace Lis.Domain.Entities;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
    public int TestDefinitionId { get; set; }
    public TestDefinition TestDefinition { get; set; } = null!;
}