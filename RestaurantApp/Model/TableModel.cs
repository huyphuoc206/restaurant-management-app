using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class TableModel : AbstractModel
    {
        private string name;
        private int seats;
        private string status;

        public string Name { get => name; set => name = value; }
        public int Seats { get => seats; set => seats = value; }
        public string Status { get => status; set => status = value; }

        public async Task<List<TableModel>> GetTables(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/tables");
            List<TableModel> tables = new List<TableModel>();
            if (response.IsSuccessStatusCode)
                tables = await response.Content.ReadAsAsync<List<TableModel>>();
            return tables;
        }

        public async Task<TableModel> GetTable(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/tables/" + this.ID);
            TableModel table = null;
            if (response.IsSuccessStatusCode)
                table = await response.Content.ReadAsAsync<TableModel>();
            return table;
        }

        public async Task<TableModel> Save(HttpClient client)
        {
            TableModel tableResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/tables", this);
            if (response.IsSuccessStatusCode)
                tableResult = await response.Content.ReadAsAsync<TableModel>();
            return tableResult;
        }

        public async Task<TableModel> Update(HttpClient client)
        {
            TableModel tableResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/tables/" + this.ID, this);
            if (response.IsSuccessStatusCode)
                tableResult = await response.Content.ReadAsAsync<TableModel>();
            return tableResult;
        }

        public async Task<bool> Delete(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/tables/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }

        public async Task<List<OrderModel>> GetOrders(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/table/" + this.ID + "/orders");
            List<OrderModel> orders = new List<OrderModel>();
            if (response.IsSuccessStatusCode)
            {
                orders = await response.Content.ReadAsAsync<List<OrderModel>>();
            }
            return orders;
        }

        public async Task<OrderModel> GetOrderUnChecked(HttpClient client)
        {
            List<OrderModel> orders = await GetOrders(client);
            OrderModel currentOrder = null;
            foreach (OrderModel o in orders)
                if (o.Status.Equals("0"))
                {
                    currentOrder = o;
                    break;
                }
            return currentOrder;
        }

        public async Task<bool> CancelTable(HttpClient client)
        {
            OrderModel orders = await GetOrderUnChecked(client);
            if (orders == null) return false;
            await orders.RemoveAllOrderDetails(client);
            TableModel table = await GetTable(client);
            table.status = "0";
            await table.Update(client);
            return true;
        }

        public async Task<OrderModel> CreateOrder(HttpClient client, OrderModel order)
        {
            order.Table = this;
            OrderModel orderResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/orders", order);
            if (response.IsSuccessStatusCode)
                orderResult = await response.Content.ReadAsAsync<OrderModel>();
            return orderResult;
        }
    }
}
