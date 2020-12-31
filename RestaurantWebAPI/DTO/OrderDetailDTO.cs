using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class OrderDetailDTO : AbstractDTO
    {
        private OrderDTO order;
        private FoodDTO food;
        private long unitPrice;
        private int quantity;

        public long UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public FoodDTO Food { get => food; set => food = value; }
        public OrderDTO Order { get => order; set => order = value; }
    }
}