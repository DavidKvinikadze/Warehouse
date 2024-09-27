using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace G_08_AutoCentr.DTO;

public class Category
{
    private readonly ILazyLoader _lazyLoader;
    private ICollection<Car> _cars;

    public Category()
    {

    }

    public Category(ILazyLoader lazyLoader) : this()
    {
        _lazyLoader = lazyLoader;
    }

    public int Id { get; set; }

    [StringLength(50)]
    [Required]
    public string Name { get; set; } = null!;

    //public ICollection<Car> Cars { get; set; }

    public ICollection<Car> Cars
    {
        get => _lazyLoader.Load(this, ref _cars);
        set => _cars = value;
    }
}