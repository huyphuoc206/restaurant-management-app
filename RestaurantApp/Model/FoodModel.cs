using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class FoodModel : AbstractModel
    {
        private string name;
        private long price;
        private int discount;
        private string status;
        private CategoryModel category;

        public string Name { get => name; set => name = value; }
        public long Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public string Status { get => status; set => status = value; }
        public CategoryModel Category { get => category; set => category = value; }
       
        public async Task<List<FoodModel>> GetFood(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/food");
            List<FoodModel> food = new List<FoodModel>();
            if (response.IsSuccessStatusCode)
            {
                food = await response.Content.ReadAsAsync <List<FoodModel>>();
            }
            return food;
        }

        public async Task<FoodModel> Save(HttpClient client)
        {
            FoodModel foodResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/food", this);
            if (response.IsSuccessStatusCode)
                foodResult = await response.Content.ReadAsAsync<FoodModel>();
            return foodResult;
        }

        public async Task<FoodModel> Update(HttpClient client)
        {
            FoodModel foodResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/food/" + this.ID, this);
            if (response.IsSuccessStatusCode)
                foodResult = await response.Content.ReadAsAsync<FoodModel>();

            if (foodResult != null)
            {
                // Xu ly cac order detail thuoc order (chua duoc thanh toan) co chua food nay -> phai cap nhat lai gia tien
                List<OrderModel> orders = await new OrderModel().GetOrders(client);
                List<OrderModel> ordersUnPaid = new List<OrderModel>();
                foreach (OrderModel o in orders)
                {
                    if (o.Status.Equals("0"))
                        ordersUnPaid.Add(o);
                }
                if (ordersUnPaid.Count != 0)
                {
                    foreach (OrderModel o in ordersUnPaid)
                    {
                        List<OrderDetailModel> orderDetails = await o.GetOrderDetails(client);
                        foreach (OrderDetailModel od in orderDetails)
                        {
                            if (od.Food.ID == foodResult.ID)
                            {
                                od.UnitPrice = foodResult.Price - foodResult.Price * foodResult.Discount / 100;
                                od.ModifiedBy = LoginInfo.Username;
                                await client.PutAsJsonAsync("api/orderdetail/" + od.ID, od);
                            }
                        }
                    }
                }
                return foodResult;
            }
            else
                return null;
        }

        public async Task<bool> Delete(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/food/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }
    }
}
