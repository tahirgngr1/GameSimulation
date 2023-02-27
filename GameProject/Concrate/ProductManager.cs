using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrate
{
    public class ProductManager : IProductService
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün Eklendi");
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Ürün Silindi");
        }

        public void Update(Product product)
        {
            Console.WriteLine("Ürün Güncellendi");
        }
    }
}
