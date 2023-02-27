using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrate
{
    public class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaing campaing)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void NewCampaign(Campaing campaing)
        {
            Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void UpdateCampaign(Campaing campaing)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
