using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DataBaseOfContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;DataBase = CarsTable;Trusted_Connection=true ");
        }

        public DbSet<ProductCar> Cars { get; set; }
        public DbSet< ColorCar> Colors { get; set; }
        public DbSet<BrandCar> Brands { get; set; }
        
    }
}
