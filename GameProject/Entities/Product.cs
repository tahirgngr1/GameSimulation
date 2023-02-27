using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }

    }
}
