using RestaurantApp.Model;
using RestaurantApp.View;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace RestaurantApp.Controller
{
    class AdminController
    {
        private Admin view;
        private HttpClient client = new HttpClient();

        public AdminController()
        {
            this.View = new Admin();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitController();
        }

        public Admin View { get => view; set => view = value; }

        private void InitController()
        {
            loadUsers();
        }

        private async void loadUsers()
        {
            DataGridView dataGridView = view.DataGridView_User;

            UserModel[] users = await UserModel.GetUsersAsync(client, "api/users");
            var source = new BindingSource();
            source.DataSource = users;
            dataGridView.DataSource = source;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy","ID" };

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
            }
        }
    }
}
