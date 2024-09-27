namespace G_08_AutoCentr.DTO;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Car
{
    public int Id { get; set; }

    [StringLength(30)]
    [Required]
    public string Brand { get; set; } = null!;

    [StringLength(30)]
    [Required]
    public string Model { get; set; } = null!;

    [Required]
    public int Color { get; set; }

    [StringLength(20)]
    [Required]
    public string PlateNumber { get; set; } = null!;

    [Column(TypeName = "smallmoney")]
    public decimal RentFee { get; set; }

    public virtual Category Category { get; set; } = null!;
}