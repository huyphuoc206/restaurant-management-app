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

        public static async Task<List<UserModel>> GetUsersAsync(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<UserModel> users = new List<UserModel>();
            if (response.IsSuccessStatusCode)
                users = await response.Content.ReadAsAsync<List<UserModel>>();
            return users;
        }
    }
}
