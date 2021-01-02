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
    class AccountProfileController
    {
        private AccountProfile view;
        private HttpClient client = new HttpClient();

        public AccountProfileController()
        {
            View = new AccountProfile();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitControllerAsync();
        }

        public AccountProfile View { get => view; set => view = value; }

        private async Task InitControllerAsync()
        {
            UserModel user = await LoginInfo.GetCurrentUser(client, "api/users/" + LoginInfo.UserID);
            view.loadUserInfo(user);
            view.Btn_update.Click += new EventHandler(UpdateInformationEvent);
        }

        private async void UpdateInformationEvent(Object s, EventArgs e)
        {
            if (view.ValidateChildren(ValidationConstraints.Enabled))
            {
                UserModel model = new UserModel();
                model.UserName = view.Text_username.Text;
                model.FullName = view.Text_fullname.Text;
                model.Phone = view.Text_phone.Text;
                model.Email = view.Text_email.Text;
                model.Address = view.Text_address.Text;
                model.Dob = view.Date_dob.Value;
                string gender = view.Radio_female.Text;
                if (!view.Radio_female.Checked)
                    gender = view.Radio_male.Text;
                model.Gender = gender;

                model = await UpdateInformation(model);
                if (model != null)
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc email đã tồn tại trong hệ thống.");
                }
            }
        }

        private async Task<UserModel> UpdateInformation(UserModel model)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("api/users/" + LoginInfo.UserID, model);
            UserModel user = null;

            if (response.IsSuccessStatusCode)
                user = await response.Content.ReadAsAsync<UserModel>();
            return user;
        }
    }
}
