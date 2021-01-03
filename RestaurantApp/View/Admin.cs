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

        public void loadUsers(List<UserModel> users)
        {
            var source = new BindingSource();
            source.DataSource = users;
            dataGridView_user.DataSource = source;
            string[] array = { "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };
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
        }

        public void loadTables(List<TableModel> tables)
        {
            var source = new BindingSource();
            source.DataSource = tables;
            dataGridView_table.DataSource = source;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };
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
                    else
                        row.Cells[colStatus].Value = "Còn trống";
                }
            }
        }

        public void loadCategories(List<CategoryModel> categories)
        {
            var source = new BindingSource();
            source.DataSource = categories;
            dataGridView_category.DataSource = source;
            string[] array = { "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };
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
        }

        public void loadFood(List<FoodModel> food)
        {
            var source = new BindingSource();
            source.DataSource = food;
            dataGridView_food.DataSource = source;
            string[] array = { "CreatedDate", "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };
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
        }

        public void loadSales(List<SaleModel> sales)
        {
            var source = new BindingSource();
            source.DataSource = sales;
            dataGridView_Sale.DataSource = source;
            string[] array = { "CreatedBy", "ModifiedDate", "ModifiedBy", "ID" };

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
        }
    }
}
