using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LaptopService.Models.DbModels
{
    public class Transaction
    {
        [Key]
        public int id { get; set; }

        public string model { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public string owner { get; set; }
        public string name { get; set; }
    }
}
