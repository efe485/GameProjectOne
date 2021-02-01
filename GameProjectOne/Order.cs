using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectOne
{
    class Order
    {
        public int OrderId { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int Price { get; set; }
        public List<Games> GamesId { get; set; }

    }
}
