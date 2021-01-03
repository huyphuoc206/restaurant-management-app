
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
            this.panel_food = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.cb_categories = new System.Windows.Forms.ComboBox();
            this.button_clear = new System.Windows.Forms.Button();
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
            this.accountMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel_menu.Controls.Add(this.panel_food);
            this.panel_menu.Controls.Add(this.btn_9);
            this.panel_menu.Controls.Add(this.btn_1);
            this.panel_menu.Controls.Add(this.btn_2);
            this.panel_menu.Controls.Add(this.btn_3);
            this.panel_menu.Controls.Add(this.btn_4);
            this.panel_menu.Controls.Add(this.btn_5);
            this.panel_menu.Controls.Add(this.btn_6);
            this.panel_menu.Controls.Add(this.btn_7);
            this.panel_menu.Controls.Add(this.btn_8);
            this.panel_menu.Controls.Add(this.btn_0);
            this.panel_menu.Controls.Add(this.quantity);
            this.panel_menu.Controls.Add(this.cb_categories);
            this.panel_menu.Controls.Add(this.button_clear);
            this.panel_menu.Controls.Add(this.label_foodCategory);
            this.panel_menu.Controls.Add(this.label_quantity);
            this.panel_menu.Controls.Add(this.label_menu);
            this.panel_menu.Location = new System.Drawing.Point(300, 48);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(627, 553);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_food
            // 
            this.panel_food.AutoScroll = true;
            this.panel_food.Location = new System.Drawing.Point(14, 175);
            this.panel_food.Name = "panel_food";
            this.panel_food.Size = new System.Drawing.Size(597, 347);
            this.panel_food.TabIndex = 14;
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(537, 75);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(49, 39);
            this.btn_9.TabIndex = 13;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(96, 75);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(49, 39);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(151, 75);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(49, 39);
            this.btn_2.TabIndex = 11;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(206, 75);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(49, 39);
            this.btn_3.TabIndex = 10;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(261, 75);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(49, 39);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(317, 75);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(49, 39);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(372, 75);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(49, 39);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(427, 75);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(49, 39);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(482, 75);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(49, 39);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(41, 75);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(49, 39);
            this.btn_0.TabIndex = 4;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(244, 135);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(140, 20);
            this.quantity.TabIndex = 3;
            // 
            // cb_categories
            // 
            this.cb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(244, 36);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(196, 21);
            this.cb_categories.TabIndex = 2;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(410, 131);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 24);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Xóa";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_foodCategory
            // 
            this.label_foodCategory.AutoSize = true;
            this.label_foodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_foodCategory.Location = new System.Drawing.Point(136, 33);
            this.label_foodCategory.Name = "label_foodCategory";
            this.label_foodCategory.Size = new System.Drawing.Size(102, 24);
            this.label_foodCategory.TabIndex = 0;
            this.label_foodCategory.Text = "Danh mục:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(136, 131);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(91, 24);
            this.label_quantity.TabIndex = 0;
            this.label_quantity.Text = "Số lượng:";
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.Location = new System.Drawing.Point(256, -3);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(66, 25);
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
            this.panel_bill.Location = new System.Drawing.Point(933, 48);
            this.panel_bill.Name = "panel_bill";
            this.panel_bill.Size = new System.Drawing.Size(300, 553);
            this.panel_bill.TabIndex = 0;
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.Location = new System.Drawing.Point(3, 499);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(75, 24);
            this.btn_switchTable.TabIndex = 1;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = true;
            // 
            // btn_printBill
            // 
            this.btn_printBill.Location = new System.Drawing.Point(103, 499);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(93, 24);
            this.btn_printBill.TabIndex = 1;
            this.btn_printBill.Text = "Xuất hóa đơn";
            this.btn_printBill.UseVisualStyleBackColor = true;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(218, 499);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(76, 24);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 439);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_order.Location = new System.Drawing.Point(103, 0);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(93, 25);
            this.label_order.TabIndex = 0;
            this.label_order.Text = "Hóa đơn";
            // 
            // panel_table
            // 
            this.panel_table.AutoScroll = true;
            this.panel_table.Controls.Add(this.label_table);
            this.panel_table.Location = new System.Drawing.Point(12, 48);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(273, 553);
            this.panel_table.TabIndex = 0;
            // 
            // label_table
            // 
            this.label_table.AutoSize = true;
            this.label_table.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table.Location = new System.Drawing.Point(110, 0);
            this.label_table.Name = "label_table";
            this.label_table.Size = new System.Drawing.Size(50, 25);
            this.label_table.TabIndex = 0;
            this.label_table.Text = "Bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            this.accountMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1244, 622);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_bill);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
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
        private Button btn_9;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_0;
        private FlowLayoutPanel panel_food;

        public ToolStripMenuItem AccountMenu { get => accountMenu; set => accountMenu = value; }
    }
}