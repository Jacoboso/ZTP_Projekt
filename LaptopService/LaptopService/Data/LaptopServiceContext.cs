using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LaptopService.Models.DbModels;

namespace LaptopService.Models
{
    public class LaptopServiceContext : DbContext
    {
        public LaptopServiceContext (DbContextOptions<LaptopServiceContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<LaptopService.Models.DbModels.Person> Person { get; set; }
        public DbSet<LaptopService.Models.DbModels.Company> Company { get; set; }

        public DbSet<LaptopService.Models.DbModels.Hp> Hp { get; set; }
        public DbSet<LaptopService.Models.DbModels.Lenovo> Lenovo { get; set; }
        public DbSet<LaptopService.Models.DbModels.MSI> MSI { get; set; }
        public DbSet<LaptopService.Models.DbModels.Transaction> Transaction { get; set; }

    }
}
