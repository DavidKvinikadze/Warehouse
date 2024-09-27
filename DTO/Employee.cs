using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_08_AutoCentr.DTO;

public abstract class Employee
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
}