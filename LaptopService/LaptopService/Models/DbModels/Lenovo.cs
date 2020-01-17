using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LaptopService.Models.DbModels
{
    public class Lenovo
    {
        [Key]
        public int id { get; set; }

        public string model { get; set; }
        public string price { get; set; }
    }
}
