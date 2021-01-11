using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class CategoryModel : AbstractModel
    {
        private string name;
        private string status;

        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public override string ToString()
        {
            return name;
        }

        public async Task<List<CategoryModel>> GetCategories(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/categories");
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            if (response.IsSuccessStatusCode)
                categoryModels = await response.Content.ReadAsAsync<List<CategoryModel>>();
            return categoryModels;
        }

        public async Task<CategoryModel> Save(HttpClient client)
        {
            CategoryModel categoryResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/categories", this);
            if (response.IsSuccessStatusCode)
                categoryResult = await response.Content.ReadAsAsync<CategoryModel>();
            return categoryResult;
        }

        public async Task<CategoryModel> Update(HttpClient client)
        {
            CategoryModel categoryResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/categories/"+this.ID, this);
            if (response.IsSuccessStatusCode)
                categoryResult = await response.Content.ReadAsAsync<CategoryModel>();
            return categoryResult;
        }

        public async Task<List<FoodModel>> GetFoodByCategoryId(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/category/" + this.ID + "/food");
            List<FoodModel> food = new List<FoodModel>();
            if (response.IsSuccessStatusCode)
                food = await response.Content.ReadAsAsync<List<FoodModel>>();
            return food;
        }

        public async Task<bool> Delete(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/categories/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }

        public async Task<List<CategoryModel>> GetCategoriesByKeyWord(HttpClient client, string keyword)
        {
            HttpResponseMessage response = await client.GetAsync("api/categories/search?keyword="+keyword);
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            if (response.IsSuccessStatusCode)
                categoryModels = await response.Content.ReadAsAsync<List<CategoryModel>>();
            return categoryModels;
        }
    }
}
