using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class SaleModel : AbstractModel
    {
        private string name;
        private int discount;
        private string status;

        public string Name { get => name; set => name = value; }
        public int Discount { get => discount; set => discount = value; }
        public string Status { get => status; set => status = value; }

        public static async Task<List<SaleModel>> GetSalesAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<SaleModel> sales = new List<SaleModel>();
            if (response.IsSuccessStatusCode)
                sales = await response.Content.ReadAsAsync<List<SaleModel>>();
            return sales;
        }
    }
}