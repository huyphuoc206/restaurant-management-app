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

        public async Task<List<OrderModel>> GetOrdersByDate(HttpClient client, DateTime fromDate, DateTime toDate)
        {
            string from = fromDate.ToString("yyyy-MM-dd");
            string to = toDate.ToString("yyyy-MM-dd");
            HttpResponseMessage response = await client.GetAsync("api/orders?fromDate="+from+"&toDate="+to);
            List<OrderModel> orders = new List<OrderModel>();
            if (response.IsSuccessStatusCode)
            {
                orders = await response.Content.ReadAsAsync<List<OrderModel>>();
            }
            return orders;
        }


        public async Task<List<OrderModel>> GetOrders(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/orders");
            List<OrderModel> orders = new List<OrderModel>();
            if (response.IsSuccessStatusCode)
            {
                orders = await response.Content.ReadAsAsync<List<OrderModel>>();
            }
            return orders;
        }

        public async Task<List<OrderDetailModel>> GetOrderDetails(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/orders/" + this.iD + "/orderdetails");
            List<OrderDetailModel> orderDetails = new List<OrderDetailModel>();
            if (response.IsSuccessStatusCode)
            {
                orderDetails = await response.Content.ReadAsAsync<List<OrderDetailModel>>();
            }
            return orderDetails;
        }

        public async Task<OrderModel> Update(HttpClient client)
        {
            OrderModel orderResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/orders/" + this.ID, this);
            if (response.IsSuccessStatusCode)
                orderResult = await response.Content.ReadAsAsync<OrderModel>();
            return orderResult;
        }


        public void SetUnChecked()
        {
            this.status = "0";
            this.createdBy = LoginInfo.Username;
        }

        public async Task<OrderDetailModel> CreateOrderDetail(HttpClient client, OrderDetailModel orderDetail)
        {
            OrderDetailModel result = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/orders/" + this.ID + "/orderdetails", orderDetail);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<OrderDetailModel>();
            return result;
        }

        public async Task<bool> Delete(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/orders/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }

        public async Task RemoveAllOrderDetails(HttpClient client)
        {
            List<OrderDetailModel> orderDetails = await GetOrderDetails(client);
            foreach (OrderDetailModel o in orderDetails)
                await o.DeleteOrderDetails(client);
            await this.Delete(client);
        }

        public async Task<OrderModel> Pay(HttpClient client)
        {
            List<OrderDetailModel> orderDetails = await GetOrderDetails(client);
            if (orderDetails.Count == 0) return null;

            long totalPrice = 0;
            foreach (OrderDetailModel o in orderDetails)
                totalPrice += o.UnitPrice * o.Quantity;
            this.status = "1";
            totalPrice = totalPrice - totalPrice * this.sale.Discount / 100;
            this.totalPrice = totalPrice;

            OrderModel orderResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/orders/"+this.ID, this);
            if (response.IsSuccessStatusCode)
                orderResult = await response.Content.ReadAsAsync<OrderModel>();
            return orderResult;
        }
    }
}
