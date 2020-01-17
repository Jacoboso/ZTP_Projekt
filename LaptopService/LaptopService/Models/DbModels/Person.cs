using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LaptopService.Models.DbModels
{
    public class Person
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
