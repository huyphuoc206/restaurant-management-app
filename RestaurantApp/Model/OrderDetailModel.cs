﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    class OrderDetailModel : AbstractModel
    {
        private long orderId;
        private long foodId;
        private long unitPrice;
        private int quantity;

        public long OrderId { get => orderId; set => orderId = value; }
        public long FoodId { get => foodId; set => foodId = value; }
        public long UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
