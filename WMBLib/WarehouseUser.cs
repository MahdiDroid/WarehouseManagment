﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WMBLib
{
   public  class WarehouseUser
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
