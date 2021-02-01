using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    interface IOrderService
    {
        void ToOrder(User user, Campaings campaing, List<Games> games);
        void CancelOrder(Order order);
    }
}
