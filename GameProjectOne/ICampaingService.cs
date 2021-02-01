using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    interface ICampaingService
    {
        void CampaingAdd(Campaings campaing);
        void CampaingDelete(Campaings campaing);
        void CampaingUpdate(Campaings campaing);

    }
}
