using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    public class Campaing : IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public DateTime DeadLine { get; set; }
        public int DiscountRate { get; set; }
    }
}
