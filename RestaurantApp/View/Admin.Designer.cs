
using System.Windows.Forms;

namespace RestaurantApp.View
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tpMoney = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.tb_sumsales = new System.Windows.Forms.TextBox();
            this.tb_countorder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_statis = new System.Windows.Forms.Button();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpFoods = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_foodId = new System.Windows.Forms.TextBox();
            this.lb_foodId = new System.Windows.Forms.Label();
            this.food_discount = new System.Windows.Forms.NumericUpDown();
            this.food_price = new System.Windows.Forms.NumericUpDown();
            this.cb_foodCategory = new System.Windows.Forms.ComboBox();
            this.lb_foodCategory = new System.Windows.Forms.Label();
            this.cb_foodStatus = new System.Windows.Forms.ComboBox();
            this.lb_foodStatus = new System.Windows.Forms.Label();
            this.lb_foodDiscount = new System.Windows.Forms.Label();
            this.text_foodName = new System.Windows.Forms.TextBox();
            this.lb_foodName = new System.Windows.Forms.Label();
            this.lb_foodPrice = new System.Windows.Forms.Label();
            this.lb_food = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.btn_deleteFood = new System.Windows.Forms.Button();
            this.btn_updateFood = new System.Windows.Forms.Button();
            this.btn_viewFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_food = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_searchfood = new System.Windows.Forms.Button();
            this.text_searchFood = new System.Windows.Forms.TextBox();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.text_tableId = new System.Windows.Forms.TextBox();
            this.lb_tableId = new System.Windows.Forms.Label();
            this.cb_tableStatus = new System.Windows.Forms.ComboBox();
            this.lb_tableStatus = new System.Windows.Forms.Label();
            this.text_tableName = new System.Windows.Forms.TextBox();
            this.lb_tableName = new System.Windows.Forms.Label();
            this.nud_tableSeats = new System.Windows.Forms.NumericUpDown();
            this.lb_tableSeats = new System.Windows.Forms.Label();
            this.lb_titletable = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_addTable = new System.Windows.Forms.Button();
            this.btn_deleteTable = new System.Windows.Forms.Button();
            this.btn_updateTable = new System.Windows.Forms.Button();
            this.btn_viewTable = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView_table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_searchtable = new System.Windows.Forms.Button();
            this.tb_searchtexttable = new System.Windows.Forms.TextBox();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.text_categoryId = new System.Windows.Forms.TextBox();
            this.lb_categoryId = new System.Windows.Forms.Label();
            this.cb_categoryStatus = new System.Windows.Forms.ComboBox();
            this.lb_categoryStatus = new System.Windows.Forms.Label();
            this.text_categoryCode = new System.Windows.Forms.TextBox();
            this.lb_categoryCode = new System.Windows.Forms.Label();
            this.text_categoryname = new System.Windows.Forms.TextBox();
            this.lb_categoryName = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_deleteCategory = new System.Windows.Forms.Button();
            this.btn_updateCategory = new System.Windows.Forms.Button();
            this.btn_viewCategory = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dataGridView_category = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btn_searchcategory = new System.Windows.Forms.Button();
            this.tb_searchtextcaterory = new System.Windows.Forms.TextBox();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.text_userId = new System.Windows.Forms.TextBox();
            this.lb_userId = new System.Windows.Forms.Label();
            this.cb_userStatus = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.pn_gender = new System.Windows.Forms.Panel();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.text_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.text_address = new System.Windows.Forms.TextBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.text_fullname = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.btn_viewUser = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btn_searchuser = new System.Windows.Forms.Button();
            this.tb_searchtextuser = new System.Windows.Forms.TextBox();
            this.tbSale = new System.Windows.Forms.TabPage();
            this.panel21 = new System.Windows.Forms.Panel();
            this.text_saleId = new System.Windows.Forms.TextBox();
            this.lb_saleId = new System.Windows.Forms.Label();
            this.saleDiscountNum = new System.Windows.Forms.NumericUpDown();
            this.cb_saleStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_saleDiscount = new System.Windows.Forms.Label();
            this.text_saleName = new System.Windows.Forms.TextBox();
            this.lb_saleName = new System.Windows.Forms.Label();
            this.lb_sale = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btn_addSale = new System.Windows.Forms.Button();
            this.btn_deleteSale = new System.Windows.Forms.Button();
            this.btn_updateSale = new System.Windows.Forms.Button();
            this.btn_viewSale = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dataGridView_Sale = new System.Windows.Forms.DataGridView();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btn_SearchSale = new System.Windows.Forms.Button();
            this.text_searchSale = new System.Windows.Forms.TextBox();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_clearFood = new System.Windows.Forms.Button();
            this.btn_clearTable = new System.Windows.Forms.Button();
            this.btn_clearCategory = new System.Windows.Forms.Button();
            this.btn_clearUser = new System.Windows.Forms.Button();
            this.btn_clearSale = new System.Windows.Forms.Button();
            this.tabControlAdmin.SuspendLayout();
            this.tpMoney.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpFoods.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_price)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_food)).BeginInit();
            this.panel3.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tableSeats)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.panel10.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.panel14.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel15.SuspendLayout();
            this.pn_gender.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.panel18.SuspendLayout();
            this.tbSale.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDiscountNum)).BeginInit();
            this.panel22.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sale)).BeginInit();
            this.panel19.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tpMoney);
            this.tabControlAdmin.Controls.Add(this.tpFoods);
            this.tabControlAdmin.Controls.Add(this.tpTable);
            this.tabControlAdmin.Controls.Add(this.tpMenu);
            this.tabControlAdmin.Controls.Add(this.tpAccount);
            this.tabControlAdmin.Controls.Add(this.tbSale);
            this.tabControlAdmin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdmin.Location = new System.Drawing.Point(-3, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1213, 612);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tpMoney
            // 
            this.tpMoney.Controls.Add(this.panel2);
            this.tpMoney.Controls.Add(this.panel1);
            this.tpMoney.Location = new System.Drawing.Point(4, 25);
            this.tpMoney.Name = "tpMoney";
            this.tpMoney.Padding = new System.Windows.Forms.Padding(3);
            this.tpMoney.Size = new System.Drawing.Size(1205, 583);
            this.tpMoney.TabIndex = 0;
            this.tpMoney.Text = "Doanh thu";
            this.tpMoney.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.tb_sumsales);
            this.panel2.Controls.Add(this.tb_countorder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView_order);
            this.panel2.Location = new System.Drawing.Point(6, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 535);
            this.panel2.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_print.Location = new System.Drawing.Point(987, 463);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(177, 57);
            this.btn_print.TabIndex = 4;
            this.btn_print.Text = "In doanh thu";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // tb_sumsales
            // 
            this.tb_sumsales.Location = new System.Drawing.Point(146, 499);
            this.tb_sumsales.Name = "tb_sumsales";
            this.tb_sumsales.ReadOnly = true;
            this.tb_sumsales.Size = new System.Drawing.Size(156, 23);
            this.tb_sumsales.TabIndex = 2;
            // 
            // tb_countorder
            // 
            this.tb_countorder.Location = new System.Drawing.Point(146, 465);
            this.tb_countorder.Name = "tb_countorder";
            this.tb_countorder.ReadOnly = true;
            this.tb_countorder.Size = new System.Drawing.Size(156, 23);
            this.tb_countorder.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng đơn hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu: ";
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.Size = new System.Drawing.Size(1185, 441);
            this.dataGridView_order.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_statis);
            this.panel1.Controls.Add(this.dtp_fromdate);
            this.panel1.Controls.Add(this.dtp_todate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(211, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 33);
            this.panel1.TabIndex = 0;
            // 
            // btn_statis
            // 
            this.btn_statis.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_statis.Location = new System.Drawing.Point(667, -1);
            this.btn_statis.Name = "btn_statis";
            this.btn_statis.Size = new System.Drawing.Size(87, 31);
            this.btn_statis.TabIndex = 4;
            this.btn_statis.Text = "Thống kê";
            this.btn_statis.UseVisualStyleBackColor = false;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_fromdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fromdate.Location = new System.Drawing.Point(103, 3);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(138, 23);
            this.dtp_fromdate.TabIndex = 3;
            // 
            // dtp_todate
            // 
            this.dtp_todate.CustomFormat = "dd/MM/yyyy";
            this.dtp_todate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_todate.Location = new System.Drawing.Point(450, 3);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(138, 23);
            this.dtp_todate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tới ngày: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày: ";
            // 
            // tpFoods
            // 
            this.tpFoods.Controls.Add(this.panel6);
            this.tpFoods.Controls.Add(this.panel5);
            this.tpFoods.Controls.Add(this.panel4);
            this.tpFoods.Controls.Add(this.panel3);
            this.tpFoods.Location = new System.Drawing.Point(4, 25);
            this.tpFoods.Name = "tpFoods";
            this.tpFoods.Padding = new System.Windows.Forms.Padding(3);
            this.tpFoods.Size = new System.Drawing.Size(1205, 583);
            this.tpFoods.TabIndex = 1;
            this.tpFoods.Text = "Món ăn";
            this.tpFoods.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.text_foodId);
            this.panel6.Controls.Add(this.lb_foodId);
            this.panel6.Controls.Add(this.food_discount);
            this.panel6.Controls.Add(this.food_price);
            this.panel6.Controls.Add(this.cb_foodCategory);
            this.panel6.Controls.Add(this.lb_foodCategory);
            this.panel6.Controls.Add(this.cb_foodStatus);
            this.panel6.Controls.Add(this.lb_foodStatus);
            this.panel6.Controls.Add(this.lb_foodDiscount);
            this.panel6.Controls.Add(this.text_foodName);
            this.panel6.Controls.Add(this.lb_foodName);
            this.panel6.Controls.Add(this.lb_foodPrice);
            this.panel6.Controls.Add(this.lb_food);
            this.panel6.Location = new System.Drawing.Point(800, 99);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(375, 302);
            this.panel6.TabIndex = 0;
            // 
            // text_foodId
            // 
            this.text_foodId.Location = new System.Drawing.Point(104, 57);
            this.text_foodId.Name = "text_foodId";
            this.text_foodId.ReadOnly = true;
            this.text_foodId.Size = new System.Drawing.Size(221, 23);
            this.text_foodId.TabIndex = 7;
            // 
            // lb_foodId
            // 
            this.lb_foodId.AutoSize = true;
            this.lb_foodId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodId.Location = new System.Drawing.Point(9, 58);
            this.lb_foodId.Name = "lb_foodId";
            this.lb_foodId.Size = new System.Drawing.Size(31, 18);
            this.lb_foodId.TabIndex = 6;
            this.lb_foodId.Text = "ID:";
            // 
            // food_discount
            // 
            this.food_discount.Location = new System.Drawing.Point(104, 218);
            this.food_discount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.food_discount.Name = "food_discount";
            this.food_discount.Size = new System.Drawing.Size(107, 23);
            this.food_discount.TabIndex = 4;
            // 
            // food_price
            // 
            this.food_price.Location = new System.Drawing.Point(104, 180);
            this.food_price.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.food_price.Name = "food_price";
            this.food_price.Size = new System.Drawing.Size(107, 23);
            this.food_price.TabIndex = 3;
            // 
            // cb_foodCategory
            // 
            this.cb_foodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_foodCategory.FormattingEnabled = true;
            this.cb_foodCategory.Location = new System.Drawing.Point(104, 140);
            this.cb_foodCategory.Name = "cb_foodCategory";
            this.cb_foodCategory.Size = new System.Drawing.Size(221, 24);
            this.cb_foodCategory.TabIndex = 2;
            // 
            // lb_foodCategory
            // 
            this.lb_foodCategory.AutoSize = true;
            this.lb_foodCategory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodCategory.Location = new System.Drawing.Point(9, 141);
            this.lb_foodCategory.Name = "lb_foodCategory";
            this.lb_foodCategory.Size = new System.Drawing.Size(45, 18);
            this.lb_foodCategory.TabIndex = 3;
            this.lb_foodCategory.Text = "Loại:";
            // 
            // cb_foodStatus
            // 
            this.cb_foodStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_foodStatus.FormattingEnabled = true;
            this.cb_foodStatus.Location = new System.Drawing.Point(104, 255);
            this.cb_foodStatus.Name = "cb_foodStatus";
            this.cb_foodStatus.Size = new System.Drawing.Size(221, 24);
            this.cb_foodStatus.TabIndex = 5;
            // 
            // lb_foodStatus
            // 
            this.lb_foodStatus.AutoSize = true;
            this.lb_foodStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodStatus.Location = new System.Drawing.Point(9, 255);
            this.lb_foodStatus.Name = "lb_foodStatus";
            this.lb_foodStatus.Size = new System.Drawing.Size(89, 18);
            this.lb_foodStatus.TabIndex = 0;
            this.lb_foodStatus.Text = "Trạng thái:";
            // 
            // lb_foodDiscount
            // 
            this.lb_foodDiscount.AutoSize = true;
            this.lb_foodDiscount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodDiscount.Location = new System.Drawing.Point(9, 218);
            this.lb_foodDiscount.Name = "lb_foodDiscount";
            this.lb_foodDiscount.Size = new System.Drawing.Size(78, 18);
            this.lb_foodDiscount.TabIndex = 0;
            this.lb_foodDiscount.Text = "Giảm giá:";
            // 
            // text_foodName
            // 
            this.text_foodName.Location = new System.Drawing.Point(104, 99);
            this.text_foodName.Name = "text_foodName";
            this.text_foodName.Size = new System.Drawing.Size(221, 23);
            this.text_foodName.TabIndex = 1;
            this.text_foodName.TextChanged += new System.EventHandler(this.text_foodName_TextChanged);
            // 
            // lb_foodName
            // 
            this.lb_foodName.AutoSize = true;
            this.lb_foodName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodName.Location = new System.Drawing.Point(9, 100);
            this.lb_foodName.Name = "lb_foodName";
            this.lb_foodName.Size = new System.Drawing.Size(40, 18);
            this.lb_foodName.TabIndex = 0;
            this.lb_foodName.Text = "Tên:";
            // 
            // lb_foodPrice
            // 
            this.lb_foodPrice.AutoSize = true;
            this.lb_foodPrice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodPrice.Location = new System.Drawing.Point(9, 180);
            this.lb_foodPrice.Name = "lb_foodPrice";
            this.lb_foodPrice.Size = new System.Drawing.Size(38, 18);
            this.lb_foodPrice.TabIndex = 0;
            this.lb_foodPrice.Text = "Giá:";
            // 
            // lb_food
            // 
            this.lb_food.AutoSize = true;
            this.lb_food.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_food.Location = new System.Drawing.Point(125, 13);
            this.lb_food.Name = "lb_food";
            this.lb_food.Size = new System.Drawing.Size(80, 23);
            this.lb_food.TabIndex = 0;
            this.lb_food.Text = "Món ăn";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_clearFood);
            this.panel5.Controls.Add(this.btn_addFood);
            this.panel5.Controls.Add(this.btn_deleteFood);
            this.panel5.Controls.Add(this.btn_updateFood);
            this.panel5.Controls.Add(this.btn_viewFood);
            this.panel5.Location = new System.Drawing.Point(770, 419);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(417, 127);
            this.panel5.TabIndex = 0;
            // 
            // btn_addFood
            // 
            this.btn_addFood.BackColor = System.Drawing.Color.Green;
            this.btn_addFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addFood.Location = new System.Drawing.Point(6, 19);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(66, 71);
            this.btn_addFood.TabIndex = 6;
            this.btn_addFood.Text = "Thêm";
            this.btn_addFood.UseVisualStyleBackColor = false;
            // 
            // btn_deleteFood
            // 
            this.btn_deleteFood.BackColor = System.Drawing.Color.Red;
            this.btn_deleteFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deleteFood.Location = new System.Drawing.Point(87, 19);
            this.btn_deleteFood.Name = "btn_deleteFood";
            this.btn_deleteFood.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteFood.TabIndex = 7;
            this.btn_deleteFood.Text = "Xoá";
            this.btn_deleteFood.UseVisualStyleBackColor = false;
            // 
            // btn_updateFood
            // 
            this.btn_updateFood.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_updateFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateFood.Location = new System.Drawing.Point(168, 19);
            this.btn_updateFood.Name = "btn_updateFood";
            this.btn_updateFood.Size = new System.Drawing.Size(66, 71);
            this.btn_updateFood.TabIndex = 8;
            this.btn_updateFood.Text = "Sửa";
            this.btn_updateFood.UseVisualStyleBackColor = false;
            // 
            // btn_viewFood
            // 
            this.btn_viewFood.BackColor = System.Drawing.Color.LightCoral;
            this.btn_viewFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewFood.Location = new System.Drawing.Point(253, 19);
            this.btn_viewFood.Name = "btn_viewFood";
            this.btn_viewFood.Size = new System.Drawing.Size(66, 71);
            this.btn_viewFood.TabIndex = 9;
            this.btn_viewFood.Text = "Xem";
            this.btn_viewFood.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView_food);
            this.panel4.Location = new System.Drawing.Point(11, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 507);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView_food
            // 
            this.dataGridView_food.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_food.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.foodName,
            this.foodPrice,
            this.discount,
            this.categoryFood,
            this.foodStatus});
            this.dataGridView_food.Location = new System.Drawing.Point(3, 4);
            this.dataGridView_food.Name = "dataGridView_food";
            this.dataGridView_food.ReadOnly = true;
            this.dataGridView_food.Size = new System.Drawing.Size(733, 500);
            this.dataGridView_food.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // foodName
            // 
            this.foodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodName.DataPropertyName = "Name";
            this.foodName.HeaderText = "Tên";
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            // 
            // foodPrice
            // 
            this.foodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.foodPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.foodPrice.HeaderText = "Giá";
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discount.DataPropertyName = "Discount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.discount.DefaultCellStyle = dataGridViewCellStyle3;
            this.discount.HeaderText = "Giảm giá (%)";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // categoryFood
            // 
            this.categoryFood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryFood.DataPropertyName = "Category";
            this.categoryFood.HeaderText = "Loại";
            this.categoryFood.Name = "categoryFood";
            this.categoryFood.ReadOnly = true;
            // 
            // foodStatus
            // 
            this.foodStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.foodStatus.DataPropertyName = "Status";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.foodStatus.DefaultCellStyle = dataGridViewCellStyle4;
            this.foodStatus.HeaderText = "Trạng thái";
            this.foodStatus.Name = "foodStatus";
            this.foodStatus.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_searchfood);
            this.panel3.Controls.Add(this.text_searchFood);
            this.panel3.Location = new System.Drawing.Point(11, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 34);
            this.panel3.TabIndex = 0;
            // 
            // btn_searchfood
            // 
            this.btn_searchfood.Location = new System.Drawing.Point(325, 4);
            this.btn_searchfood.Name = "btn_searchfood";
            this.btn_searchfood.Size = new System.Drawing.Size(86, 27);
            this.btn_searchfood.TabIndex = 1;
            this.btn_searchfood.Text = "Tìm kiếm";
            this.btn_searchfood.UseVisualStyleBackColor = true;
            // 
            // text_searchFood
            // 
            this.text_searchFood.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchFood.Location = new System.Drawing.Point(3, 3);
            this.text_searchFood.Name = "text_searchFood";
            this.text_searchFood.Size = new System.Drawing.Size(292, 27);
            this.text_searchFood.TabIndex = 0;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel7);
            this.tpTable.Controls.Add(this.panel8);
            this.tpTable.Controls.Add(this.panel9);
            this.tpTable.Controls.Add(this.panel10);
            this.tpTable.Location = new System.Drawing.Point(4, 25);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(1205, 583);
            this.tpTable.TabIndex = 2;
            this.tpTable.Text = "Bàn ăn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.text_tableId);
            this.panel7.Controls.Add(this.lb_tableId);
            this.panel7.Controls.Add(this.cb_tableStatus);
            this.panel7.Controls.Add(this.lb_tableStatus);
            this.panel7.Controls.Add(this.text_tableName);
            this.panel7.Controls.Add(this.lb_tableName);
            this.panel7.Controls.Add(this.nud_tableSeats);
            this.panel7.Controls.Add(this.lb_tableSeats);
            this.panel7.Controls.Add(this.lb_titletable);
            this.panel7.Location = new System.Drawing.Point(779, 120);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(361, 239);
            this.panel7.TabIndex = 1;
            // 
            // text_tableId
            // 
            this.text_tableId.Location = new System.Drawing.Point(114, 65);
            this.text_tableId.Name = "text_tableId";
            this.text_tableId.ReadOnly = true;
            this.text_tableId.Size = new System.Drawing.Size(221, 23);
            this.text_tableId.TabIndex = 10;
            // 
            // lb_tableId
            // 
            this.lb_tableId.AutoSize = true;
            this.lb_tableId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableId.Location = new System.Drawing.Point(19, 66);
            this.lb_tableId.Name = "lb_tableId";
            this.lb_tableId.Size = new System.Drawing.Size(31, 18);
            this.lb_tableId.TabIndex = 9;
            this.lb_tableId.Text = "ID:";
            // 
            // cb_tableStatus
            // 
            this.cb_tableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tableStatus.FormattingEnabled = true;
            this.cb_tableStatus.Location = new System.Drawing.Point(114, 149);
            this.cb_tableStatus.Name = "cb_tableStatus";
            this.cb_tableStatus.Size = new System.Drawing.Size(221, 24);
            this.cb_tableStatus.TabIndex = 8;
            // 
            // lb_tableStatus
            // 
            this.lb_tableStatus.AutoSize = true;
            this.lb_tableStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableStatus.Location = new System.Drawing.Point(19, 150);
            this.lb_tableStatus.Name = "lb_tableStatus";
            this.lb_tableStatus.Size = new System.Drawing.Size(89, 18);
            this.lb_tableStatus.TabIndex = 7;
            this.lb_tableStatus.Text = "Trạng thái:";
            // 
            // text_tableName
            // 
            this.text_tableName.Location = new System.Drawing.Point(114, 108);
            this.text_tableName.Name = "text_tableName";
            this.text_tableName.Size = new System.Drawing.Size(221, 23);
            this.text_tableName.TabIndex = 6;
            // 
            // lb_tableName
            // 
            this.lb_tableName.AutoSize = true;
            this.lb_tableName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableName.Location = new System.Drawing.Point(19, 109);
            this.lb_tableName.Name = "lb_tableName";
            this.lb_tableName.Size = new System.Drawing.Size(40, 18);
            this.lb_tableName.TabIndex = 5;
            this.lb_tableName.Text = "Tên:";
            // 
            // nud_tableSeats
            // 
            this.nud_tableSeats.Location = new System.Drawing.Point(123, 195);
            this.nud_tableSeats.Name = "nud_tableSeats";
            this.nud_tableSeats.Size = new System.Drawing.Size(67, 23);
            this.nud_tableSeats.TabIndex = 3;
            // 
            // lb_tableSeats
            // 
            this.lb_tableSeats.AutoSize = true;
            this.lb_tableSeats.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableSeats.Location = new System.Drawing.Point(19, 195);
            this.lb_tableSeats.Name = "lb_tableSeats";
            this.lb_tableSeats.Size = new System.Drawing.Size(98, 18);
            this.lb_tableSeats.TabIndex = 0;
            this.lb_tableSeats.Text = "Số chỗ ngồi:";
            // 
            // lb_titletable
            // 
            this.lb_titletable.AutoSize = true;
            this.lb_titletable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titletable.Location = new System.Drawing.Point(141, 10);
            this.lb_titletable.Name = "lb_titletable";
            this.lb_titletable.Size = new System.Drawing.Size(75, 23);
            this.lb_titletable.TabIndex = 0;
            this.lb_titletable.Text = "Bàn ăn";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_clearTable);
            this.panel8.Controls.Add(this.btn_addTable);
            this.panel8.Controls.Add(this.btn_deleteTable);
            this.panel8.Controls.Add(this.btn_updateTable);
            this.panel8.Controls.Add(this.btn_viewTable);
            this.panel8.Location = new System.Drawing.Point(743, 378);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(437, 127);
            this.panel8.TabIndex = 2;
            // 
            // btn_addTable
            // 
            this.btn_addTable.BackColor = System.Drawing.Color.Green;
            this.btn_addTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addTable.Location = new System.Drawing.Point(8, 21);
            this.btn_addTable.Name = "btn_addTable";
            this.btn_addTable.Size = new System.Drawing.Size(66, 71);
            this.btn_addTable.TabIndex = 0;
            this.btn_addTable.Text = "Thêm";
            this.btn_addTable.UseVisualStyleBackColor = false;
            // 
            // btn_deleteTable
            // 
            this.btn_deleteTable.BackColor = System.Drawing.Color.Red;
            this.btn_deleteTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteTable.Location = new System.Drawing.Point(89, 21);
            this.btn_deleteTable.Name = "btn_deleteTable";
            this.btn_deleteTable.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteTable.TabIndex = 0;
            this.btn_deleteTable.Text = "Xoá";
            this.btn_deleteTable.UseVisualStyleBackColor = false;
            // 
            // btn_updateTable
            // 
            this.btn_updateTable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_updateTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateTable.Location = new System.Drawing.Point(174, 21);
            this.btn_updateTable.Name = "btn_updateTable";
            this.btn_updateTable.Size = new System.Drawing.Size(66, 71);
            this.btn_updateTable.TabIndex = 0;
            this.btn_updateTable.Text = "Sửa";
            this.btn_updateTable.UseVisualStyleBackColor = false;
            // 
            // btn_viewTable
            // 
            this.btn_viewTable.BackColor = System.Drawing.Color.LightCoral;
            this.btn_viewTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewTable.Location = new System.Drawing.Point(255, 21);
            this.btn_viewTable.Name = "btn_viewTable";
            this.btn_viewTable.Size = new System.Drawing.Size(66, 71);
            this.btn_viewTable.TabIndex = 0;
            this.btn_viewTable.Text = "Xem";
            this.btn_viewTable.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView_table);
            this.panel9.Location = new System.Drawing.Point(14, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(691, 513);
            this.panel9.TabIndex = 3;
            // 
            // dataGridView_table
            // 
            this.dataGridView_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.tableName,
            this.seats,
            this.tableStatus});
            this.dataGridView_table.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.ReadOnly = true;
            this.dataGridView_table.Size = new System.Drawing.Size(685, 507);
            this.dataGridView_table.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tableName
            // 
            this.tableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableName.DataPropertyName = "Name";
            this.tableName.HeaderText = "Tên bàn";
            this.tableName.Name = "tableName";
            this.tableName.ReadOnly = true;
            // 
            // seats
            // 
            this.seats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.seats.DataPropertyName = "Seats";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.seats.DefaultCellStyle = dataGridViewCellStyle6;
            this.seats.HeaderText = "Số chỗ ngồi";
            this.seats.Name = "seats";
            this.seats.ReadOnly = true;
            // 
            // tableStatus
            // 
            this.tableStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableStatus.DataPropertyName = "Status";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tableStatus.DefaultCellStyle = dataGridViewCellStyle7;
            this.tableStatus.HeaderText = "Trạng thái";
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.ReadOnly = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_searchtable);
            this.panel10.Controls.Add(this.tb_searchtexttable);
            this.panel10.Location = new System.Drawing.Point(14, 24);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(424, 34);
            this.panel10.TabIndex = 4;
            // 
            // btn_searchtable
            // 
            this.btn_searchtable.Location = new System.Drawing.Point(325, 4);
            this.btn_searchtable.Name = "btn_searchtable";
            this.btn_searchtable.Size = new System.Drawing.Size(86, 27);
            this.btn_searchtable.TabIndex = 1;
            this.btn_searchtable.Text = "Tìm kiếm";
            this.btn_searchtable.UseVisualStyleBackColor = true;
            // 
            // tb_searchtexttable
            // 
            this.tb_searchtexttable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchtexttable.Location = new System.Drawing.Point(3, 3);
            this.tb_searchtexttable.Name = "tb_searchtexttable";
            this.tb_searchtexttable.Size = new System.Drawing.Size(292, 27);
            this.tb_searchtexttable.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.panel11);
            this.tpMenu.Controls.Add(this.panel12);
            this.tpMenu.Controls.Add(this.panel13);
            this.tpMenu.Controls.Add(this.panel14);
            this.tpMenu.Location = new System.Drawing.Point(4, 25);
            this.tpMenu.Name = "tpMenu";
            this.tpMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpMenu.Size = new System.Drawing.Size(1205, 583);
            this.tpMenu.TabIndex = 3;
            this.tpMenu.Text = "Danh mục";
            this.tpMenu.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.text_categoryId);
            this.panel11.Controls.Add(this.lb_categoryId);
            this.panel11.Controls.Add(this.cb_categoryStatus);
            this.panel11.Controls.Add(this.lb_categoryStatus);
            this.panel11.Controls.Add(this.text_categoryCode);
            this.panel11.Controls.Add(this.lb_categoryCode);
            this.panel11.Controls.Add(this.text_categoryname);
            this.panel11.Controls.Add(this.lb_categoryName);
            this.panel11.Controls.Add(this.label18);
            this.panel11.Location = new System.Drawing.Point(748, 91);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(385, 261);
            this.panel11.TabIndex = 1;
            // 
            // text_categoryId
            // 
            this.text_categoryId.Location = new System.Drawing.Point(125, 94);
            this.text_categoryId.Name = "text_categoryId";
            this.text_categoryId.ReadOnly = true;
            this.text_categoryId.Size = new System.Drawing.Size(221, 23);
            this.text_categoryId.TabIndex = 4;
            // 
            // lb_categoryId
            // 
            this.lb_categoryId.AutoSize = true;
            this.lb_categoryId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryId.Location = new System.Drawing.Point(30, 95);
            this.lb_categoryId.Name = "lb_categoryId";
            this.lb_categoryId.Size = new System.Drawing.Size(31, 18);
            this.lb_categoryId.TabIndex = 3;
            this.lb_categoryId.Text = "ID:";
            // 
            // cb_categoryStatus
            // 
            this.cb_categoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoryStatus.FormattingEnabled = true;
            this.cb_categoryStatus.Location = new System.Drawing.Point(125, 219);
            this.cb_categoryStatus.Name = "cb_categoryStatus";
            this.cb_categoryStatus.Size = new System.Drawing.Size(221, 24);
            this.cb_categoryStatus.TabIndex = 2;
            // 
            // lb_categoryStatus
            // 
            this.lb_categoryStatus.AutoSize = true;
            this.lb_categoryStatus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryStatus.Location = new System.Drawing.Point(30, 220);
            this.lb_categoryStatus.Name = "lb_categoryStatus";
            this.lb_categoryStatus.Size = new System.Drawing.Size(89, 18);
            this.lb_categoryStatus.TabIndex = 0;
            this.lb_categoryStatus.Text = "Trạng thái:";
            // 
            // text_categoryCode
            // 
            this.text_categoryCode.Location = new System.Drawing.Point(125, 179);
            this.text_categoryCode.Name = "text_categoryCode";
            this.text_categoryCode.Size = new System.Drawing.Size(221, 23);
            this.text_categoryCode.TabIndex = 1;
            // 
            // lb_categoryCode
            // 
            this.lb_categoryCode.AutoSize = true;
            this.lb_categoryCode.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryCode.Location = new System.Drawing.Point(30, 179);
            this.lb_categoryCode.Name = "lb_categoryCode";
            this.lb_categoryCode.Size = new System.Drawing.Size(35, 18);
            this.lb_categoryCode.TabIndex = 0;
            this.lb_categoryCode.Text = "Mã:";
            // 
            // text_categoryname
            // 
            this.text_categoryname.Location = new System.Drawing.Point(125, 139);
            this.text_categoryname.Name = "text_categoryname";
            this.text_categoryname.Size = new System.Drawing.Size(221, 23);
            this.text_categoryname.TabIndex = 1;
            // 
            // lb_categoryName
            // 
            this.lb_categoryName.AutoSize = true;
            this.lb_categoryName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryName.Location = new System.Drawing.Point(30, 140);
            this.lb_categoryName.Name = "lb_categoryName";
            this.lb_categoryName.Size = new System.Drawing.Size(40, 18);
            this.lb_categoryName.TabIndex = 0;
            this.lb_categoryName.Text = "Tên:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(121, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 23);
            this.label18.TabIndex = 0;
            this.label18.Text = "Loại món ăn";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btn_clearCategory);
            this.panel12.Controls.Add(this.btn_addCategory);
            this.panel12.Controls.Add(this.btn_deleteCategory);
            this.panel12.Controls.Add(this.btn_updateCategory);
            this.panel12.Controls.Add(this.btn_viewCategory);
            this.panel12.Location = new System.Drawing.Point(731, 376);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(428, 108);
            this.panel12.TabIndex = 2;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.Green;
            this.btn_addCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addCategory.Location = new System.Drawing.Point(12, 19);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_addCategory.TabIndex = 0;
            this.btn_addCategory.Text = "Thêm";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.BackColor = System.Drawing.Color.Red;
            this.btn_deleteCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteCategory.Location = new System.Drawing.Point(93, 19);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteCategory.TabIndex = 0;
            this.btn_deleteCategory.Text = "Xoá";
            this.btn_deleteCategory.UseVisualStyleBackColor = false;
            // 
            // btn_updateCategory
            // 
            this.btn_updateCategory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_updateCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateCategory.Location = new System.Drawing.Point(178, 19);
            this.btn_updateCategory.Name = "btn_updateCategory";
            this.btn_updateCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_updateCategory.TabIndex = 0;
            this.btn_updateCategory.Text = "Sửa";
            this.btn_updateCategory.UseVisualStyleBackColor = false;
            // 
            // btn_viewCategory
            // 
            this.btn_viewCategory.BackColor = System.Drawing.Color.LightCoral;
            this.btn_viewCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewCategory.Location = new System.Drawing.Point(259, 19);
            this.btn_viewCategory.Name = "btn_viewCategory";
            this.btn_viewCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_viewCategory.TabIndex = 0;
            this.btn_viewCategory.Text = "Xem";
            this.btn_viewCategory.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dataGridView_category);
            this.panel13.Location = new System.Drawing.Point(17, 57);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(654, 520);
            this.panel13.TabIndex = 3;
            // 
            // dataGridView_category
            // 
            this.dataGridView_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_category.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_category.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.name,
            this.categoryStatus,
            this.createdDateCategory});
            this.dataGridView_category.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView_category.Location = new System.Drawing.Point(10, 3);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.ReadOnly = true;
            this.dataGridView_category.Size = new System.Drawing.Size(632, 514);
            this.dataGridView_category.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // categoryStatus
            // 
            this.categoryStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryStatus.DataPropertyName = "Status";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoryStatus.DefaultCellStyle = dataGridViewCellStyle9;
            this.categoryStatus.HeaderText = "Trạng thái";
            this.categoryStatus.Name = "categoryStatus";
            this.categoryStatus.ReadOnly = true;
            // 
            // createdDateCategory
            // 
            this.createdDateCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDateCategory.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "dd/MM/yyyy";
            this.createdDateCategory.DefaultCellStyle = dataGridViewCellStyle10;
            this.createdDateCategory.HeaderText = "Ngày tạo";
            this.createdDateCategory.Name = "createdDateCategory";
            this.createdDateCategory.ReadOnly = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btn_searchcategory);
            this.panel14.Controls.Add(this.tb_searchtextcaterory);
            this.panel14.Location = new System.Drawing.Point(17, 17);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(424, 34);
            this.panel14.TabIndex = 4;
            // 
            // btn_searchcategory
            // 
            this.btn_searchcategory.Location = new System.Drawing.Point(325, 4);
            this.btn_searchcategory.Name = "btn_searchcategory";
            this.btn_searchcategory.Size = new System.Drawing.Size(86, 27);
            this.btn_searchcategory.TabIndex = 1;
            this.btn_searchcategory.Text = "Tìm kiếm";
            this.btn_searchcategory.UseVisualStyleBackColor = true;
            // 
            // tb_searchtextcaterory
            // 
            this.tb_searchtextcaterory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchtextcaterory.Location = new System.Drawing.Point(3, 3);
            this.tb_searchtextcaterory.Name = "tb_searchtextcaterory";
            this.tb_searchtextcaterory.Size = new System.Drawing.Size(292, 27);
            this.tb_searchtextcaterory.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel15);
            this.tpAccount.Controls.Add(this.panel16);
            this.tpAccount.Controls.Add(this.panel17);
            this.tpAccount.Controls.Add(this.panel18);
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(1205, 583);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.text_userId);
            this.panel15.Controls.Add(this.lb_userId);
            this.panel15.Controls.Add(this.cb_userStatus);
            this.panel15.Controls.Add(this.lb_status);
            this.panel15.Controls.Add(this.pn_gender);
            this.panel15.Controls.Add(this.text_email);
            this.panel15.Controls.Add(this.lb_email);
            this.panel15.Controls.Add(this.cb_role);
            this.panel15.Controls.Add(this.text_address);
            this.panel15.Controls.Add(this.text_phone);
            this.panel15.Controls.Add(this.lb_role);
            this.panel15.Controls.Add(this.lb_gender);
            this.panel15.Controls.Add(this.lb_address);
            this.panel15.Controls.Add(this.lb_phone);
            this.panel15.Controls.Add(this.text_password);
            this.panel15.Controls.Add(this.lb_password);
            this.panel15.Controls.Add(this.text_fullname);
            this.panel15.Controls.Add(this.text_username);
            this.panel15.Controls.Add(this.lb_fullname);
            this.panel15.Controls.Add(this.lb_username);
            this.panel15.Controls.Add(this.label25);
            this.panel15.Location = new System.Drawing.Point(763, 12);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(358, 445);
            this.panel15.TabIndex = 1;
            // 
            // text_userId
            // 
            this.text_userId.Location = new System.Drawing.Point(121, 39);
            this.text_userId.Name = "text_userId";
            this.text_userId.ReadOnly = true;
            this.text_userId.Size = new System.Drawing.Size(204, 23);
            this.text_userId.TabIndex = 27;
            // 
            // lb_userId
            // 
            this.lb_userId.AutoSize = true;
            this.lb_userId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userId.Location = new System.Drawing.Point(9, 39);
            this.lb_userId.Name = "lb_userId";
            this.lb_userId.Size = new System.Drawing.Size(31, 18);
            this.lb_userId.TabIndex = 26;
            this.lb_userId.Text = "ID:";
            // 
            // cb_userStatus
            // 
            this.cb_userStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userStatus.FormattingEnabled = true;
            this.cb_userStatus.Location = new System.Drawing.Point(121, 409);
            this.cb_userStatus.Name = "cb_userStatus";
            this.cb_userStatus.Size = new System.Drawing.Size(204, 24);
            this.cb_userStatus.TabIndex = 25;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(9, 409);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(89, 18);
            this.lb_status.TabIndex = 24;
            this.lb_status.Text = "Trạng thái:";
            // 
            // pn_gender
            // 
            this.pn_gender.Controls.Add(this.radio_female);
            this.pn_gender.Controls.Add(this.radio_male);
            this.pn_gender.Location = new System.Drawing.Point(121, 320);
            this.pn_gender.Name = "pn_gender";
            this.pn_gender.Size = new System.Drawing.Size(133, 28);
            this.pn_gender.TabIndex = 23;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_female.Location = new System.Drawing.Point(75, 0);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(48, 23);
            this.radio_female.TabIndex = 1;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Nữ";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_male.Location = new System.Drawing.Point(3, 0);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(60, 23);
            this.radio_male.TabIndex = 0;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Nam";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(121, 233);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(204, 23);
            this.text_email.TabIndex = 7;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(9, 234);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 18);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email:";
            // 
            // cb_role
            // 
            this.cb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(121, 365);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(204, 24);
            this.cb_role.TabIndex = 5;
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(121, 278);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(204, 23);
            this.text_address.TabIndex = 1;
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(121, 192);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(204, 23);
            this.text_phone.TabIndex = 1;
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(9, 365);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(63, 18);
            this.lb_role.TabIndex = 0;
            this.lb_role.Text = "Vai trò:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(9, 320);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(76, 18);
            this.lb_gender.TabIndex = 0;
            this.lb_gender.Text = "Giới tính:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(9, 279);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(65, 18);
            this.lb_address.TabIndex = 0;
            this.lb_address.Text = "Địa chỉ:";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(9, 192);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(110, 18);
            this.lb_phone.TabIndex = 0;
            this.lb_phone.Text = "Số điện thoại:";
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(121, 151);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(204, 23);
            this.text_password.TabIndex = 1;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(9, 151);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(81, 18);
            this.lb_password.TabIndex = 0;
            this.lb_password.Text = "Mật khẩu:";
            // 
            // text_fullname
            // 
            this.text_fullname.Location = new System.Drawing.Point(121, 77);
            this.text_fullname.Name = "text_fullname";
            this.text_fullname.Size = new System.Drawing.Size(204, 23);
            this.text_fullname.TabIndex = 1;
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(121, 113);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(204, 23);
            this.text_username.TabIndex = 1;
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(9, 77);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(61, 18);
            this.lb_fullname.TabIndex = 0;
            this.lb_fullname.Text = "Họ tên:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(9, 113);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(85, 18);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tài khoản:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(124, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 23);
            this.label25.TabIndex = 0;
            this.label25.Text = "Tài khoản";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btn_clearUser);
            this.panel16.Controls.Add(this.btn_addUser);
            this.panel16.Controls.Add(this.btn_deleteUser);
            this.panel16.Controls.Add(this.btn_updateUser);
            this.panel16.Controls.Add(this.btn_viewUser);
            this.panel16.Location = new System.Drawing.Point(722, 463);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(437, 101);
            this.panel16.TabIndex = 2;
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.Green;
            this.btn_addUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addUser.Location = new System.Drawing.Point(20, 18);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(66, 71);
            this.btn_addUser.TabIndex = 0;
            this.btn_addUser.Text = "Thêm";
            this.btn_addUser.UseVisualStyleBackColor = false;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.Red;
            this.btn_deleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteUser.Location = new System.Drawing.Point(101, 18);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteUser.TabIndex = 0;
            this.btn_deleteUser.Text = "Xoá";
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_updateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateUser.Location = new System.Drawing.Point(186, 18);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(66, 71);
            this.btn_updateUser.TabIndex = 0;
            this.btn_updateUser.Text = "Sửa";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            // 
            // btn_viewUser
            // 
            this.btn_viewUser.BackColor = System.Drawing.Color.LightCoral;
            this.btn_viewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewUser.Location = new System.Drawing.Point(267, 18);
            this.btn_viewUser.Name = "btn_viewUser";
            this.btn_viewUser.Size = new System.Drawing.Size(66, 71);
            this.btn_viewUser.TabIndex = 0;
            this.btn_viewUser.Text = "Xem";
            this.btn_viewUser.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.dataGridView_user);
            this.panel17.Location = new System.Drawing.Point(7, 48);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(678, 529);
            this.panel17.TabIndex = 3;
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.FullName,
            this.Username,
            this.Password,
            this.phone,
            this.address,
            this.Email,
            this.gender,
            this.userStatus,
            this.role,
            this.dob,
            this.createdDateUser});
            this.dataGridView_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_user.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_user.Size = new System.Drawing.Size(672, 523);
            this.dataGridView_user.TabIndex = 2;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "ID";
            this.UserId.HeaderText = "ID";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 70;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Username.DataPropertyName = "UserName";
            this.Username.HeaderText = "Tài khoản";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 89;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Password.DataPropertyName = "PassWord";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 85;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.phone.DataPropertyName = "Phone";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phone.DefaultCellStyle = dataGridViewCellStyle12;
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 108;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 72;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 64;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gender.DataPropertyName = "Gender";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gender.DefaultCellStyle = dataGridViewCellStyle13;
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 79;
            // 
            // userStatus
            // 
            this.userStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userStatus.DataPropertyName = "Status";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userStatus.DefaultCellStyle = dataGridViewCellStyle14;
            this.userStatus.HeaderText = "Trạng thái";
            this.userStatus.Name = "userStatus";
            this.userStatus.ReadOnly = true;
            this.userStatus.Width = 92;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.role.DataPropertyName = "Role";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.role.DefaultCellStyle = dataGridViewCellStyle15;
            this.role.HeaderText = "Vai trò";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 71;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dob.DataPropertyName = "Dob";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "dd/MM/yyyy";
            this.dob.DefaultCellStyle = dataGridViewCellStyle16;
            this.dob.HeaderText = "Ngày sinh";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 88;
            // 
            // createdDateUser
            // 
            this.createdDateUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.createdDateUser.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "dd/MM/yyyy";
            this.createdDateUser.DefaultCellStyle = dataGridViewCellStyle17;
            this.createdDateUser.HeaderText = "Ngày tạo";
            this.createdDateUser.Name = "createdDateUser";
            this.createdDateUser.ReadOnly = true;
            this.createdDateUser.Width = 83;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btn_searchuser);
            this.panel18.Controls.Add(this.tb_searchtextuser);
            this.panel18.Location = new System.Drawing.Point(8, 8);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(424, 34);
            this.panel18.TabIndex = 4;
            // 
            // btn_searchuser
            // 
            this.btn_searchuser.Location = new System.Drawing.Point(325, 4);
            this.btn_searchuser.Name = "btn_searchuser";
            this.btn_searchuser.Size = new System.Drawing.Size(86, 27);
            this.btn_searchuser.TabIndex = 1;
            this.btn_searchuser.Text = "Tìm kiếm";
            this.btn_searchuser.UseVisualStyleBackColor = true;
            // 
            // tb_searchtextuser
            // 
            this.tb_searchtextuser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_searchtextuser.Location = new System.Drawing.Point(3, 3);
            this.tb_searchtextuser.Name = "tb_searchtextuser";
            this.tb_searchtextuser.Size = new System.Drawing.Size(292, 27);
            this.tb_searchtextuser.TabIndex = 0;
            // 
            // tbSale
            // 
            this.tbSale.Controls.Add(this.panel21);
            this.tbSale.Controls.Add(this.panel22);
            this.tbSale.Controls.Add(this.panel20);
            this.tbSale.Controls.Add(this.panel19);
            this.tbSale.Location = new System.Drawing.Point(4, 25);
            this.tbSale.Name = "tbSale";
            this.tbSale.Padding = new System.Windows.Forms.Padding(3);
            this.tbSale.Size = new System.Drawing.Size(1205, 583);
            this.tbSale.TabIndex = 5;
            this.tbSale.Text = "Chương trình giảm giá";
            this.tbSale.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.text_saleId);
            this.panel21.Controls.Add(this.lb_saleId);
            this.panel21.Controls.Add(this.saleDiscountNum);
            this.panel21.Controls.Add(this.cb_saleStatus);
            this.panel21.Controls.Add(this.label5);
            this.panel21.Controls.Add(this.lb_saleDiscount);
            this.panel21.Controls.Add(this.text_saleName);
            this.panel21.Controls.Add(this.lb_saleName);
            this.panel21.Controls.Add(this.lb_sale);
            this.panel21.Location = new System.Drawing.Point(751, 110);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(385, 247);
            this.panel21.TabIndex = 7;
            // 
            // text_saleId
            // 
            this.text_saleId.Location = new System.Drawing.Point(120, 87);
            this.text_saleId.Name = "text_saleId";
            this.text_saleId.ReadOnly = true;
            this.text_saleId.Size = new System.Drawing.Size(221, 23);
            this.text_saleId.TabIndex = 5;
            // 
            // lb_saleId
            // 
            this.lb_saleId.AutoSize = true;
            this.lb_saleId.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saleId.Location = new System.Drawing.Point(25, 88);
            this.lb_saleId.Name = "lb_saleId";
            this.lb_saleId.Size = new System.Drawing.Size(31, 18);
            this.lb_saleId.TabIndex = 4;
            this.lb_saleId.Text = "ID:";
            // 
            // saleDiscountNum
            // 
            this.saleDiscountNum.Location = new System.Drawing.Point(120, 168);
            this.saleDiscountNum.Name = "saleDiscountNum";
            this.saleDiscountNum.Size = new System.Drawing.Size(120, 23);
            this.saleDiscountNum.TabIndex = 3;
            // 
            // cb_saleStatus
            // 
            this.cb_saleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_saleStatus.FormattingEnabled = true;
            this.cb_saleStatus.Location = new System.Drawing.Point(120, 208);
            this.cb_saleStatus.Name = "cb_saleStatus";
            this.cb_saleStatus.Size = new System.Drawing.Size(221, 24);
            this.cb_saleStatus.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái:";
            // 
            // lb_saleDiscount
            // 
            this.lb_saleDiscount.AutoSize = true;
            this.lb_saleDiscount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saleDiscount.Location = new System.Drawing.Point(25, 168);
            this.lb_saleDiscount.Name = "lb_saleDiscount";
            this.lb_saleDiscount.Size = new System.Drawing.Size(35, 18);
            this.lb_saleDiscount.TabIndex = 0;
            this.lb_saleDiscount.Text = "Mã:";
            // 
            // text_saleName
            // 
            this.text_saleName.Location = new System.Drawing.Point(120, 128);
            this.text_saleName.Name = "text_saleName";
            this.text_saleName.Size = new System.Drawing.Size(221, 23);
            this.text_saleName.TabIndex = 1;
            // 
            // lb_saleName
            // 
            this.lb_saleName.AutoSize = true;
            this.lb_saleName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saleName.Location = new System.Drawing.Point(25, 129);
            this.lb_saleName.Name = "lb_saleName";
            this.lb_saleName.Size = new System.Drawing.Size(40, 18);
            this.lb_saleName.TabIndex = 0;
            this.lb_saleName.Text = "Tên:";
            // 
            // lb_sale
            // 
            this.lb_sale.AutoSize = true;
            this.lb_sale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sale.Location = new System.Drawing.Point(76, 29);
            this.lb_sale.Name = "lb_sale";
            this.lb_sale.Size = new System.Drawing.Size(224, 23);
            this.lb_sale.TabIndex = 0;
            this.lb_sale.Text = "Chương trình giảm giá";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btn_clearSale);
            this.panel22.Controls.Add(this.btn_addSale);
            this.panel22.Controls.Add(this.btn_deleteSale);
            this.panel22.Controls.Add(this.btn_updateSale);
            this.panel22.Controls.Add(this.btn_viewSale);
            this.panel22.Location = new System.Drawing.Point(720, 377);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(444, 113);
            this.panel22.TabIndex = 8;
            // 
            // btn_addSale
            // 
            this.btn_addSale.BackColor = System.Drawing.Color.Green;
            this.btn_addSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addSale.Location = new System.Drawing.Point(20, 19);
            this.btn_addSale.Name = "btn_addSale";
            this.btn_addSale.Size = new System.Drawing.Size(66, 71);
            this.btn_addSale.TabIndex = 0;
            this.btn_addSale.Text = "Thêm";
            this.btn_addSale.UseVisualStyleBackColor = false;
            // 
            // btn_deleteSale
            // 
            this.btn_deleteSale.BackColor = System.Drawing.Color.Red;
            this.btn_deleteSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteSale.Location = new System.Drawing.Point(101, 19);
            this.btn_deleteSale.Name = "btn_deleteSale";
            this.btn_deleteSale.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteSale.TabIndex = 0;
            this.btn_deleteSale.Text = "Xoá";
            this.btn_deleteSale.UseVisualStyleBackColor = false;
            // 
            // btn_updateSale
            // 
            this.btn_updateSale.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_updateSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateSale.Location = new System.Drawing.Point(186, 19);
            this.btn_updateSale.Name = "btn_updateSale";
            this.btn_updateSale.Size = new System.Drawing.Size(66, 71);
            this.btn_updateSale.TabIndex = 0;
            this.btn_updateSale.Text = "Sửa";
            this.btn_updateSale.UseVisualStyleBackColor = false;
            // 
            // btn_viewSale
            // 
            this.btn_viewSale.BackColor = System.Drawing.Color.LightCoral;
            this.btn_viewSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewSale.Location = new System.Drawing.Point(267, 19);
            this.btn_viewSale.Name = "btn_viewSale";
            this.btn_viewSale.Size = new System.Drawing.Size(66, 71);
            this.btn_viewSale.TabIndex = 0;
            this.btn_viewSale.Text = "Xem";
            this.btn_viewSale.UseVisualStyleBackColor = false;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.dataGridView_Sale);
            this.panel20.Location = new System.Drawing.Point(14, 60);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(661, 517);
            this.panel20.TabIndex = 6;
            // 
            // dataGridView_Sale
            // 
            this.dataGridView_Sale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Sale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Sale.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_Sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.saleName,
            this.saleDiscount,
            this.saleStatus,
            this.saleCreatedDate});
            this.dataGridView_Sale.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView_Sale.Location = new System.Drawing.Point(10, 3);
            this.dataGridView_Sale.Name = "dataGridView_Sale";
            this.dataGridView_Sale.ReadOnly = true;
            this.dataGridView_Sale.Size = new System.Drawing.Size(639, 511);
            this.dataGridView_Sale.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btn_SearchSale);
            this.panel19.Controls.Add(this.text_searchSale);
            this.panel19.Location = new System.Drawing.Point(11, 16);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(424, 34);
            this.panel19.TabIndex = 5;
            // 
            // btn_SearchSale
            // 
            this.btn_SearchSale.Location = new System.Drawing.Point(325, 4);
            this.btn_SearchSale.Name = "btn_SearchSale";
            this.btn_SearchSale.Size = new System.Drawing.Size(86, 27);
            this.btn_SearchSale.TabIndex = 1;
            this.btn_SearchSale.Text = "Tìm kiếm";
            this.btn_SearchSale.UseVisualStyleBackColor = true;
            // 
            // text_searchSale
            // 
            this.text_searchSale.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchSale.Location = new System.Drawing.Point(3, 3);
            this.text_searchSale.Name = "text_searchSale";
            this.text_searchSale.Size = new System.Drawing.Size(292, 27);
            this.text_searchSale.TabIndex = 0;
            // 
            // SaleID
            // 
            this.SaleID.DataPropertyName = "ID";
            this.SaleID.HeaderText = "ID";
            this.SaleID.Name = "SaleID";
            this.SaleID.ReadOnly = true;
            // 
            // saleName
            // 
            this.saleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleName.DataPropertyName = "Name";
            this.saleName.HeaderText = "Tên";
            this.saleName.Name = "saleName";
            this.saleName.ReadOnly = true;
            // 
            // saleDiscount
            // 
            this.saleDiscount.DataPropertyName = "Discount";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleDiscount.DefaultCellStyle = dataGridViewCellStyle19;
            this.saleDiscount.HeaderText = "Giảm giá (%)";
            this.saleDiscount.Name = "saleDiscount";
            this.saleDiscount.ReadOnly = true;
            // 
            // saleStatus
            // 
            this.saleStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleStatus.DataPropertyName = "Status";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleStatus.DefaultCellStyle = dataGridViewCellStyle20;
            this.saleStatus.HeaderText = "Trạng thái";
            this.saleStatus.Name = "saleStatus";
            this.saleStatus.ReadOnly = true;
            // 
            // saleCreatedDate
            // 
            this.saleCreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleCreatedDate.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "dd/MM/yyyy";
            this.saleCreatedDate.DefaultCellStyle = dataGridViewCellStyle21;
            this.saleCreatedDate.HeaderText = "Ngày tạo";
            this.saleCreatedDate.Name = "saleCreatedDate";
            this.saleCreatedDate.ReadOnly = true;
            // 
            // btn_clearFood
            // 
            this.btn_clearFood.BackColor = System.Drawing.Color.Tan;
            this.btn_clearFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearFood.Location = new System.Drawing.Point(339, 19);
            this.btn_clearFood.Name = "btn_clearFood";
            this.btn_clearFood.Size = new System.Drawing.Size(66, 71);
            this.btn_clearFood.TabIndex = 10;
            this.btn_clearFood.Text = "Làm mới";
            this.btn_clearFood.UseVisualStyleBackColor = false;
            // 
            // btn_clearTable
            // 
            this.btn_clearTable.BackColor = System.Drawing.Color.Tan;
            this.btn_clearTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearTable.Location = new System.Drawing.Point(341, 21);
            this.btn_clearTable.Name = "btn_clearTable";
            this.btn_clearTable.Size = new System.Drawing.Size(66, 71);
            this.btn_clearTable.TabIndex = 11;
            this.btn_clearTable.Text = "Làm mới";
            this.btn_clearTable.UseVisualStyleBackColor = false;
            // 
            // btn_clearCategory
            // 
            this.btn_clearCategory.BackColor = System.Drawing.Color.Tan;
            this.btn_clearCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearCategory.Location = new System.Drawing.Point(343, 19);
            this.btn_clearCategory.Name = "btn_clearCategory";
            this.btn_clearCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_clearCategory.TabIndex = 12;
            this.btn_clearCategory.Text = "Làm mới";
            this.btn_clearCategory.UseVisualStyleBackColor = false;
            // 
            // btn_clearUser
            // 
            this.btn_clearUser.BackColor = System.Drawing.Color.Tan;
            this.btn_clearUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearUser.Location = new System.Drawing.Point(351, 18);
            this.btn_clearUser.Name = "btn_clearUser";
            this.btn_clearUser.Size = new System.Drawing.Size(66, 71);
            this.btn_clearUser.TabIndex = 12;
            this.btn_clearUser.Text = "Làm mới";
            this.btn_clearUser.UseVisualStyleBackColor = false;
            // 
            // btn_clearSale
            // 
            this.btn_clearSale.BackColor = System.Drawing.Color.Tan;
            this.btn_clearSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearSale.Location = new System.Drawing.Point(350, 19);
            this.btn_clearSale.Name = "btn_clearSale";
            this.btn_clearSale.Size = new System.Drawing.Size(66, 71);
            this.btn_clearSale.TabIndex = 12;
            this.btn_clearSale.Text = "Làm mới";
            this.btn_clearSale.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1215, 624);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.tabControlAdmin.ResumeLayout(false);
            this.tpMoney.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpFoods.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_price)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_food)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpTable.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tableSeats)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tpMenu.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.pn_gender.ResumeLayout(false);
            this.pn_gender.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tbSale.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDiscountNum)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sale)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tpMoney;
        private TabPage tpFoods;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView_order;
        private Panel panel1;
        private TabPage tpTable;
        private TabPage tpMenu;
        private TabPage tpAccount;
        private TextBox tb_sumsales;
        private TextBox tb_countorder;
        private Label label2;
        private DateTimePicker dtp_todate;
        private DateTimePicker dtp_fromdate;
        private Label label3;
        private Label label4;
        private Button btn_statis;
        private Button btn_print;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button btn_searchfood;
        private TextBox text_searchFood;
        private Label lb_foodDiscount;
        private TextBox text_foodName;
        private Label lb_foodName;
        private Label lb_foodPrice;
        private Label lb_food;
        private DataGridView dataGridView_food;
        private ComboBox cb_foodStatus;
        private Label lb_foodStatus;
        private Button btn_viewFood;
        private Button btn_addFood;
        private Button btn_deleteFood;
        private Button btn_updateFood;
        private Panel panel7;
        private NumericUpDown nud_tableSeats;
        private Label lb_tableSeats;
        private Label lb_titletable;
        private Panel panel8;
        private Button btn_addTable;
        private Button btn_deleteTable;
        private Button btn_updateTable;
        private Button btn_viewTable;
        private Panel panel9;
        private DataGridView dataGridView_table;
        private Panel panel10;
        private Button btn_searchtable;
        private TextBox tb_searchtexttable;
        private Panel panel11;
        private ComboBox cb_categoryStatus;
        private Label lb_categoryStatus;
        private TextBox text_categoryname;
        private Label lb_categoryName;
        private Label label18;
        private Panel panel12;
        private Button btn_addCategory;
        private Button btn_deleteCategory;
        private Button btn_updateCategory;
        private Button btn_viewCategory;
        private Panel panel13;
        private DataGridView dataGridView_category;
        private Panel panel14;
        private Button btn_searchcategory;
        private TextBox tb_searchtextcaterory;
        private Panel panel15;
        private TextBox text_phone;
        private Label lb_address;
        private Label lb_phone;
        private TextBox text_password;
        private Label lb_password;
        private TextBox text_fullname;
        private TextBox text_username;
        private Label lb_fullname;
        private Label lb_username;
        private Label label25;
        private Panel panel16;
        private Button btn_addUser;
        private Button btn_deleteUser;
        private Button btn_updateUser;
        private Button btn_viewUser;
        private Panel panel17;
        private DataGridView dataGridView_user;
        private Panel panel18;
        private Button btn_searchuser;
        private TextBox tb_searchtextuser;
        private TextBox text_categoryCode;
        private Label lb_categoryCode;
        private TextBox text_address;
        private Label lb_role;
        private Label lb_gender;
        private ComboBox cb_role;
        private ComboBox cb_foodCategory;
        private Label lb_foodCategory;
        private ComboBox cb_tableStatus;
        private Label lb_tableStatus;
        private TextBox text_tableName;
        private Label lb_tableName;
        private TextBox text_email;
        private Label lb_email;
        private Panel pn_gender;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private ComboBox cb_userStatus;
        private Label lb_status;
        private NumericUpDown food_discount;
        private NumericUpDown food_price;
        private TabPage tbSale;
        private Panel panel21;
        private NumericUpDown saleDiscountNum;
        private ComboBox cb_saleStatus;
        private Label label5;
        private Label lb_saleDiscount;
        private TextBox text_saleName;
        private Label lb_saleName;
        private Label lb_sale;
        private Panel panel22;
        private Button btn_addSale;
        private Button btn_deleteSale;
        private Button btn_updateSale;
        private Button btn_viewSale;
        private Panel panel20;
        private DataGridView dataGridView_Sale;
        private Panel panel19;
        private Button btn_SearchSale;
        private TextBox text_searchSale;
        private TextBox text_foodId;
        private Label lb_foodId;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn foodName;
        private DataGridViewTextBoxColumn foodPrice;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn categoryFood;
        private DataGridViewTextBoxColumn foodStatus;
        private TextBox text_tableId;
        private Label lb_tableId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tableName;
        private DataGridViewTextBoxColumn seats;
        private DataGridViewTextBoxColumn tableStatus;
        private TextBox text_categoryId;
        private Label lb_categoryId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn categoryStatus;
        private DataGridViewTextBoxColumn createdDateCategory;
        private TextBox text_saleId;
        private Label lb_saleId;
        private TextBox text_userId;
        private Label lb_userId;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn userStatus;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn createdDateUser;
        private DataGridViewTextBoxColumn SaleID;
        private DataGridViewTextBoxColumn saleName;
        private DataGridViewTextBoxColumn saleDiscount;
        private DataGridViewTextBoxColumn saleStatus;
        private DataGridViewTextBoxColumn saleCreatedDate;
        private Button btn_clearFood;
        private Button btn_clearTable;
        private Button btn_clearCategory;
        private Button btn_clearUser;
        private Button btn_clearSale;

        public DataGridView DataGridView_Table { get => dataGridView_table; set => dataGridView_table = value; }
        public DataGridView DataGridView_User { get => dataGridView_user; set => dataGridView_user = value; }
        public DataGridView DataGridView_Food { get => dataGridView_food; set => dataGridView_food = value; }
        public DataGridView DataGridView_Category { get => dataGridView_category; set => dataGridView_category = value; }

        public Button Btn_viewTable { get => btn_viewTable; set => btn_viewTable = value; }
        public Button Btn_viewCategory { get => btn_viewCategory; set => btn_viewCategory = value; }
        public Button Btn_viewUser { get => btn_viewUser; set => btn_viewUser = value; }
        public Button Btn_viewFood { get => btn_viewFood; set => btn_viewFood = value; }
        public Button Btn_viewSale { get => btn_viewSale; set => btn_viewSale = value; }

        public Button Btn_addFood { get => btn_addFood; set => btn_addFood = value; }
        public Button Btn_deleteFood { get => btn_deleteFood; set => btn_deleteFood = value; }
        public Button Btn_updateFood { get => btn_updateFood; set => btn_updateFood = value; }
        public Button Btn_addTable { get => btn_addTable; set => btn_addTable = value; }
        public Button Btn_deleteTable { get => btn_deleteTable; set => btn_deleteTable = value; }
        public Button Btn_updateTable { get => btn_updateTable; set => btn_updateTable = value; }
        public Button Btn_addCategory { get => btn_addCategory; set => btn_addCategory = value; }
        public Button Btn_deleteCategory { get => btn_deleteCategory; set => btn_deleteCategory = value; }
        public Button Btn_updateCategory { get => btn_updateCategory; set => btn_updateCategory = value; }
        public Button Btn_addSale { get => btn_addSale; set => btn_addSale = value; }
        public Button Btn_deleteSale { get => btn_deleteSale; set => btn_deleteSale = value; }
        public Button Btn_updateSale { get => btn_updateSale; set => btn_updateSale = value; }
        public Button Btn_addUser { get => btn_addUser; set => btn_addUser = value; }
        public Button Btn_deleteUser { get => btn_deleteUser; set => btn_deleteUser = value; }
        public Button Btn_updateUser { get => btn_updateUser; set => btn_updateUser = value; }

        public TextBox Text_foodId { get => text_foodId; set => text_foodId = value; }
        public TextBox Text_foodName { get => text_foodName; set => text_foodName = value; }
        public ComboBox Cb_foodStatus { get => cb_foodStatus; set => cb_foodStatus = value; }
        public ComboBox Cb_foodCategory { get => cb_foodCategory; set => cb_foodCategory = value; }
        public NumericUpDown Food_discount { get => food_discount; set => food_discount = value; }
        public NumericUpDown Food_price { get => food_price; set => food_price = value; }
    }
}