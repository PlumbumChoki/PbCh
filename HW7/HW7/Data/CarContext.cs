using HW7.Models;
using Microsoft.EntityFrameworkCore;

namespace HW7.Data;

public class CarContext : DbContext
{
    public DbSet<Car> Car { get; set; } = null;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-IEHPR7S;Initial Catalog=CarsList;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}



