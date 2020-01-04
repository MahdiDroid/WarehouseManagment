using System;
using System.Collections.Generic;
using System.Text;

namespace WM.BL
{
    public class Order
    {
        public DateTime DateTime { get; set; }
        public int DestinationUserId { get; set; }
        public int OriginUserId { get; set; }
        public int OriginWarehouseId { get; set; }
        public int DestinationWarehouseId { get; set; }

    }
}
