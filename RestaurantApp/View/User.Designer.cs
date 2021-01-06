
namespace RestaurantApp.View


{
    using RestaurantApp.Model;
    using System;
    using System.Drawing;
    using System.Windows.Forms;
 
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.cb_indeQuantity = new System.Windows.Forms.ComboBox();
            this.panel_food = new System.Windows.Forms.FlowLayoutPanel();
            this.quantity = new System.Windows.Forms.TextBox();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_foodCategory = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.panel_bill = new System.Windows.Forms.Panel();
            this.cb_sales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.btn_printBill = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_userInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.flPanel_table = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_9 = new RestaurantApp.Model.CircularButton();
            this.btn_8 = new RestaurantApp.Model.CircularButton();
            this.btn_7 = new RestaurantApp.Model.CircularButton();
            this.btn_6 = new RestaurantApp.Model.CircularButton();
            this.btn_5 = new RestaurantApp.Model.CircularButton();
            this.btn_4 = new RestaurantApp.Model.CircularButton();
            this.btn_3 = new RestaurantApp.Model.CircularButton();
            this.btn_2 = new RestaurantApp.Model.CircularButton();
            this.btn_1 = new RestaurantApp.Model.CircularButton();
            this.btn_0 = new RestaurantApp.Model.CircularButton();
            this.panel_menu.SuspendLayout();
            this.panel_bill.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_menu.Controls.Add(this.cb_indeQuantity);
            this.panel_menu.Controls.Add(this.btn_9);
            this.panel_menu.Controls.Add(this.btn_8);
            this.panel_menu.Controls.Add(this.btn_7);
            this.panel_menu.Controls.Add(this.btn_6);
            this.panel_menu.Controls.Add(this.btn_5);
            this.panel_menu.Controls.Add(this.btn_4);
            this.panel_menu.Controls.Add(this.btn_3);
            this.panel_menu.Controls.Add(this.btn_2);
            this.panel_menu.Controls.Add(this.btn_1);
            this.panel_menu.Controls.Add(this.btn_0);
            this.panel_menu.Controls.Add(this.panel_food);
            this.panel_menu.Controls.Add(this.quantity);
            this.panel_menu.Controls.Add(this.cb_categories);
            this.panel_menu.Controls.Add(this.button_clear);
            this.panel_menu.Controls.Add(this.label_foodCategory);
            this.panel_menu.Controls.Add(this.label_quantity);
            this.panel_menu.Location = new System.Drawing.Point(307, 51);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(574, 629);
            this.panel_menu.TabIndex = 0;
            // 
            // cb_indeQuantity
            // 
            this.cb_indeQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_indeQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_indeQuantity.FormattingEnabled = true;
            this.cb_indeQuantity.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cb_indeQuantity.Location = new System.Drawing.Point(396, 88);
            this.cb_indeQuantity.Name = "cb_indeQuantity";
            this.cb_indeQuantity.Size = new System.Drawing.Size(37, 28);
            this.cb_indeQuantity.TabIndex = 24;
            this.cb_indeQuantity.SelectedIndex = 0;
            // 
            // panel_food
            // 
            this.panel_food.AutoScroll = true;
            this.panel_food.Location = new System.Drawing.Point(5, 139);
            this.panel_food.Name = "panel_food";
            this.panel_food.Size = new System.Drawing.Size(562, 483);
            this.panel_food.TabIndex = 14;
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(439, 88);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(71, 27);
            this.quantity.TabIndex = 3;
            // 
            // cb_categories
            // 
            this.cb_categories.BackColor = System.Drawing.Color.White;
            this.cb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categories.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(126, 86);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(159, 31);
            this.cb_categories.Sorted = true;
            this.cb_categories.TabIndex = 2;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(516, 87);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(51, 32);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Xóa";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_foodCategory
            // 
            this.label_foodCategory.AutoSize = true;
            this.label_foodCategory.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_foodCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_foodCategory.Location = new System.Drawing.Point(11, 87);
            this.label_foodCategory.Name = "label_foodCategory";
            this.label_foodCategory.Size = new System.Drawing.Size(115, 25);
            this.label_foodCategory.TabIndex = 0;
            this.label_foodCategory.Text = "Danh mục:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_quantity.Location = new System.Drawing.Point(292, 89);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(103, 25);
            this.label_quantity.TabIndex = 0;
            this.label_quantity.Text = "Số lượng:";
            // 
            // panel_bill
            // 
            this.panel_bill.BackColor = System.Drawing.Color.Transparent;
            this.panel_bill.Controls.Add(this.cb_sales);
            this.panel_bill.Controls.Add(this.label1);
            this.panel_bill.Controls.Add(this.btn_switchTable);
            this.panel_bill.Controls.Add(this.btn_printBill);
            this.panel_bill.Controls.Add(this.btn_pay);
            this.panel_bill.Controls.Add(this.listView1);
            this.panel_bill.Location = new System.Drawing.Point(887, 51);
            this.panel_bill.Name = "panel_bill";
            this.panel_bill.Size = new System.Drawing.Size(441, 629);
            this.panel_bill.TabIndex = 0;
            // 
            // cb_sales
            // 
            this.cb_sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sales.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cb_sales.FormattingEnabled = true;
            this.cb_sales.Location = new System.Drawing.Point(138, 29);
            this.cb_sales.Name = "cb_sales";
            this.cb_sales.Size = new System.Drawing.Size(241, 31);
            this.cb_sales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giảm giá:";
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_switchTable.FlatAppearance.BorderSize = 0;
            this.btn_switchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_switchTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switchTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_switchTable.Location = new System.Drawing.Point(3, 561);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(125, 54);
            this.btn_switchTable.TabIndex = 1;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = false;
            // 
            // btn_printBill
            // 
            this.btn_printBill.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_printBill.FlatAppearance.BorderSize = 0;
            this.btn_printBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printBill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_printBill.Location = new System.Drawing.Point(151, 561);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(143, 54);
            this.btn_printBill.TabIndex = 1;
            this.btn_printBill.Text = "Xuất hóa đơn";
            this.btn_printBill.UseVisualStyleBackColor = false;
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_pay.FlatAppearance.BorderSize = 0;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pay.Location = new System.Drawing.Point(312, 561);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(116, 54);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 453);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1340, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            this.accountMenu.BackColor = System.Drawing.Color.Aquamarine;
            this.accountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_userInformation,
            this.menuResetPassword,
            this.menuItem_logout});
            this.accountMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountMenu.Name = "accountMenu";
            this.accountMenu.Size = new System.Drawing.Size(104, 29);
            this.accountMenu.Text = "Tài khoản";
            // 
            // menuItem_userInformation
            // 
            this.menuItem_userInformation.Name = "menuItem_userInformation";
            this.menuItem_userInformation.Size = new System.Drawing.Size(248, 30);
            this.menuItem_userInformation.Text = "Thông tin tài khoản";
            this.menuItem_userInformation.Click += new System.EventHandler(this.menuItem_userInformation_Click);
            // 
            // menuResetPassword
            // 
            this.menuResetPassword.Name = "menuResetPassword";
            this.menuResetPassword.Size = new System.Drawing.Size(248, 30);
            this.menuResetPassword.Text = "Đổi mật khẩu";
            this.menuResetPassword.Click += new System.EventHandler(this.menuResetPassword_Click);
            // 
            // menuItem_logout
            // 
            this.menuItem_logout.Name = "menuItem_logout";
            this.menuItem_logout.Size = new System.Drawing.Size(248, 30);
            this.menuItem_logout.Text = "Đăng xuất";
            this.menuItem_logout.Click += new System.EventHandler(this.menuItem_logout_Click);
            // 
            // flPanel_table
            // 
            this.flPanel_table.AutoScroll = true;
            this.flPanel_table.BackColor = System.Drawing.Color.Transparent;
            this.flPanel_table.Location = new System.Drawing.Point(9, 51);
            this.flPanel_table.Name = "flPanel_table";
            this.flPanel_table.Size = new System.Drawing.Size(282, 618);
            this.flPanel_table.TabIndex = 2;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.HotPink;
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(511, 20);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(49, 50);
            this.btn_9.TabIndex = 23;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.HotPink;
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(456, 20);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(49, 50);
            this.btn_8.TabIndex = 22;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.HotPink;
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(401, 19);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(49, 50);
            this.btn_7.TabIndex = 21;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.HotPink;
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(346, 20);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(49, 50);
            this.btn_6.TabIndex = 20;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.HotPink;
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(291, 20);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(49, 50);
            this.btn_5.TabIndex = 19;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.HotPink;
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(236, 19);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(49, 50);
            this.btn_4.TabIndex = 18;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.HotPink;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(181, 20);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(49, 50);
            this.btn_3.TabIndex = 17;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.HotPink;
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(126, 20);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(49, 50);
            this.btn_2.TabIndex = 16;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.HotPink;
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(71, 20);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(49, 50);
            this.btn_1.TabIndex = 15;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.HotPink;
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(16, 20);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(49, 50);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::RestaurantApp.Properties.Resources.background_user21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1340, 685);
            this.Controls.Add(this.flPanel_table);
            this.Controls.Add(this.panel_bill);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_bill.ResumeLayout(false);
            this.panel_bill.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        public Panel panel_menu;
        public Panel panel_bill;
        public Label label_quantity;
        public Button button_clear;
        public Button btn_switchTable;
        public Button btn_printBill;
        public Button btn_pay;
        public ListView listView1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem accountMenu;
        public ToolStripMenuItem menuItem_userInformation;
        public ToolStripMenuItem menuItem_logout;
        public ComboBox cb_categories;
        public Label label_foodCategory;
        private ToolStripMenuItem menuResetPassword;
        private TextBox quantity;
        public ComboBox cb_sales;
        public Label label1;
        private FlowLayoutPanel flPanel_table;
        private FlowLayoutPanel panel_food;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularButton btn_0;
        private CircularButton btn_7;
        private CircularButton btn_6;
        private CircularButton btn_5;
        private CircularButton btn_4;
        private CircularButton btn_3;
        private CircularButton btn_2;
        private CircularButton btn_1;
        private CircularButton btn_8;
        private CircularButton btn_9;
        private ComboBox cb_indeQuantity;

        public ToolStripMenuItem AccountMenu { get => accountMenu; set => accountMenu = value; }
        public FlowLayoutPanel FlPanel_table { get => flPanel_table; set => flPanel_table = value; }
        public ComboBox Cb_categories { get => cb_categories; set => cb_categories = value; }
    }
}