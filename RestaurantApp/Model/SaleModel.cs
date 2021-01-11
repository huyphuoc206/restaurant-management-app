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

        public override string ToString()
        {
            return name + " (" + discount + "%)";
        }

        public async Task<List<SaleModel>> GetSales(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/sales");
            List<SaleModel> sales = new List<SaleModel>();
            if (response.IsSuccessStatusCode)
                sales = await response.Content.ReadAsAsync<List<SaleModel>>();
            return sales;
        }

        public async Task<SaleModel> Save(HttpClient client)
        {
            SaleModel saleResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/sales", this);
            if (response.IsSuccessStatusCode)
                saleResult = await response.Content.ReadAsAsync<SaleModel>();
            return saleResult;
        }

        public async Task<SaleModel> Update(HttpClient client)
        {
            SaleModel saleResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/sales/" + this.ID, this);
            if (response.IsSuccessStatusCode)
                saleResult = await response.Content.ReadAsAsync<SaleModel>();
            return saleResult;
        }

        public async Task<bool> Delete(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/sales/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }

        public async Task<List<SaleModel>> GetSalesByKeyWord(HttpClient client, string keyword)
        {
            HttpResponseMessage response = await client.GetAsync("api/sales/search?keyword="+keyword);
            List<SaleModel> sales = new List<SaleModel>();
            if (response.IsSuccessStatusCode)
                sales = await response.Content.ReadAsAsync<List<SaleModel>>();
            return sales;
        }
    }
}