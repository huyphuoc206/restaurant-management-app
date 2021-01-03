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

        private async void InitController()
        {
            List<TableModel> tables = await TableModel.GetTablesAsync(client, "api/tables");
            List<CategoryModel> categories = await CategoryModel.GetCategoriessAsync(client, "api/categories");
            loadCategoriesName(categories);
            loadTables(tables);
        }

        public void loadTables(List<TableModel> tables)
        {
            Button[] btns_table = createBtnTables(tables);
            view.panel_table.Controls.AddRange(btns_table);
        }

        public Button[] createBtnTables(List<TableModel> tables)
        {

            Button[] btns_table = new Button[tables.Count];
            for (int i = 0; i < btns_table.Length; i++)
            {
                int x = 10 + 100 * (i % 3);
                int y = 50 + (i / 3) * 100;
                btns_table[i] = new Button();
                btns_table[i].TextAlign = ContentAlignment.MiddleCenter;
                btns_table[i].Text = tables[i].Name;
                btns_table[i].SetBounds(x, y, 60, 60);
                if (tables[i].Status.Equals("1"))
                {
                    btns_table[i].Text += "\n Có người";
                    btns_table[i].BackColor = Color.Bisque;
                }
                else
                {
                    btns_table[i].Text += " \n Trống";
                    btns_table[i].BackColor = Color.Coral;
                }

            }
            return btns_table;
        }

        public String[] createCategoriesName(List<CategoryModel> categories)
        {
            String[] rs = new String[categories.Count];
            for (int i = 0; i < categories.Count; i++)
                rs[i] = (categories[i].Name);
            return rs;
        }

        public void loadCategoriesName(List<CategoryModel> categories)
        {
            String[] categoriesName = createCategoriesName(categories);
            view.cb_categories.Items.AddRange(categoriesName);
        }

        /*public void loadFoods()
        {

            Task<FoodModel[]> f = FoodModel.GetFoodsAsync(client, "api/food");
            FoodModel[] foods = await f;
            Button[] btns_food = createBtnFood(foods);
            view.panel_menu.Controls.AddRange(btns_food);
        }
        public Button[] createBtnFood(FoodModel[] foods)
        {

            Button[] btns_food = new Button[foods.Length];
            for (int i = 0; i < btns_food.Length; i++)
            {
                int x = 30 + 120 * (i % 5);
                int y = 140 + (i / 5) * 110;
                btns_food[i] = new Button();
                btns_food[i].SetBounds(x, y, 100, 100);
                btns_food[i].Text = foods[i].Name;

            }
            return btns_food;


        }*/
    }
}

