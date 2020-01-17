using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LaptopService.Models.DbModels
{
    public class TransactionDB
    {
        [Key]
        public int Id { get; set; }

        public string Model { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
    }
}
