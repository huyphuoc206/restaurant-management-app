
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
            this.l_menu = new System.Windows.Forms.Label();
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
            this.panel_bill = new System.Windows.Forms.Panel();
            this.l_bill = new System.Windows.Forms.Label();
            this.cb_sales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_switchTable = new System.Windows.Forms.Button();
            this.btn_printBill = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel_table = new System.Windows.Forms.Panel();
            this.l_seat = new System.Windows.Forms.Label();
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
            this.panel_menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_menu.Controls.Add(this.l_menu);
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
            this.panel_menu.Location = new System.Drawing.Point(386, 48);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(747, 821);
            this.panel_menu.TabIndex = 0;
            // 
            // l_menu
            // 
            this.l_menu.AutoSize = true;
            this.l_menu.Font = new System.Drawing.Font("Algerian", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_menu.ForeColor = System.Drawing.Color.LavenderBlush;
            this.l_menu.Location = new System.Drawing.Point(288, 0);
            this.l_menu.Name = "l_menu";
            this.l_menu.Size = new System.Drawing.Size(221, 81);
            this.l_menu.TabIndex = 15;
            this.l_menu.Text = "Menu";
            // 
            // panel_food
            // 
            this.panel_food.AutoScroll = true;
            this.panel_food.BackColor = System.Drawing.Color.White;
            this.panel_food.Location = new System.Drawing.Point(14, 249);
            this.panel_food.Name = "panel_food";
            this.panel_food.Size = new System.Drawing.Size(719, 556);
            this.panel_food.TabIndex = 14;
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Gold;
            this.btn_9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(602, 103);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(50, 50);
            this.btn_9.TabIndex = 13;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Gold;
            this.btn_1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(161, 103);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(50, 50);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Gold;
            this.btn_2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(216, 103);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(50, 50);
            this.btn_2.TabIndex = 11;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Gold;
            this.btn_3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(271, 103);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(50, 50);
            this.btn_3.TabIndex = 10;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Gold;
            this.btn_4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(326, 103);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(50, 50);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Gold;
            this.btn_5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(382, 103);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(50, 50);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Gold;
            this.btn_6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(437, 103);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(50, 50);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Gold;
            this.btn_7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(492, 103);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(50, 50);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Gold;
            this.btn_8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(547, 103);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(50, 50);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Gold;
            this.btn_0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(106, 103);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(50, 50);
            this.btn_0.TabIndex = 4;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btns_quantity_click);
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.White;
            this.quantity.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(589, 183);
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Size = new System.Drawing.Size(62, 30);
            this.quantity.TabIndex = 3;
            // 
            // cb_categories
            // 
            this.cb_categories.BackColor = System.Drawing.Color.White;
            this.cb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categories.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categories.FormattingEnabled = true;
            this.cb_categories.Location = new System.Drawing.Point(147, 181);
            this.cb_categories.Name = "cb_categories";
            this.cb_categories.Size = new System.Drawing.Size(240, 31);
            this.cb_categories.Sorted = true;
            this.cb_categories.TabIndex = 2;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_clear.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_clear.Location = new System.Drawing.Point(663, 181);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(70, 32);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Xóa";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_foodCategory
            // 
            this.label_foodCategory.AutoSize = true;
            this.label_foodCategory.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_foodCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_foodCategory.Location = new System.Drawing.Point(13, 181);
            this.label_foodCategory.Name = "label_foodCategory";
            this.label_foodCategory.Size = new System.Drawing.Size(128, 29);
            this.label_foodCategory.TabIndex = 0;
            this.label_foodCategory.Text = "Danh mục:";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_quantity.Location = new System.Drawing.Point(468, 183);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(115, 29);
            this.label_quantity.TabIndex = 0;
            this.label_quantity.Text = "Số lượng:";
            // 
            // panel_bill
            // 
            this.panel_bill.BackColor = System.Drawing.Color.Transparent;
            this.panel_bill.Controls.Add(this.l_bill);
            this.panel_bill.Controls.Add(this.cb_sales);
            this.panel_bill.Controls.Add(this.label1);
            this.panel_bill.Controls.Add(this.btn_switchTable);
            this.panel_bill.Controls.Add(this.btn_printBill);
            this.panel_bill.Controls.Add(this.btn_pay);
            this.panel_bill.Controls.Add(this.listView1);
            this.panel_bill.Location = new System.Drawing.Point(1139, 48);
            this.panel_bill.Name = "panel_bill";
            this.panel_bill.Size = new System.Drawing.Size(453, 821);
            this.panel_bill.TabIndex = 0;
            // 
            // l_bill
            // 
            this.l_bill.AutoSize = true;
            this.l_bill.Font = new System.Drawing.Font("Algerian", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_bill.ForeColor = System.Drawing.Color.LavenderBlush;
            this.l_bill.Location = new System.Drawing.Point(138, 0);
            this.l_bill.Name = "l_bill";
            this.l_bill.Size = new System.Drawing.Size(184, 81);
            this.l_bill.TabIndex = 5;
            this.l_bill.Text = "Bill";
            // 
            // cb_sales
            // 
            this.cb_sales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sales.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sales.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cb_sales.FormattingEnabled = true;
            this.cb_sales.Location = new System.Drawing.Point(175, 113);
            this.cb_sales.Name = "cb_sales";
            this.cb_sales.Size = new System.Drawing.Size(264, 31);
            this.cb_sales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giảm giá:";
            // 
            // btn_switchTable
            // 
            this.btn_switchTable.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_switchTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switchTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_switchTable.Location = new System.Drawing.Point(14, 728);
            this.btn_switchTable.Name = "btn_switchTable";
            this.btn_switchTable.Size = new System.Drawing.Size(125, 54);
            this.btn_switchTable.TabIndex = 1;
            this.btn_switchTable.Text = "Chuyển bàn";
            this.btn_switchTable.UseVisualStyleBackColor = false;
            // 
            // btn_printBill
            // 
            this.btn_printBill.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_printBill.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_printBill.Location = new System.Drawing.Point(162, 728);
            this.btn_printBill.Name = "btn_printBill";
            this.btn_printBill.Size = new System.Drawing.Size(143, 54);
            this.btn_printBill.TabIndex = 1;
            this.btn_printBill.Text = "Xuất hóa đơn";
            this.btn_printBill.UseVisualStyleBackColor = false;
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_pay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pay.Location = new System.Drawing.Point(323, 728);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(116, 54);
            this.btn_pay.TabIndex = 1;
            this.btn_pay.Text = "Thanh toán";
            this.btn_pay.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 181);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(425, 510);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel_table
            // 
            this.panel_table.AutoScroll = true;
            this.panel_table.BackColor = System.Drawing.Color.Transparent;
            this.panel_table.Controls.Add(this.l_seat);
            this.panel_table.Location = new System.Drawing.Point(12, 48);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(368, 821);
            this.panel_table.TabIndex = 0;
            // 
            // l_seat
            // 
            this.l_seat.AutoSize = true;
            this.l_seat.Font = new System.Drawing.Font("Algerian", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_seat.ForeColor = System.Drawing.Color.LavenderBlush;
            this.l_seat.Location = new System.Drawing.Point(105, 0);
            this.l_seat.Name = "l_seat";
            this.l_seat.Size = new System.Drawing.Size(217, 81);
            this.l_seat.TabIndex = 0;
            this.l_seat.Text = "SEAT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1604, 33);
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
            this.BackgroundImage = global::RestaurantApp.Properties.Resources.background_user21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_bill);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.User_Load);
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
        public Panel panel_bill;
        public Panel panel_table;
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
        public ComboBox cb_sales;
        public Label label1;
        private Label l_menu;
        private Label l_bill;
        private Label l_seat;

        public ToolStripMenuItem AccountMenu { get => accountMenu; set => accountMenu = value; }
    }
}