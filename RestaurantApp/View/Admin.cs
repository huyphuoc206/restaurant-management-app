using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        public void loadUsers(List<UserModel> users)
        {
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
            LoadStatus(cb_userStatus, "Hoạt động", "Tạm ngưng");
        }

        public void loadCategories(List<CategoryModel> categories)
        {
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
            LoadStatus(cb_categoryStatus, "Hoạt động", "Tạm ngưng");
        }

        public void loadCategoriesIntoCb(List<CategoryModel> categories)
        {
            Cb_foodCategory.DataSource = categories;
        }

        public void loadSales(List<SaleModel> sales)
        {
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
            LoadStatus(cb_saleStatus, "Hoạt động", "Tạm ngưng");
        }

        // food
        public void loadFood(List<FoodModel> food)
        {
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
                foreach (CategoryModel item in Cb_foodCategory.Items)
                {
                    if (category.ID == item.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                Cb_foodCategory.SelectedIndex = index;

                i = 0;
                string status = (string)dataGridView_food.SelectedCells[0].OwningRow.Cells["foodStatus"].Value;
                foreach (string item in Cb_foodStatus.Items)
                {
                    if (status.Equals(item))
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                Cb_foodStatus.SelectedIndex = index;
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
                    else if(value.Equals("0"))
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
            Num_tableSeats.DataBindings.Add(new Binding("Value", dataGridView_table.DataSource, "Seats", true, DataSourceUpdateMode.Never));
        }

        public void ClearTableBinding()
        {
            text_tableId.DataBindings.Clear();
            text_tableName.DataBindings.Clear();
            Num_tableSeats.DataBindings.Clear();
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
    }
}
