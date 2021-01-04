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
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitControllerAsync();
        }

        public Admin View { get => view; set => view = value; }

        private void InitControllerAsync()
        {
            LoadData();
            EventBtnView();
            EventBtnAdd();
            EventBtnUpdate();
            EventBtnDelete();
        }

        private async void LoadData()
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
            view.loadCategoriesIntoCb(categories);
        }

        private void EventBtnView()
        {
            view.Btn_viewFood.Click += new EventHandler(LoadFood);
            view.Btn_viewCategory.Click += new EventHandler(LoadCategory);
            view.Btn_viewSale.Click += new EventHandler(LoadSale);
            view.Btn_viewTable.Click += new EventHandler(LoadTable);
            view.Btn_viewUser.Click += new EventHandler(LoadUser);
        }
        private void EventBtnAdd()
        {
            view.Btn_addFood.Click += new EventHandler(AddFood);
            view.Btn_addTable.Click += new EventHandler(AddTable);
        }
        private void EventBtnUpdate()
        {
            view.Btn_updateFood.Click += new EventHandler(UpdateFood);
            view.Btn_updateTable.Click += new EventHandler(UpdateTable);
        }
        private void EventBtnDelete()
        {
            view.Btn_deleteFood.Click += new EventHandler(DeleteFood);
            view.Btn_deleteTable.Click += new EventHandler(DeleteTable);
        }

        // CRUD Food
        private async void LoadFood(object sender, EventArgs e)
        {
            view.ClearFoodBinding();
            List<FoodModel> food = await FoodModel.GetFoodAsync(client, "api/food");
            view.loadFood(food);
        }
        private async void AddFood(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelFood.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelFood.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                FoodModel food = new FoodModel();
                food.Name = view.Text_foodName.Text;
                food.Price = (long)view.Food_price.Value;
                food.Discount = (int)view.Food_discount.Value;
                CategoryModel category = (CategoryModel)view.Cb_foodCategory.SelectedItem;
                food.Category = category;
                string status = (string)view.Cb_foodStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    food.Status = "1";
                else
                    food.Status = "0";
                food.CreatedBy = LoginInfo.Username;

                HttpResponseMessage response = await client.PostAsJsonAsync("api/food", food);
                if (response.IsSuccessStatusCode)
                    food = await response.Content.ReadAsAsync<FoodModel>();

                if (food != null)
                {
                    MessageBox.Show("Thêm món ăn thành công.");
                    LoadFood(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
        }
        private async void UpdateFood(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelFood.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelFood.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                long id = Convert.ToInt64(view.Text_foodId.Text);
                FoodModel food = new FoodModel();
                food.Name = view.Text_foodName.Text;
                food.Price = (long)view.Food_price.Value;
                food.Discount = (int)view.Food_discount.Value;
                CategoryModel category = (CategoryModel)view.Cb_foodCategory.SelectedItem;
                food.Category = category;
                string status = (string)view.Cb_foodStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    food.Status = "1";
                else
                    food.Status = "0";
                food.ModifiedBy = LoginInfo.Username;

                HttpResponseMessage response = await client.PutAsJsonAsync("api/food/" + id, food);
                if (response.IsSuccessStatusCode)
                    food = await response.Content.ReadAsAsync<FoodModel>();

                if (food != null)
                {
                    // Xu ly cac order detail thuoc order (chua duoc thanh toan) co chua food nay -> phai cap nhat lai gia tien
                    List<OrderModel> orders = await OrderModel.GetOrdersAsync(client, "api/orders");
                    List<OrderModel> ordersUnPaid = new List<OrderModel>();
                    foreach (OrderModel o in orders)
                    {
                        if (o.Status.Equals("0"))
                            ordersUnPaid.Add(o);
                    }
                    if (ordersUnPaid.Count != 0)
                    {
                        foreach (OrderModel o in ordersUnPaid)
                        {
                            List<OrderDetailModel> orderDetails = await OrderDetailModel.GetOrderDetailAsync(client, "api/orders/" + o.ID + "/orderdetails");
                            foreach (OrderDetailModel od in orderDetails)
                            {
                                if (od.Food.ID == id)
                                {
                                    od.UnitPrice = food.Price - food.Price * food.Discount / 100;
                                    od.ModifiedBy = LoginInfo.Username;
                                    await client.PutAsJsonAsync("api/orderdetail/" + od.ID, od);
                                }
                            }
                        }
                    }

                    MessageBox.Show("Cập nhật món ăn thành công.");
                    LoadFood(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
        }
        private async void DeleteFood(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(view.Text_foodId.Text);

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa món ăn này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HttpResponseMessage response = await client.DeleteAsync("api/food/" + id);
                bool result = false;
                if (response.IsSuccessStatusCode)
                    result = await response.Content.ReadAsAsync<bool>();

                if (result)
                {
                    MessageBox.Show("Xóa món ăn thành công.");
                    LoadFood(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành tạm ngưng thay vì xóa.");
                }
            }
        }
        // End CRUD Food

        // CRUD Table
        private async void LoadTable(object sender, EventArgs e)
        {
            view.ClearTableBinding();
            List<TableModel> tables = await TableModel.GetTablesAsync(client, "api/tables");
            view.loadTables(tables);
        }
        private async void AddTable(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelTable.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelTable.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                TableModel table = new TableModel();
                table.Name = view.Text_tableName.Text;
                table.Seats = (int)view.Num_tableSeats.Value;
                string status = (string)view.Cb_tableStatus.SelectedItem;
                if (status.Equals("Đã có người"))
                    table.Status = "1";
                else if (status.Equals("Còn trống"))
                    table.Status = "0";
                else
                    table.Status = "2";
                table.CreatedBy = LoginInfo.Username;

                HttpResponseMessage response = await client.PostAsJsonAsync("api/tables", table);
                if (response.IsSuccessStatusCode)
                    table = await response.Content.ReadAsAsync<TableModel>();

                if (table != null)
                {
                    MessageBox.Show("Thêm bàn ăn thành công.");
                    LoadTable(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
        }
        private async void UpdateTable(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelTable.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelTable.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                long id = Convert.ToInt64(view.Text_tableId.Text);
                TableModel table = new TableModel();
                table.Name = view.Text_tableName.Text;
                table.Seats = (int)view.Num_tableSeats.Value;
                string status = (string)view.Cb_tableStatus.SelectedItem;
                if (status.Equals("Đã có người"))
                    table.Status = "1";
                else if (status.Equals("Còn trống"))
                    table.Status = "0";
                else
                    table.Status = "2";
                table.ModifiedBy = LoginInfo.Username;

                HttpResponseMessage response = await client.PutAsJsonAsync("api/tables/" + id, table);
                if (response.IsSuccessStatusCode)
                    table = await response.Content.ReadAsAsync<TableModel>();

                if (table != null)
                {
                    MessageBox.Show("Cập nhật bàn ăn thành công.");
                    LoadTable(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
        }
        private async void DeleteTable(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(view.Text_tableId.Text);

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa bàn ăn này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HttpResponseMessage response = await client.DeleteAsync("api/tables/" + id);
                bool result = false;
                if (response.IsSuccessStatusCode)
                    result = await response.Content.ReadAsAsync<bool>();

                if (result)
                {
                    MessageBox.Show("Xóa bàn ăn thành công.");
                    LoadTable(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành ngưng hoạt động thay vì xóa.");
                }
            }
        }
        // End CRUD Table

        private async void LoadCategory(object sender, EventArgs e)
        {
            /*view.ClearCategoryBinding();*/
            List<CategoryModel> categories = await CategoryModel.GetCategoriessAsync(client, "api/categories");
            view.loadCategories(categories);
        }
        private async void LoadUser(object sender, EventArgs e)
        {
            /*view.ClearUserBinding();*/
            List<UserModel> users = await UserModel.GetUsersAsync(client, "api/users");
            view.loadUsers(users);
        }
        private async void LoadSale(object sender, EventArgs e)
        {
            /*view.ClearSaleBinding();*/
            List<SaleModel> sales = await SaleModel.GetSalesAsync(client, "api/sales");
            view.loadSales(sales);
        }
    }
}
