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
            List<SaleModel> sales = await SaleModel.GetSalesAsync(client, "api/sales");
            view.loadCategories(categories);
            view.loadUsers(users);
            view.loadTables(tables);
            view.loadFood(food);
            view.loadSales(sales);
        }
    }
}
