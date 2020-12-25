using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    class CategoryModel : AbstractModel
    {
        private string name;
        private string code;
        private int status;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public int Status { get => status; set => status = value; }

        public static async Task<List<CategoryModel>> GetCategoriessAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<CategoryModel> categoryModels = new List<CategoryModel>();
            if (response.IsSuccessStatusCode)
                categoryModels = await response.Content.ReadAsAsync<List<CategoryModel>>();
            return categoryModels;
        }
    }
}
