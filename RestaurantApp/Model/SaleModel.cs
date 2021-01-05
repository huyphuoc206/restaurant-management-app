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

        public async Task<SaleModel> Save(HttpClient client, string path)
        {
            SaleModel saleResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path, this);
            if (response.IsSuccessStatusCode)
                saleResult = await response.Content.ReadAsAsync<SaleModel>();
            return saleResult;
        }

        public async Task<SaleModel> Update(HttpClient client, string path)
        {
            SaleModel saleResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync(path, this);
            if (response.IsSuccessStatusCode)
                saleResult = await response.Content.ReadAsAsync<SaleModel>();
            return saleResult;
        }
    }
}