using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    class CampaingManager : ICampaingService
    {
        public void CampaingAdd(Campaings campaing)
        {
            Console.WriteLine(campaing.CampaingName + " isimli yeni kampanya olusturuldu");
        }

        public void CampaingDelete(Campaings campaing)
        {
            Console.WriteLine(campaing.CampaingName + " isimli kampanya silindi");
        }

        public void CampaingUpdate(Campaings campaing)
        {
            Console.WriteLine(campaing.CampaingName + " isimli kampanya güncellendi");
        }
    }
}
