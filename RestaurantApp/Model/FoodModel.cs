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
       
        public static async Task<List<FoodModel>> GetFoodAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<FoodModel> food = new List<FoodModel>();
            if (response.IsSuccessStatusCode)
            {
                food = await response.Content.ReadAsAsync <List<FoodModel>>();
            }
            return food;
        }

        public async Task<FoodModel> Save(HttpClient client, string path)
        {
            FoodModel foodResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path, this);
            if (response.IsSuccessStatusCode)
                foodResult = await response.Content.ReadAsAsync<FoodModel>();
            return foodResult;
        }

        public async Task<FoodModel> Update(HttpClient client, string path)
        {
            FoodModel foodResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync(path, this);
            if (response.IsSuccessStatusCode)
                foodResult = await response.Content.ReadAsAsync<FoodModel>();

            if (foodResult != null)
            {
                // Xu ly cac order detail thuoc order (chua duoc thanh toan) co chua food nay -> phai cap nhat lai gia tien
                List<OrderModel> orders = await OrderModel.GetOrdersAsync(client, "api/orders");
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
                        List<OrderDetailModel> orderDetails = await OrderDetailModel.GetOrderDetailAsync(client, "api/orders/" + o.ID + "/orderdetails");
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
    }
}
