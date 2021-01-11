using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class UserModel : AbstractModel
    {
        private string fullName;
        private string userName;
        private string passWord;
        private string phone;
        private string address;
        private string email;
        private DateTime dob;
        private string gender;
        private string status;
        private RoleModel role;

        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Status { get => status; set => status = value; }
        public string Gender { get => gender; set => gender = value; }
        public RoleModel Role { get => role; set => role = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public async Task<List<UserModel>> GetUsers(HttpClient client)
        {
            HttpResponseMessage response = await client.GetAsync("api/users");
            List<UserModel> users = new List<UserModel>();
            if (response.IsSuccessStatusCode)
                users = await response.Content.ReadAsAsync<List<UserModel>>();
            return users;
        }

        public async Task<UserModel> Save(HttpClient client)
        {
            UserModel userResult = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("api/users", this);
            if (response.IsSuccessStatusCode)
                userResult = await response.Content.ReadAsAsync<UserModel>();
            return userResult;
        }

        public async Task<UserModel> Update(HttpClient client)
        {
            UserModel userResult = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("api/users/"+this.ID, this);
            if (response.IsSuccessStatusCode)
                userResult = await response.Content.ReadAsAsync<UserModel>();
            return userResult;
        }

        public async Task<bool> Delete(HttpClient client)
        {
            bool result = false;
            HttpResponseMessage response = await client.DeleteAsync("api/users/" + this.ID);
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<bool>();
            return result;
        }

        public async Task<List<UserModel>> GetUsersByKeyWord(HttpClient client, string keyword)
        {
            HttpResponseMessage response = await client.GetAsync("api/users/search?keyword="+keyword);
            List<UserModel> users = new List<UserModel>();
            if (response.IsSuccessStatusCode)
                users = await response.Content.ReadAsAsync<List<UserModel>>();
            return users;
        }
    }
}
