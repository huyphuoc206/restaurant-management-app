using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class RoleModel : AbstractModel
    {
        private string name;
        private string code;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }

        public override string ToString()
        {
            return name;
        }

        public async Task<List<RoleModel>> GetRoles(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/roles");
            List<RoleModel> roles = new List<RoleModel>();
            if (response.IsSuccessStatusCode)
                roles = await response.Content.ReadAsAsync<List<RoleModel>>();
            return roles;
        }
    }
}
