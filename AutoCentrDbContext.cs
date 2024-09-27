using Microsoft.EntityFrameworkCore;
using G_08_AutoCentr.DTO;

namespace G_08_AutoCentr;

internal class AutoCentrDbContext : DbContext
{
    public AutoCentrDbContext() : base(GetOptions())
    {

    }

    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!; 
    //public DbSet<Administration> Administrations { get; set; } = null!;
    //public DbSet<Driver> Drivers { get; set; } = null!;
    //public DbSet<Technician> Technicians { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        //optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Administration>().ToTable("Employees");
        modelBuilder.Entity<Driver>().ToTable("Employees");
        modelBuilder.Entity<Technician>().ToTable("Employees");
    }

    private static DbContextOptions GetOptions()
    {
        var options = new DbContextOptionsBuilder();
        options.UseSqlServer(@"server = .\sqlserver; database=G08_AutoCenter_ef_v3; integrated security=true;TrustServerCertificate =true; MultipleActiveResultSets=true");
        return options.Options;
    }
}