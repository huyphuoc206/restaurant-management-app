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
    class AdminController
    {
        private Admin view;
        private HttpClient client = new HttpClient();

        public AdminController()
        {
            this.View = new Admin();
            InitController();
        }

        public Admin View { get => view; set => view = value; }

        private async void InitController()
        {
            DataGridView dataGridView = view.DataGridView_User;
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            UserModel[] users = await loadTablesAsync("api/users");
            var source = new BindingSource();
            source.DataSource = users;
            dataGridView.DataSource = source;
            string[] array = { "CreatedDate" ,"CreatedBy","ModifiedDate","ModifiedBy"};
           
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;           
            }
        }


        private async Task<UserModel[]> loadTablesAsync(string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            UserModel[] users = null;
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<UserModel[]>();
            }
            return users;
        }
    }
}
