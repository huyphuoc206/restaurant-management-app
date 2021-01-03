using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class LoginInfo
    {
        public static long UserID;
        public static string Username;

        public static async Task<UserModel> GetCurrentUser(HttpClient client, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            UserModel userModel = null;
            if (response.IsSuccessStatusCode)
                userModel = await response.Content.ReadAsAsync<UserModel>();
            return userModel;
        }
    }
}
