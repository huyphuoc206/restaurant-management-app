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
            InitController();
        }

        public Admin View { get => view; set => view = value; }

        private void InitController()
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
            List<RoleModel> roles = await RoleModel.GetRolesAsync(client, "api/roles");
            view.loadCategories(categories);
            view.loadUsers(users);
            view.loadTables(tables);
            view.loadFood(food);
            view.loadSales(sales);
            view.loadCategoriesIntoCb(categories);
            view.loadRolesIntoCb(roles);
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
            view.Btn_addCategory.Click += new EventHandler(AddCategory);
            view.Btn_addSale.Click += new EventHandler(AddSale);
            view.Btn_addUser.Click += new EventHandler(AddUser);
        }
        private void EventBtnUpdate()
        {
            view.Btn_updateFood.Click += new EventHandler(UpdateFood);
            view.Btn_updateTable.Click += new EventHandler(UpdateTable);
            view.Btn_updateCategory.Click += new EventHandler(UpdateCategory);
            view.Btn_updateSale.Click += new EventHandler(UpdateSale);
            view.Btn_updateUser.Click += new EventHandler(UpdateUser);
        }
        private void EventBtnDelete()
        {
            view.Btn_deleteFood.Click += new EventHandler(DeleteFood);
            view.Btn_deleteTable.Click += new EventHandler(DeleteTable);
            view.Btn_deleteCategory.Click += new EventHandler(DeleteCategory);
            view.Btn_deleteSale.Click += new EventHandler(DeleteSale);
            view.Btn_deleteUser.Click += new EventHandler(DeleteUser);
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

                food = await food.Save(client, "api/food");

                if (food != null)
                {
                    MessageBox.Show("Thêm món ăn thành công.");
                    LoadFood(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra.");
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

                food = await food.Update(client, "api/food/" + id);

                if (food != null)
                {
                    MessageBox.Show("Cập nhật món ăn thành công.");
                    LoadFood(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra.");
            }
        }
        private async void DeleteFood(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(view.Text_foodId.Text);
            FoodModel food = new FoodModel();

            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa món ăn này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = await food.Delete(client, "api/food/" + id);

                if (result)
                {
                    MessageBox.Show("Xóa món ăn thành công.");
                    LoadFood(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành tạm ngưng thay vì xóa.");
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

                table = await table.Save(client, "api/tables");

                if (table != null)
                {
                    MessageBox.Show("Thêm bàn ăn thành công.");
                    LoadTable(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra.");
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

                table = await table.Update(client, "api/tables/" + id);
             
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
            TableModel table = new TableModel();
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa bàn ăn này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = await table.Delete(client, "api/tables/" + id);
              
                if (result)
                {
                    MessageBox.Show("Xóa bàn ăn thành công.");
                    LoadTable(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành ngưng hoạt động thay vì xóa.");
            }
        }
        // End CRUD Table

        // CRUD Category
        private async void LoadCategory(object sender, EventArgs e)
        {
            view.ClearCategoryBinding();
            List<CategoryModel> categories = await CategoryModel.GetCategoriessAsync(client, "api/categories");
            view.loadCategories(categories);
            view.loadCategoriesIntoCb(categories);
        }
        private async void AddCategory(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelCategory.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelCategory.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                CategoryModel category = new CategoryModel();
                category.Name = view.Text_categoryname.Text;
                string status = (string)view.Cb_categoryStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    category.Status = "1";
                else
                    category.Status = "0";

                category.CreatedBy = LoginInfo.Username;

                category = await category.Save(client, "api/categories");

                if (category != null)
                {
                    MessageBox.Show("Thêm danh mục thành công.");
                    LoadCategory(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra.");
            }
        }
        private async void UpdateCategory(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelCategory.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelCategory.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                long id = Convert.ToInt64(view.Text_categoryId.Text);
                CategoryModel category = new CategoryModel();
                category.Name = view.Text_categoryname.Text;
                string status = (string)view.Cb_categoryStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    category.Status = "1";
                else
                    category.Status = "0";

                category.ModifiedBy = LoginInfo.Username;

                category = await category.Update(client, "api/categories/" + id);

                if (category != null)
                {
                    MessageBox.Show("Cập nhật danh mục thành công.");
                    LoadCategory(sender, e);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
        }
        private async void DeleteCategory(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(view.Text_categoryId.Text);
            CategoryModel category = new CategoryModel();
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa danh mục này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = await category.Delete(client, "api/categories/" + id);

                if (result)
                {
                    MessageBox.Show("Xóa danh mục thành công.");
                    LoadCategory(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành tạm ngưng thay vì xóa.");
            }
        }
        // End CRUD Category


        // CRUD Sale
        private async void LoadSale(object sender, EventArgs e)
        {
            view.ClearSaleBinding();
            List<SaleModel> sales = await SaleModel.GetSalesAsync(client, "api/sales");
            view.loadSales(sales);
        }
        private async void AddSale(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelSale.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelSale.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                SaleModel sale = new SaleModel();
                sale.Name = view.Text_saleName.Text;
                sale.Discount = (int)view.SaleDiscountNum.Value;
                string status = (string)view.Cb_saleStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    sale.Status = "1";
                else
                    sale.Status = "0";

                sale.CreatedBy = LoginInfo.Username;

                sale = await sale.Save(client, "api/sales");

                if (sale != null)
                {
                    MessageBox.Show("Thêm chương trình giảm giá thành công.");
                    LoadSale(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra.");
            }
        }
        private async void UpdateSale(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelSale.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelSale.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                long id = Convert.ToInt64(view.Text_saleId.Text);
                SaleModel sale = new SaleModel();
                sale.Name = view.Text_saleName.Text;
                sale.Discount = (int)view.SaleDiscountNum.Value;
                string status = (string)view.Cb_saleStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    sale.Status = "1";
                else
                    sale.Status = "0";

                sale.ModifiedBy = LoginInfo.Username;

                sale = await sale.Update(client, "api/sales/" + id);

                if (sale != null)
                {
                    MessageBox.Show("Cập nhật chương trình giảm giá thành công.");
                    LoadSale(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra.");
            }
        }
        private async void DeleteSale(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(view.Text_saleId.Text);
            SaleModel sale = new SaleModel();
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa chương trình giảm giá này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = await sale.Delete(client, "api/sales/" + id);

                if (result)
                {
                    MessageBox.Show("Xóa chương trình giảm giá thành công.");
                    LoadSale(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành tạm ngưng thay vì xóa.");
            }
        }
        // End CRUD Sale

        // CRUD User
        private async void LoadUser(object sender, EventArgs e)
        {
            view.ClearUserBinding();
            List<UserModel> users = await UserModel.GetUsersAsync(client, "api/users");
            view.loadUsers(users);
        }
        private async void AddUser(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelUser.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelUser.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                UserModel user = new UserModel();
                user.FullName = view.Text_fullname.Text;
                user.UserName = view.Text_username.Text;
                user.PassWord = view.Text_password.Text;
                user.Phone = view.Text_phone.Text;
                user.Email = view.Text_email.Text;
                user.Address = view.Text_address.Text;
                user.Dob = view.DateTime_dobUser.Value;
                RoleModel role = (RoleModel)view.Cb_role.SelectedItem;
                user.Role = role;
                string status = (string)view.Cb_userStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    user.Status = "1";
                else
                    user.Status = "0";
                string gender = view.Radio_female.Checked ? view.Radio_female.Text : view.Radio_male.Text;
                user.Gender = gender;
                user.CreatedBy = LoginInfo.Username;

                user = await user.Save(client, "api/users");

                if (user != null)
                {
                    MessageBox.Show("Thêm người dùng thành công.");
                    LoadUser(sender, e);
                }
                else
                    MessageBox.Show("Email hoặc tên tài khoản đã tồn tại trong hệ thống.");
            }
        }
        private async void UpdateUser(object sender, EventArgs e)
        {
            foreach (Control c in view.PanelUser.Controls)
                c.Focus();
            int countError = 0;
            foreach (Control c in view.PanelUser.Controls)
            {
                String error = view.ErrorEmpty.GetError(c);
                if (error != String.Empty)
                    countError++;
            }
            if (countError == 0)
            {
                long id = Convert.ToInt64(view.Text_userId.Text);
                UserModel user = new UserModel();
                user.FullName = view.Text_fullname.Text;
                user.UserName = view.Text_username.Text;
                user.PassWord = view.Text_password.Text;
                user.Phone = view.Text_phone.Text;
                user.Email = view.Text_email.Text;
                user.Address = view.Text_address.Text;
                user.Dob = view.DateTime_dobUser.Value;
                RoleModel role = (RoleModel)view.Cb_role.SelectedItem;
                user.Role = role;
                string status = (string)view.Cb_userStatus.SelectedItem;
                if (status.Equals("Hoạt động"))
                    user.Status = "1";
                else
                    user.Status = "0";
                string gender = view.Radio_female.Checked ? view.Radio_female.Text : view.Radio_male.Text;
                user.Gender = gender;

                user.ModifiedBy = LoginInfo.Username;

                user = await user.Update(client, "api/users/" + id);

                if (user != null)
                {
                    MessageBox.Show("Cập nhật người dùng thành công.");
                    LoadUser(sender, e);
                }
                else
                    MessageBox.Show("Email hoặc tên tài khoản đã tồn tại trong hệ thống.");
            }
        }
        private async void DeleteUser(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(view.Text_userId.Text);
            UserModel user = new UserModel();
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa người dùng này?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = await user.Delete(client, "api/users/" + id);

                if (result)
                {
                    MessageBox.Show("Xóa người dùng thành công.");
                    LoadUser(sender, e);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra, bạn nên cập nhật trạng thái thành tạm ngưng thay vì xóa.");
            }
        }
        // End CRUD User
    }
}
