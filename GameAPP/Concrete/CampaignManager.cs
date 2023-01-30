using GameAPP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameAPP.Concrete
{
    public class CampaignManager
    {
        public void Add(Campaign campaign) 
        {
            Console.WriteLine(campaign.CampaignName + "Added");
        } 
    }
}
