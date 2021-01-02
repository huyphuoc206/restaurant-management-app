using RestaurantApp.BindingData;
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
    class ResetPasswordController
    {
        private ResetPassword view;
        private HttpClient client = new HttpClient();

        public ResetPasswordController()
        {
            View = new ResetPassword();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitControllerAsync();
        }

        public ResetPassword View { get => view; set => view = value; }

        private void InitControllerAsync()
        {
            view.Btn_saveResetPassword.Click += new EventHandler(ResetPasswordEvent);
        }

        private async void ResetPasswordEvent(Object s, EventArgs e)
        {
            if (view.ValidateChildren(ValidationConstraints.Enabled))
            {
                string currentPassword = view.Text_currentPassword.Text;
                string password = view.Text_newPassword.Text;
                string passwordConfirm = view.Text_passwordRp.Text;
                if (!password.Equals(passwordConfirm))
                {
                    MessageBox.Show("Mật khẩu mới không khớp.");
                    return;
                }
                UserModel user = await ResetPassword(currentPassword, password, passwordConfirm);
                if (user != null)
                {
                    MessageBox.Show("Đổi mật khẩu thành công.");
                    view.Clear();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác hoặc trùng với mật khẩu mới.");
                }
            }
        }

        private async Task<UserModel> ResetPassword(string currentPassword, string password, string passwordConfirm)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("api/users/ResetPassword/" + LoginInfo.UserID, new ResetPasswordData(currentPassword, password, passwordConfirm));
            UserModel user = null;

            if (response.IsSuccessStatusCode)
                user = await response.Content.ReadAsAsync<UserModel>();
            return user;
        }
    }
}
