using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is added to the Campaigns");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is edited on the Campaigns");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " is deleted from the Campaigns");
        }

        public void Show(List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("***Campaign properties***");
                Console.WriteLine("Name: " + campaign.Name);
                Console.WriteLine("Price: " + campaign.DiscountPercentage);
              
            }
        }
    }
}
