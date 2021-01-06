using RestaurantApp.Constant;
using RestaurantApp.Model;
using RestaurantApp.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Controller
{
    class UserController
    {
        private User view;
        private HttpClient client = new HttpClient();

        public UserController()
        {
            this.View = new User();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitController();
        }

        public User View { get => view; set => view = value; }

        private void InitController()
        {
            loadData();
            Event();
        }

        private async void loadData()
        {
            List<TableModel> tables = await TableModel.GetTablesAsync(client, "api/tables");
            List<SaleModel> sales = await SaleModel.GetSalesAsync(client, "api/sales");
            List<SaleModel> salesShow = new List<SaleModel>();
            foreach (SaleModel sale in sales)
                if (sale.Status.Equals("1"))
                    salesShow.Add(sale);
            List<CategoryModel> categories = await CategoryModel.GetCategoriessAsync(client, "api/categories");
            List<CategoryModel> categoriesShow = new List<CategoryModel>();
            foreach (CategoryModel category in categories)
                if (category.Status.Equals("1"))
                    categoriesShow.Add(category);
            view.loadTables(tables);
            view.loadCategories(categoriesShow);
            view.loadSales(salesShow);
        }

        private void Event()
        {
            view.cb_categories.SelectedIndexChanged += new EventHandler(cb_categories_SelectedIndexChanged);
        }
        private async void cb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            CategoryModel selected = cb.SelectedItem as CategoryModel;
            List<FoodModel> food = await selected.GetFoodByCategoryId(client, "api/category/" + selected.ID + "/food");
            view.loadFoodByCategory(food);
        }
    }
}

