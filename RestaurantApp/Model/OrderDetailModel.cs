using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class OrderDetailModel : AbstractModel
    {
        private OrderModel order;
        private FoodModel food;
        private long unitPrice;
        private int quantity;
       
        public long UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public OrderModel Order { get => order; set => order = value; }
        public FoodModel Food { get => food; set => food = value; }

        public async Task<bool> DeleteOrderDetails(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/orderdetail/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }
    }
}
