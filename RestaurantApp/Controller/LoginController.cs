using RestaurantApp.BindingData;
using RestaurantApp.Constant;
using RestaurantApp.Model;
using RestaurantApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Controller
{
    class LoginController
    {
        private Login view;
        private HttpClient client = new HttpClient();

        public LoginController()
        {
            View = new Login();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitControllerAsync();
        }

        private void InitControllerAsync()
        {
            view.Btn_login.Click += new EventHandler(LoginEventAsync);
        }

        private async void LoginEventAsync(Object s, EventArgs e)
        {
            string username = view.User_text.Text;
            string password = view.Pass_text.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản và mật khẩu.");
                return;
            }
            UserModel user = await CheckLogin(username, password);
            if (user != null)
            {
                LoginInfo.UserID = user.ID;
                LoginInfo.Username = user.UserName;
                LoginInfo.Fullname = user.FullName;

                if (user.Role.Code.Equals(SystemConstant.MANAGER))
                {
                    AdminController adminView = new AdminController();
                    view.Hide();
                    adminView.View.accountMenu.Text = "Quản lý - " + LoginInfo.Fullname;
                    adminView.View.ShowDialog();
                }
                else if (user.Role.Code.Equals(SystemConstant.STAFF))
                {
                    UserController userView = new UserController();
                    view.Hide();
                    userView.View.AccountMenu.Text = "Nhân viên - "+LoginInfo.Fullname;
                    userView.View.ShowDialog();
                }
                view.Clear();
                view.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");
                return;
            }
        }

        private async Task<UserModel> CheckLogin(string username, string password)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/users/Login", new LoginData(username, password));
            UserModel user = null;
            if (response.IsSuccessStatusCode)
                user = await response.Content.ReadAsAsync<UserModel>();
            return user;
        }
        public Login View { get => view; set => view = value; }
    }
}
