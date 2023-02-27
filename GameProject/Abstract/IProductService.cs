using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IProductService
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(Product product);
    }
}
