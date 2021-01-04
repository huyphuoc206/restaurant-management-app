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

        public static async Task<List<OrderDetailModel>> GetOrderDetailAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<OrderDetailModel> orderDetail = new List<OrderDetailModel>();
            if (response.IsSuccessStatusCode)
            {
                orderDetail = await response.Content.ReadAsAsync<List<OrderDetailModel>>();
            }
            return orderDetail;
        }
    }
}
