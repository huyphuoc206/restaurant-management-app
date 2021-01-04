using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class OrderModel : AbstractModel
    {
        private long totalPrice;
        private SaleModel sale;
        private TableModel table;
        private string status;

        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Status { get => status; set => status = value; }
        public SaleModel Sale { get => sale; set => sale = value; }
        public TableModel Table { get => table; set => table = value; }

        public static async Task<List<OrderModel>> GetOrdersAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<OrderModel> orders = new List<OrderModel>();
            if (response.IsSuccessStatusCode)
            {
                orders = await response.Content.ReadAsAsync<List<OrderModel>>();
            }
            return orders;
        }
    }
}
