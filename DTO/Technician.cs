using System.ComponentModel.DataAnnotations;

namespace G_08_AutoCentr.DTO;

public class Technician : Employee
{
    [StringLength(100)]
    [Required]
    public string Qualification { get; set; } = null!;

    [MaxLength(60)]
    public byte ExperienceInYears { get; set; }

    public virtual Category? Category { get; set; }
}