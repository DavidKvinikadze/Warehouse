using G_08_AutoCentr;
using G_08_AutoCentr.DTO;
using Microsoft.EntityFrameworkCore;

AutoCentrDbContext context = new();
//gavagrdzelot trackingis temit da cvlilebebis shetanit bazashi.
//var car = context.Cars.Where(c => c.Id == 11).ToList();
//Console.WriteLine(car.Model);

//var result = context.Categories.Include(c => c.Cars);
var result = context.Categories;

foreach (var category in result)
{
    Console.WriteLine($"{category.Id} - {category.Name}");
    foreach (var car in category.Cars)
    {
        Console.WriteLine($"\t{car.Id} - {car.Brand} - {car.Model}");
    }
}

//for (int i = 0; i < 10; i++)
//{
//    var categoryName = $"Category {i}";
//    Category category = new() { Name = categoryName, Cars = new List<Car>() };
//    for (int j = 0; j < 10; j++)
//    {
//        category.Cars.Add(new()
//        {
//            Brand = $"Brand {j} for {categoryName}",
//            Model = $"Model {j} for {categoryName}",
//            Color = 123,
//            PlateNumber = "123",
//            RentFee = 99
//        });
//    }
//    context.Categories.Add(category);
//}

//context.SaveChanges();