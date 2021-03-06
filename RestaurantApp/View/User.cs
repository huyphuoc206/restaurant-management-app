﻿using RestaurantApp.Constant;
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
            /*cb_categories.Items.AddRange(categories.ToArray());*/
            cb_categories.DataSource = categories;
            cb_categories.DisplayMember = "Name";
        }

        public void loadTableToSwitch(List<TableModel> tables)
        {
            cb_switchTable.DataSource = tables;
            cb_switchTable.DisplayMember = "Name";
        }

        public void loadSales(List<SaleModel> salesShow)
        {
            cb_sales.Items.AddRange(salesShow.ToArray());
        }

        public void loadTables(Button[] buttonsTables)
        {
            flPanel_table.Controls.Clear();
            flPanel_table.Controls.AddRange(buttonsTables);
        }

        public void loadFoodByCategory(Button[] buttonsFood)
        {
            panel_food.Controls.Clear();          
            panel_food.Controls.AddRange(buttonsFood);
        }

        public void clearOrder()
        {
            list_orderDetails.Items.Clear();
            Text_totalPrice.Text = "";
        }
    }
}
