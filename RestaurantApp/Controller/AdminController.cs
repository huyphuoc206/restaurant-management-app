using RestaurantApp.Model;
using RestaurantApp.View;
using System;
using System.Collections.Generic;
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
            InitControllerAsync();
        }

        public Admin View { get => view; set => view = value; }

        private async void InitControllerAsync()
        {
            List<UserModel> users = await UserModel.GetUsersAsync(client, "api/users");
            List<TableModel> tables = await TableModel.GetTablesAsync(client, "api/tables");
            List<CategoryModel> categories = await CategoryModel.GetCategoriessAsync(client, "api/categories");
            List<FoodModel> food = await FoodModel.GetFoodAsync(client, "api/food");
            loadCategories(categories);
            loadUsers(users);
            loadTables(tables);
            loadFood(food);
        }

        private void loadUsers(List<UserModel> users)
        {
            DataGridView dataGridView = view.DataGridView_User;

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

        private void loadTables(List<TableModel> tables)
        {
            DataGridView dataGridView = view.DataGridView_Table;

            var source = new BindingSource();
            source.DataSource = tables;
            dataGridView.DataSource = source;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
            }
        }

        private void loadCategories(List<CategoryModel> categories)
        {
            DataGridView dataGridView = view.DataGridView_category;

            var source = new BindingSource();
            source.DataSource = categories;
            dataGridView.DataSource = source;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
            }
        }

        private void loadFood(List<FoodModel> food)
        {
            DataGridView dataGridView = view.DataGridView_food;

            var source = new BindingSource();
            source.DataSource = food;
            dataGridView.DataSource = source;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
            }
        }
    }
}
