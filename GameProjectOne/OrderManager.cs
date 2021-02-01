using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    class OrderManager : IOrderService
    {
        public void CancelOrder(Order order)
        {
            Console.WriteLine(order.OrderId + " numaralı sipariş iptal edildi");
        }

        public void ToOrder(User user, Campaings campaing, List<Games> games)
        {
            Console.WriteLine(user.UserName + " kullanıcısına");
            foreach (var game in games)
            {
                Console.WriteLine(" " + game.GameName + " ");
            }
            Console.WriteLine("Oyunları sipariş edildi");
        }
    }
}
