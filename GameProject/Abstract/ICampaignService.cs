using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void NewCampaign(Campaing campaing);
        void UpdateCampaign(Campaing campaing);
        void DeleteCampaign(Campaing campaing);
    }
}
