using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    class FoodModel : AbstractModel
    {
        private string name;
        private long price;
        private int discount;
        private int status;
        private CategoryModel category;

        public string Name { get => name; set => name = value; }
        public long Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Status { get => status; set => status = value; }
        public CategoryModel Category { get => category; set => category = value; }
       
        public static async Task<FoodModel[]> GetFoodsAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            FoodModel[] foods = null;
            if (response.IsSuccessStatusCode)
            {
                foods = await response.Content.ReadAsAsync <FoodModel[]>();
            }
            return foods;
        }


    }
}
