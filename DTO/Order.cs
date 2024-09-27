using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_08_AutoCentr.DTO;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderStart { get; set; }
    public DateTime OrderEnd { get; set; }
    public DateTime? OrderComplete { get; set; }

    [Column("OrderPrice",TypeName ="smallmoney")]
    public decimal OrderPrice { get; set; }

    public virtual Client Client { get; set; } = null!;
    public virtual Car Car { get; set; } = null!;
    public virtual Driver? Driver { get; set; }
}