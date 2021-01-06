using RestaurantApp.Constant;
using RestaurantApp.Controller;
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
    public partial class User : Form
    {

        public User()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            quantity.Text = "";
        }

        public void btns_quantity_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            quantity.Text += btn.Text;
        }

        private void menuItem_userInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountProfileController accountProfile = new AccountProfileController();
            accountProfile.View.StartPosition = FormStartPosition.CenterScreen;
            accountProfile.View.ShowDialog();
            accountMenu.Text = "Nhân viên - " + LoginInfo.Fullname;
            this.Show();
        }

        private void menuItem_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginInfo.UserID = 0;
            LoginInfo.Username = "";
            LoginInfo.Fullname = "";
        }

        private void menuResetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPasswordController resetPassword = new ResetPasswordController();
            resetPassword.View.StartPosition = FormStartPosition.CenterScreen;
            resetPassword.View.ShowDialog();
            this.Show();
        }

        public void loadCategories(List<CategoryModel> categories)
        {
            Cb_categories.Items.AddRange(categories.ToArray());
        }

        public void loadSales(List<SaleModel> salesShow)
        {
            cb_sales.Items.AddRange(salesShow.ToArray());
        }

        public void loadTables(List<TableModel> tables)
        {
            Button[] btns_table = new Button[tables.Count];
            for (int i = 0; i < btns_table.Length; i++)
            {
                if (tables[i].Status.Equals("2")) continue;
                btns_table[i] = new Button() { Width = SystemConstant.TABLE_WIDTH, Height = SystemConstant.TABLE_HEIGHT };
                btns_table[i].TextAlign = ContentAlignment.MiddleCenter;
                btns_table[i].Text = tables[i].Name;
                btns_table[i].Text += "\n" + tables[i].Seats + " chỗ";
                btns_table[i].FlatStyle = FlatStyle.Flat;
                btns_table[i].FlatAppearance.BorderSize = 0;
                if (tables[i].Status.Equals("1"))
                {
                    btns_table[i].Text += "\nCó người";
                    btns_table[i].BackColor = Color.DarkRed;
                    btns_table[i].ForeColor = Color.White;
                }
                else if (tables[i].Status.Equals("0"))
                {
                    btns_table[i].Text += " \nTrống";
                    btns_table[i].BackColor = Color.Gold;
                    btns_table[i].ForeColor = Color.Black;
                }
            }
            flPanel_table.Controls.AddRange(btns_table);
        }

        public void loadFoodByCategory(List<FoodModel> food)
        {
            panel_food.Controls.Clear();
            Button[] btns_food = new Button[food.Count];
            for (int i = 0; i < btns_food.Length; i++)
            {
                btns_food[i] = new Button() { Width = SystemConstant.FOOD_WIDTH, Height = SystemConstant.FOOD_HEIGHT };
                btns_food[i].TextAlign = ContentAlignment.MiddleCenter;
                btns_food[i].Text = food[i].Name;
                btns_food[i].FlatStyle = FlatStyle.Flat;
                btns_food[i].FlatAppearance.BorderSize = 0;
                btns_food[i].BackColor = Color.Turquoise;
                btns_food[i].ForeColor = Color.Black;
            }
            panel_food.Controls.AddRange(btns_food);
        }
    }
}
