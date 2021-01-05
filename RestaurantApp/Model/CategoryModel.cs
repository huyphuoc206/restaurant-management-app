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

        public static async Task<List<CategoryModel>> GetCategoriessAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            if (response.IsSuccessStatusCode)
                categoryModels = await response.Content.ReadAsAsync<List<CategoryModel>>();
            return categoryModels;
        }

        public async Task<CategoryModel> Save(HttpClient client, string path)
        {
            CategoryModel categoryResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path, this);
            if (response.IsSuccessStatusCode)
                categoryResult = await response.Content.ReadAsAsync<CategoryModel>();
            return categoryResult;
        }

        public async Task<CategoryModel> Update(HttpClient client, string path)
        {
            CategoryModel categoryResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync(path, this);
            if (response.IsSuccessStatusCode)
                categoryResult = await response.Content.ReadAsAsync<CategoryModel>();
            return categoryResult;
        }
    }
}
