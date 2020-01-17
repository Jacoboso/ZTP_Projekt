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

        public DbSet<LaptopService.Models.DbModels.HpDB> HpDB { get; set; }
        public DbSet<LaptopService.Models.DbModels.LenovoDB> LenovoDB { get; set; }
        public DbSet<LaptopService.Models.DbModels.MSIDB> MSIDB { get; set; }
        public DbSet<LaptopService.Models.DbModels.TransactionDB> TransactionDB { get; set; }

    }
}
