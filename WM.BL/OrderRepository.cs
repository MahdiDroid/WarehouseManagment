﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WM.BL
{
    public class OrderRepository : IRepository<Order>
    {
        public void Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public Order RetrieveById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
