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


    }
}
