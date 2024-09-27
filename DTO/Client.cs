using System.ComponentModel.DataAnnotations;

namespace G_08_AutoCentr.DTO;

public class Client
{
    public int Id { get; set; }

    [StringLength(20)]
    [Required]
    public string FirstName { get; set; } = null!;

    [StringLength(30)]
    [Required]
    public string LastName { get; set; } = null!;

    [StringLength(100)]
    public string? Address { get; set; }

    [MaxLength(15)]
    public string? PhoneNumber { get; set; }

    public virtual ICollection<Order>? Orders { get; set; }
}