using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    internal interface ISaleService
    {
        void Sale(Product product, Gamer gamer, Campaing campaing);
    }
}
