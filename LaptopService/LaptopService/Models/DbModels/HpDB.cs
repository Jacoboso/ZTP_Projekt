using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LaptopService.Models.DbModels
{
    public class HpDB
    {
        [Key]
        public int Id { get; set; }

        public string Model { get; set; }
        public string Price { get; set; }
    }
}
