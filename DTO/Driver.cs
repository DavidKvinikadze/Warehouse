using System.ComponentModel.DataAnnotations;

namespace G_08_AutoCentr.DTO;

public class Driver : Employee
{
    [MaxLength(30)]
    [Required]
    public string LicenseNumber { get; set; } = null!;
}