using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    public class SaleManager : ISaleService
    {
        public void Sale(Product product, Gamer gamer, Campaing campaing)
        {
            Console.WriteLine("Ürün satışı gerçekleşti");
        }
    }
}
