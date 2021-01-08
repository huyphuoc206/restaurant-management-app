using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.View
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadDateTimerAllBill();
        }
        void LoadDateTimerAllBill()
        {
            DateTime today = DateTime.Now;
            dtp_fromdate.Value = new DateTime(today.Year, today.Month, 1);
            dtp_todate.Value = dtp_fromdate.Value.AddMonths(1).AddDays(-1);
        }

        private void checkErrorEmpty(TextBox textBox, string message, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                e.Cancel = true;
                textBox.Focus();
                ErrorEmpty.SetError(textBox, message);
            }
            else
            {
                e.Cancel = false;
                ErrorEmpty.SetError(textBox, null);
            }
        }

        private void LoadStatus(ComboBox cb, string s1, string s2)
        {
            cb.Items.Add(s1);
            cb.Items.Add(s2);
            cb.SelectedIndex = 0;
        }

        // food
        public void loadCategoriesIntoCb(List<CategoryModel> categories)
        {
            cb_foodCategory.DataSource = categories;
        }

        public void loadFood(List<FoodModel> food)
        {
            food = food.OrderBy(r => r.ID).ToList();
            dataGridView_food.DataSource = food;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy" };
            int colStatus = -1;

            foreach (DataGridViewColumn column in dataGridView_food.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
                if (column.Name.Equals("foodStatus"))
                {
                    colStatus = column.Index;
                }
            }

            foreach (DataGridViewRow row in dataGridView_food.Rows)
            {
                if (row.Cells[colStatus].Value != null)
                {
                    string value = row.Cells[colStatus].Value.ToString();

                    if (value.Equals("1"))
                        row.Cells[colStatus].Value = "Hoạt động";
                    else
                        row.Cells[colStatus].Value = "Tạm ngưng";
                }
            }
            FoodBinding();
            if (Cb_foodStatus.Items.Count == 0)
                LoadStatus(Cb_foodStatus, "Hoạt động", "Tạm ngưng");
        }

        public void FoodBinding()
        {
            text_foodId.DataBindings.Add(new Binding("Text", dataGridView_food.DataSource, "ID", true, DataSourceUpdateMode.Never));
            text_foodName.DataBindings.Add(new Binding("Text", dataGridView_food.DataSource, "Name", true, DataSourceUpdateMode.Never));
            food_price.DataBindings.Add(new Binding("Value", dataGridView_food.DataSource, "Price", true, DataSourceUpdateMode.Never));
            food_discount.DataBindings.Add(new Binding("Value", dataGridView_food.DataSource, "Discount", true, DataSourceUpdateMode.Never));
        }

        public void ClearFoodBinding()
        {
            text_foodId.DataBindings.Clear();
            text_foodName.DataBindings.Clear();
            food_price.DataBindings.Clear();
            food_discount.DataBindings.Clear();
        }

        private void text_foodId_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_food.SelectedCells.Count > 0)
            {
                CategoryModel category = (CategoryModel)dataGridView_food.SelectedCells[0].OwningRow.Cells["categoryFood"].Value;
                int index = -1;
                int i = 0;
                foreach (CategoryModel item in cb_foodCategory.Items)
                {
                    if (category.ID == item.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cb_foodCategory.SelectedIndex = index;

                i = 0;
                string status = (string)dataGridView_food.SelectedCells[0].OwningRow.Cells["foodStatus"].Value;
                foreach (string item in cb_foodStatus.Items)
                {
                    if (status.Equals(item))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cb_foodStatus.SelectedIndex = index;
            }
        }

        private void btn_clearFood_Click(object sender, EventArgs e)
        {
            text_foodName.Text = "";
            food_price.Value = 0;
            food_discount.Value = 0;
        }

        private void text_foodName_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_foodName, "Bạn phải nhập tên món ăn.", e);
        }
        // end food

        // table
        public void loadTables(List<TableModel> tables)
        {
            tables = tables.OrderBy(r => r.ID).ToList();
            dataGridView_table.DataSource = tables;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy" };
            int colStatus = -1;
            foreach (DataGridViewColumn column in dataGridView_table.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
                if (column.Name.Equals("tableStatus"))
                {
                    colStatus = column.Index;
                }
            }

            foreach (DataGridViewRow row in dataGridView_table.Rows)
            {
                if (row.Cells[colStatus].Value != null)
                {
                    string value = row.Cells[colStatus].Value.ToString();

                    if (value.Equals("1"))
                        row.Cells[colStatus].Value = "Đã có người";
                    else if (value.Equals("0"))
                        row.Cells[colStatus].Value = "Còn trống";
                    else
                        row.Cells[colStatus].Value = "Ngưng hoạt động";
                }
            }
            TableBinding();
            if (cb_tableStatus.Items.Count == 0)
            {
                cb_tableStatus.Items.Add("Đã có người");
                cb_tableStatus.Items.Add("Còn trống");
                cb_tableStatus.Items.Add("Ngưng hoạt động");
            }

        }

        public void TableBinding()
        {
            text_tableId.DataBindings.Add(new Binding("Text", dataGridView_table.DataSource, "ID", true, DataSourceUpdateMode.Never));
            text_tableName.DataBindings.Add(new Binding("Text", dataGridView_table.DataSource, "Name", true, DataSourceUpdateMode.Never));
            num_tableSeats.DataBindings.Add(new Binding("Value", dataGridView_table.DataSource, "Seats", true, DataSourceUpdateMode.Never));
        }

        public void ClearTableBinding()
        {
            text_tableId.DataBindings.Clear();
            text_tableName.DataBindings.Clear();
            num_tableSeats.DataBindings.Clear();
        }

        private void text_tableId_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_table.SelectedCells.Count > 0)
            {
                int index = -1;
                int i = 0;
                string status = (string)dataGridView_table.SelectedCells[0].OwningRow.Cells["tableStatus"].Value;
                foreach (string item in cb_tableStatus.Items)
                {
                    if (status.Equals(item))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cb_tableStatus.SelectedIndex = index;
            }
        }

        private void text_tableName_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_tableName, "Bạn phải nhập tên bàn ăn.", e);
        }

        private void btn_clearTable_Click(object sender, EventArgs e)
        {
            text_tableName.Text = "";
            Num_tableSeats.Value = 1;
        }
        // end table

        // category
        public void loadCategories(List<CategoryModel> categories)
        {
            categories = categories.OrderBy(r => r.ID).ToList();
            dataGridView_category.DataSource = categories;
            string[] array = { "CreatedBy", "ModifiedDate", "ModifiedBy" };
            int colStatus = -1;
            foreach (DataGridViewColumn column in dataGridView_category.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
                if (column.Name.Equals("categoryStatus"))
                {
                    colStatus = column.Index;
                }
            }

            foreach (DataGridViewRow row in dataGridView_category.Rows)
            {
                if (row.Cells[colStatus].Value != null)
                {
                    string value = row.Cells[colStatus].Value.ToString();

                    if (value.Equals("1"))
                        row.Cells[colStatus].Value = "Hoạt động";
                    else
                        row.Cells[colStatus].Value = "Tạm ngưng";
                }
            }
            CategoryBinding();
            if (cb_categoryStatus.Items.Count == 0)
                LoadStatus(cb_categoryStatus, "Hoạt động", "Tạm ngưng");
        }

        public void CategoryBinding()
        {
            text_categoryId.DataBindings.Add(new Binding("Text", dataGridView_category.DataSource, "ID", true, DataSourceUpdateMode.Never));
            text_categoryname.DataBindings.Add(new Binding("Text", dataGridView_category.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        public void ClearCategoryBinding()
        {
            text_categoryId.DataBindings.Clear();
            Text_categoryname.DataBindings.Clear();
        }

        private void text_categoryId_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_category.SelectedCells.Count > 0)
            {
                int index = -1;
                int i = 0;
                string status = (string)dataGridView_category.SelectedCells[0].OwningRow.Cells["categoryStatus"].Value;
                foreach (string item in cb_categoryStatus.Items)
                {
                    if (status.Equals(item))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cb_categoryStatus.SelectedIndex = index;
            }
        }

        private void btn_clearCategory_Click(object sender, EventArgs e)
        {
            Text_categoryname.Text = "";
        }

        private void text_categoryname_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_categoryname, "Bạn phải nhập tên danh mục.", e);
        }
        // end category

        // sale
        public void loadSales(List<SaleModel> sales)
        {
            sales = sales.OrderBy(r => r.ID).ToList();
            dataGridView_Sale.DataSource = sales;
            string[] array = { "CreatedBy", "ModifiedDate", "ModifiedBy" };

            int colStatus = -1;
            foreach (DataGridViewColumn column in dataGridView_Sale.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
                if (column.Name.Equals("saleStatus"))
                {
                    colStatus = column.Index;
                }
            }

            foreach (DataGridViewRow row in dataGridView_Sale.Rows)
            {
                if (row.Cells[colStatus].Value != null)
                {
                    string value = row.Cells[colStatus].Value.ToString();

                    if (value.Equals("1"))
                        row.Cells[colStatus].Value = "Hoạt động";
                    else
                        row.Cells[colStatus].Value = "Tạm ngưng";
                }
            }
            SaleBinding();
            if (cb_saleStatus.Items.Count == 0)
                LoadStatus(cb_saleStatus, "Hoạt động", "Tạm ngưng");
        }

        public void SaleBinding()
        {
            text_saleId.DataBindings.Add(new Binding("Text", dataGridView_Sale.DataSource, "ID", true, DataSourceUpdateMode.Never));
            text_saleName.DataBindings.Add(new Binding("Text", dataGridView_Sale.DataSource, "Name", true, DataSourceUpdateMode.Never));
            saleDiscountNum.DataBindings.Add(new Binding("Value", dataGridView_Sale.DataSource, "Discount", true, DataSourceUpdateMode.Never));
        }

        public void ClearSaleBinding()
        {
            text_saleId.DataBindings.Clear();
            text_saleName.DataBindings.Clear();
            saleDiscountNum.DataBindings.Clear();
        }

        private void text_saleId_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_Sale.SelectedCells.Count > 0)
            {
                int index = -1;
                int i = 0;
                string status = (string)dataGridView_Sale.SelectedCells[0].OwningRow.Cells["saleStatus"].Value;
                foreach (string item in cb_saleStatus.Items)
                {
                    if (status.Equals(item))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cb_saleStatus.SelectedIndex = index;
            }
        }

        private void btn_clearSale_Click(object sender, EventArgs e)
        {
            text_saleName.Text = "";
            saleDiscountNum.Value = 0;
        }

        private void text_saleName_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_saleName, "Bạn phải nhập tên chương trình giảm giá.", e);
        }
        // end sale

        // user
        public void loadRolesIntoCb(List<RoleModel> roles)
        {
            Cb_role.DataSource = roles;
        }

        public void loadUsers(List<UserModel> users)
        {
            users = users.OrderBy(r => r.ID).ToList();
            dataGridView_user.DataSource = users;
            string[] array = { "CreatedBy", "ModifiedDate", "ModifiedBy" };
            int colStatus = -1;
            foreach (DataGridViewColumn column in dataGridView_user.Columns)
            {
                if (array.Contains(column.Name))
                    column.Visible = false;
                if (column.Name.Equals("userStatus"))
                {
                    colStatus = column.Index;
                }
            }

            foreach (DataGridViewRow row in dataGridView_user.Rows)
            {
                if (row.Cells[colStatus].Value != null)
                {
                    string value = row.Cells[colStatus].Value.ToString();

                    if (value.Equals("1"))
                        row.Cells[colStatus].Value = "Hoạt động";
                    else
                        row.Cells[colStatus].Value = "Tạm ngưng";
                }
            }
            UserBinding();
            if (Cb_userStatus.Items.Count == 0)
                LoadStatus(Cb_userStatus, "Hoạt động", "Tạm ngưng");
        }

        public void UserBinding()
        {
            text_userId.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "ID", true, DataSourceUpdateMode.Never));
            text_username.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "Username", true, DataSourceUpdateMode.Never));
            text_fullname.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "Fullname", true, DataSourceUpdateMode.Never));
            text_password.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "Password", true, DataSourceUpdateMode.Never));
            text_phone.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "Phone", true, DataSourceUpdateMode.Never));
            text_email.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "Email", true, DataSourceUpdateMode.Never));
            text_address.DataBindings.Add(new Binding("Text", dataGridView_user.DataSource, "Address", true, DataSourceUpdateMode.Never));
            dateTime_dobUser.DataBindings.Add(new Binding("Value", dataGridView_user.DataSource, "Dob", true, DataSourceUpdateMode.Never));
        }

        public void ClearUserBinding()
        {
            text_userId.DataBindings.Clear();
            text_username.DataBindings.Clear();
            text_fullname.DataBindings.Clear();
            text_password.DataBindings.Clear();
            text_phone.DataBindings.Clear();
            text_email.DataBindings.Clear();
            text_address.DataBindings.Clear();
            dateTime_dobUser.DataBindings.Clear();
        }

        private void text_userId_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView_user.SelectedCells.Count > 0)
            {
                RoleModel role = (RoleModel)dataGridView_user.SelectedCells[0].OwningRow.Cells["role"].Value;
                int index = -1;
                int i = 0;
                foreach (RoleModel item in Cb_role.Items)
                {
                    if (role.ID == item.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                Cb_role.SelectedIndex = index;

                i = 0;
                string status = (string)dataGridView_user.SelectedCells[0].OwningRow.Cells["userStatus"].Value;
                foreach (string item in Cb_userStatus.Items)
                {
                    if (status.Equals(item))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                Cb_userStatus.SelectedIndex = index;

                string gender = (string)dataGridView_user.SelectedCells[0].OwningRow.Cells["gender"].Value;
                if (gender.Equals("Nam"))
                {
                    Radio_male.Checked = true;
                    Radio_female.Checked = false;
                }
                else
                {
                    Radio_male.Checked = false;
                    Radio_female.Checked = true;
                }
            }
        }

        private void btn_clearUser_Click(object sender, EventArgs e)
        {
            Text_fullname.Text = "";
            Text_username.Text = "";
            Text_password.Text = "";
            Text_phone.Text = "";
            Text_email.Text = "";
            Text_address.Text = "";
        }

        private void text_fullname_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_fullname, "Bạn phải nhập họ tên.", e);
        }

        private void text_username_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_username, "Bạn phải nhập tên tài khoản.", e);
        }

        private void text_password_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_password, "Bạn phải nhập mật khẩu.", e);
        }

        private void text_address_Validating(object sender, CancelEventArgs e)
        {
            checkErrorEmpty(text_address, "Bạn phải nhập địa chỉ.", e);
        }

        private void text_phone_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(text_phone.Text.Trim()) || !Regex.Match(text_phone.Text, @"^(0[0-9]{9})$").Success)
            {
                e.Cancel = true;
                text_phone.Focus();
                ErrorEmpty.SetError(text_phone, "Bạn phải nhập đúng định dạng số điện thoại (10 số).");
            }
            else
            {
                e.Cancel = false;
                ErrorEmpty.SetError(text_phone, null);
            }
        }

        private void text_email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_email.Text.Trim()) || !text_email.Text.Contains("@") || !text_email.Text.Contains("."))
            {
                e.Cancel = true;
                text_email.Focus();
                ErrorEmpty.SetError(text_email, "Bạn phải nhập đúng định dạng email.");
            }
            else
            {
                e.Cancel = false;
                ErrorEmpty.SetError(text_email, null);
            }
        }
        // end user
    }
}
