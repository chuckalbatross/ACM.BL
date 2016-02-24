﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        #region Properties
        // int OrderId
        // List<OrderItem>
        // int CustomerId
        // int ShippingAddressId
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        #endregion




    }
}
