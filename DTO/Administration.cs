using System.ComponentModel.DataAnnotations;

namespace G_08_AutoCentr.DTO;

public class Administration : Employee
{
    [StringLength(100)]
    [Required]
    public string Education { get; set; } = null!;

    [StringLength(30)]
    [Required]
    public string Position { get; set; } = null!;
}