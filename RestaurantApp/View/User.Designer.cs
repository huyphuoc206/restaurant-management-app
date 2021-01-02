
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
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.label_foodCategory = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Label();
            this.panel_bill = new System.Windows.Forms.Panel();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.btn_printBill = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label_order = new System.Windows.Forms.Label();
            this.panel_table = new System.Windows.Forms.Panel();
            this.label_table = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_userInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_menu.SuspendLayout();
            this.panel_bill.SuspendLayout();
            this.panel_table.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.cb_categories);
            this.panel_menu.Controls.Add(this.button_clear);
            this.panel_menu.Controls.Add(this.quantity);
            this.panel_menu.Controls.Add(this.label_foodCategory);
            this.panel_menu.Controls.Add(this.label_quantity);
            this.panel_menu.Controls.Add(this.label_menu);
            this.panel_menu.Location = new System.Drawing.Point(318, 27);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(627, 709);
            this.panel_menu.TabIndex = 0;
            // 
            // cb_categories
            // 
            this.cb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(303, 22);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(196, 21);
            this.cb_categories.TabIndex = 2;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(409, 102);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 24);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Xóa";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(300, 108);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(0, 13);
            this.quantity.TabIndex = 0;
            // 
            // label_foodCategory
            // 
            this.label_foodCategory.AutoSize = true;
            this.label_foodCategory.Location = new System.Drawing.Point(234, 25);
            this.label_foodCategory.Name = "label_foodCategory";
            this.label_foodCategory.Size = new System.Drawing.Size(59, 13);
            this.label_foodCategory.TabIndex = 0;
            this.label_foodCategory.Text = "Danh mục:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Location = new System.Drawing.Point(234, 108);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(52, 13);
            this.label_quantity.TabIndex = 0;
            this.label_quantity.Text = "Số lượng:";
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Location = new System.Drawing.Point(286, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(34, 13);
            this.label_menu.TabIndex = 0;
            this.label_menu.Text = "Menu";
            // 
            // panel_bill
            // 
            this.panel_bill.Controls.Add(this.btn_switchTable);
            this.panel_bill.Controls.Add(this.btn_printBill);
            this.panel_bill.Controls.Add(this.btn_pay);
            this.panel_bill.Controls.Add(this.listView1);
            this.panel_bill.Controls.Add(this.label_order);
            this.panel_bill.Location = new System.Drawing.Point(951, 27);
            this.panel_bill.Name = "panel_bill";
            this.panel_bill.Size = new System.Drawing.Size(300, 709);
            this.panel_bill.TabIndex = 0;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(3, 571);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(75, 24);
            this.btn_switchTable.TabIndex = 1;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            // 
            // btn_printBill
            // 
            this.btn_printBill.Location = new System.Drawing.Point(106, 571);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(93, 24);
            this.btn_printBill.TabIndex = 1;
            this.btn_printBill.Text = "Xuất hóa đơn";
            this.btn_printBill.UseVisualStyleBackColor = true;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(221, 571);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(76, 24);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 439);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Location = new System.Drawing.Point(120, 0);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(49, 13);
            this.label_order.TabIndex = 0;
            this.label_order.Text = "Hóa đơn";
            // 
            // panel_table
            // 
            this.panel_table.Controls.Add(this.label_table);
            this.panel_table.Location = new System.Drawing.Point(12, 27);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(300, 709);
            this.panel_table.TabIndex = 0;
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Location = new System.Drawing.Point(119, 0);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(26, 13);
            this.label_table.TabIndex = 0;
            this.label_table.Text = "Bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_userInformation,
            this.menuResetPassword,
            this.menuItem_logout});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // menuItem_userInformation
            // 
            this.menuItem_userInformation.Name = "menuItem_userInformation";
            this.menuItem_userInformation.Size = new System.Drawing.Size(180, 22);
            this.menuItem_userInformation.Text = "Thông tin tài khoản";
            this.menuItem_userInformation.Click += new System.EventHandler(this.menuItem_userInformation_Click);
            // 
            // menuResetPassword
            // 
            this.menuResetPassword.Name = "menuResetPassword";
            this.menuResetPassword.Size = new System.Drawing.Size(180, 22);
            this.menuResetPassword.Text = "Đổi mật khẩu";
            this.menuResetPassword.Click += new System.EventHandler(this.menuResetPassword_Click);
            // 
            // menuItem_logout
            // 
            this.menuItem_logout.Name = "menuItem_logout";
            this.menuItem_logout.Size = new System.Drawing.Size(180, 22);
            this.menuItem_logout.Text = "Đăng xuất";
            this.menuItem_logout.Click += new System.EventHandler(this.menuItem_logout_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_bill);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_bill.ResumeLayout(false);
            this.panel_bill.PerformLayout();
            this.panel_table.ResumeLayout(false);
            this.panel_table.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        public Panel panel_menu;
        public Label label_menu;
        public Panel panel_bill;
        public Label label_order;
        public Panel panel_table;
        public Label label_table;
        public Label quantity;
        public Label label_quantity;
        public Button button_clear;
        public Button btn_switchTable;
        public Button btn_printBill;
        public Button btn_pay;
        public ListView listView1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        public ToolStripMenuItem menuItem_userInformation;
        public ToolStripMenuItem menuItem_logout;
        public ComboBox cb_categories;
        public Label label_foodCategory;
        private ToolStripMenuItem menuResetPassword;
    }
}