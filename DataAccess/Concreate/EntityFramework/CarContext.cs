﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate.EntityFramework
{
    public class CarContext : DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=ReCapProject; Trusted_Connection=true");
    }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Brand> Brands { get; set; }
    }
}