using Lis.Domain.Common;
using Lis.Domain.Enums;

namespace Lis.Domain.Entities;

public class Patient : BaseEntity
{
    public string PatientCode { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Address { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}