using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    class OrderDetailModel : AbstractModel
    {
        private OrderModel order;
        private FoodModel food;
        private long unitPrice;
        private int quantity;
       
        public long UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        internal OrderModel Order { get => order; set => order = value; }
        internal FoodModel Food { get => food; set => food = value; }
    }
}
