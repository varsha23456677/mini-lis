using Lis.Domain.Common;
using Lis.Domain.Enums;

namespace Lis.Domain.Entities;

public class Order : BaseEntity
{
    public string OrderNumber { get; set; } = string.Empty;
    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;
    public OrderStatus Status { get; set; } = OrderStatus.Ordered;
    public OrderPriority Priority { get; set; } = OrderPriority.Routine;
    public string? Notes { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}