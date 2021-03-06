﻿
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace RestaurantApp.View
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private CultureInfo culture = new CultureInfo("vi-VN");

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
            Thread.CurrentThread.CurrentCulture = culture;
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tpMoney = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_print = new System.Windows.Forms.Button();
            this.text_totalMoney = new System.Windows.Forms.TextBox();
            this.text_countOrder = new System.Windows.Forms.TextBox();
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
            this.panel_food = new System.Windows.Forms.Panel();
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
            this.btn_clearFood = new System.Windows.Forms.Button();
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
            this.panel_table = new System.Windows.Forms.Panel();
            this.text_tableId = new System.Windows.Forms.TextBox();
            this.lb_tableId = new System.Windows.Forms.Label();
            this.cb_tableStatus = new System.Windows.Forms.ComboBox();
            this.lb_tableStatus = new System.Windows.Forms.Label();
            this.text_tableName = new System.Windows.Forms.TextBox();
            this.lb_tableName = new System.Windows.Forms.Label();
            this.num_tableSeats = new System.Windows.Forms.NumericUpDown();
            this.lb_tableSeats = new System.Windows.Forms.Label();
            this.lb_titletable = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_clearTable = new System.Windows.Forms.Button();
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
            this.text_searchTable = new System.Windows.Forms.TextBox();
            this.tpMenu = new System.Windows.Forms.TabPage();
            this.panel_category = new System.Windows.Forms.Panel();
            this.text_categoryId = new System.Windows.Forms.TextBox();
            this.lb_categoryId = new System.Windows.Forms.Label();
            this.cb_categoryStatus = new System.Windows.Forms.ComboBox();
            this.lb_categoryStatus = new System.Windows.Forms.Label();
            this.text_categoryname = new System.Windows.Forms.TextBox();
            this.lb_categoryName = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_clearCategory = new System.Windows.Forms.Button();
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
            this.text_searchCategory = new System.Windows.Forms.TextBox();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel_user = new System.Windows.Forms.Panel();
            this.lb_dob = new System.Windows.Forms.Label();
            this.dateTime_dobUser = new System.Windows.Forms.DateTimePicker();
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
            this.btn_clearUser = new System.Windows.Forms.Button();
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
            this.text_searchUser = new System.Windows.Forms.TextBox();
            this.tbSale = new System.Windows.Forms.TabPage();
            this.panel_sale = new System.Windows.Forms.Panel();
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
            this.btn_clearSale = new System.Windows.Forms.Button();
            this.btn_addSale = new System.Windows.Forms.Button();
            this.btn_deleteSale = new System.Windows.Forms.Button();
            this.btn_updateSale = new System.Windows.Forms.Button();
            this.btn_viewSale = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dataGridView_Sale = new System.Windows.Forms.DataGridView();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btn_SearchSale = new System.Windows.Forms.Button();
            this.text_searchSale = new System.Windows.Forms.TextBox();
            this.errorEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipPrint = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddFood = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdateFood = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeleteFood = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipViewFood = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddTable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdateTable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeleteTable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipViewTable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddCategory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdateCategory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeleteCategory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipViewCategory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdateUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeleteUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipViewUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddSale = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUpdateSale = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDeleteSale = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipViewSale = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_userInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAdmin.SuspendLayout();
            this.tpMoney.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpFoods.SuspendLayout();
            this.panel_food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_price)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_food)).BeginInit();
            this.panel3.SuspendLayout();
            this.tpTable.SuspendLayout();
            this.panel_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tableSeats)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).BeginInit();
            this.panel10.SuspendLayout();
            this.tpMenu.SuspendLayout();
            this.panel_category.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.panel14.SuspendLayout();
            this.tpAccount.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.pn_gender.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            this.panel18.SuspendLayout();
            this.tbSale.SuspendLayout();
            this.panel_sale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDiscountNum)).BeginInit();
            this.panel22.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sale)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 46);
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
            this.panel2.Controls.Add(this.text_totalMoney);
            this.panel2.Controls.Add(this.text_countOrder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView_order);
            this.panel2.Location = new System.Drawing.Point(6, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 512);
            this.panel2.TabIndex = 1;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.BackgroundImage = global::RestaurantApp.Properties.Resources.print1;
            this.btn_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_print.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(1078, 436);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(76, 69);
            this.btn_print.TabIndex = 4;
            this.toolTipPrint.SetToolTip(this.btn_print, "In doanh thu");
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // text_totalMoney
            // 
            this.text_totalMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_totalMoney.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_totalMoney.Location = new System.Drawing.Point(304, 481);
            this.text_totalMoney.Name = "text_totalMoney";
            this.text_totalMoney.ReadOnly = true;
            this.text_totalMoney.Size = new System.Drawing.Size(152, 27);
            this.text_totalMoney.TabIndex = 2;
            this.text_totalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_countOrder
            // 
            this.text_countOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_countOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_countOrder.Location = new System.Drawing.Point(304, 445);
            this.text_countOrder.Name = "text_countOrder";
            this.text_countOrder.ReadOnly = true;
            this.text_countOrder.Size = new System.Drawing.Size(152, 27);
            this.text_countOrder.TabIndex = 2;
            this.text_countOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng đơn hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu: ";
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_order.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.orderTable,
            this.saleOrder,
            this.totalPriceOrder,
            this.checkin,
            this.checkout,
            this.createdByOrder});
            this.dataGridView_order.Location = new System.Drawing.Point(4, 3);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.ReadOnly = true;
            this.dataGridView_order.Size = new System.Drawing.Size(1185, 427);
            this.dataGridView_order.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_statis);
            this.panel1.Controls.Add(this.dtp_fromdate);
            this.panel1.Controls.Add(this.dtp_todate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(54, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 53);
            this.panel1.TabIndex = 0;
            // 
            // btn_statis
            // 
            this.btn_statis.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_statis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_statis.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_statis.Location = new System.Drawing.Point(921, 5);
            this.btn_statis.Name = "btn_statis";
            this.btn_statis.Size = new System.Drawing.Size(132, 41);
            this.btn_statis.TabIndex = 4;
            this.btn_statis.Text = "Thống kê";
            this.btn_statis.UseVisualStyleBackColor = false;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_fromdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fromdate.Location = new System.Drawing.Point(133, 12);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(166, 27);
            this.dtp_fromdate.TabIndex = 3;
            // 
            // dtp_todate
            // 
            this.dtp_todate.CustomFormat = "dd/MM/yyyy";
            this.dtp_todate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_todate.Location = new System.Drawing.Point(667, 12);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(168, 27);
            this.dtp_todate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tới ngày: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày: ";
            // 
            // tpFoods
            // 
            this.tpFoods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tpFoods.Controls.Add(this.panel_food);
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
            // panel_food
            // 
            this.panel_food.Controls.Add(this.text_foodId);
            this.panel_food.Controls.Add(this.lb_foodId);
            this.panel_food.Controls.Add(this.food_discount);
            this.panel_food.Controls.Add(this.food_price);
            this.panel_food.Controls.Add(this.cb_foodCategory);
            this.panel_food.Controls.Add(this.lb_foodCategory);
            this.panel_food.Controls.Add(this.cb_foodStatus);
            this.panel_food.Controls.Add(this.lb_foodStatus);
            this.panel_food.Controls.Add(this.lb_foodDiscount);
            this.panel_food.Controls.Add(this.text_foodName);
            this.panel_food.Controls.Add(this.lb_foodName);
            this.panel_food.Controls.Add(this.lb_foodPrice);
            this.panel_food.Controls.Add(this.lb_food);
            this.panel_food.Location = new System.Drawing.Point(770, 70);
            this.panel_food.Name = "panel_food";
            this.panel_food.Size = new System.Drawing.Size(417, 331);
            this.panel_food.TabIndex = 0;
            // 
            // text_foodId
            // 
            this.text_foodId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_foodId.Location = new System.Drawing.Point(166, 36);
            this.text_foodId.Name = "text_foodId";
            this.text_foodId.ReadOnly = true;
            this.text_foodId.Size = new System.Drawing.Size(221, 27);
            this.text_foodId.TabIndex = 11;
            this.text_foodId.TextChanged += new System.EventHandler(this.text_foodId_TextChanged);
            // 
            // lb_foodId
            // 
            this.lb_foodId.AutoSize = true;
            this.lb_foodId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodId.Location = new System.Drawing.Point(15, 39);
            this.lb_foodId.Name = "lb_foodId";
            this.lb_foodId.Size = new System.Drawing.Size(40, 23);
            this.lb_foodId.TabIndex = 6;
            this.lb_foodId.Text = "ID:";
            // 
            // food_discount
            // 
            this.food_discount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_discount.Location = new System.Drawing.Point(280, 233);
            this.food_discount.Name = "food_discount";
            this.food_discount.Size = new System.Drawing.Size(107, 27);
            this.food_discount.TabIndex = 4;
            // 
            // food_price
            // 
            this.food_price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.food_price.Location = new System.Drawing.Point(280, 181);
            this.food_price.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.food_price.Name = "food_price";
            this.food_price.Size = new System.Drawing.Size(107, 27);
            this.food_price.TabIndex = 3;
            // 
            // cb_foodCategory
            // 
            this.cb_foodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_foodCategory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_foodCategory.FormattingEnabled = true;
            this.cb_foodCategory.Location = new System.Drawing.Point(168, 132);
            this.cb_foodCategory.Name = "cb_foodCategory";
            this.cb_foodCategory.Size = new System.Drawing.Size(219, 27);
            this.cb_foodCategory.TabIndex = 2;
            // 
            // lb_foodCategory
            // 
            this.lb_foodCategory.AutoSize = true;
            this.lb_foodCategory.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodCategory.Location = new System.Drawing.Point(15, 135);
            this.lb_foodCategory.Name = "lb_foodCategory";
            this.lb_foodCategory.Size = new System.Drawing.Size(57, 23);
            this.lb_foodCategory.TabIndex = 3;
            this.lb_foodCategory.Text = "Loại:";
            // 
            // cb_foodStatus
            // 
            this.cb_foodStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_foodStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_foodStatus.FormattingEnabled = true;
            this.cb_foodStatus.Location = new System.Drawing.Point(168, 278);
            this.cb_foodStatus.Name = "cb_foodStatus";
            this.cb_foodStatus.Size = new System.Drawing.Size(221, 27);
            this.cb_foodStatus.TabIndex = 5;
            // 
            // lb_foodStatus
            // 
            this.lb_foodStatus.AutoSize = true;
            this.lb_foodStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodStatus.Location = new System.Drawing.Point(15, 278);
            this.lb_foodStatus.Name = "lb_foodStatus";
            this.lb_foodStatus.Size = new System.Drawing.Size(115, 23);
            this.lb_foodStatus.TabIndex = 0;
            this.lb_foodStatus.Text = "Trạng thái:";
            // 
            // lb_foodDiscount
            // 
            this.lb_foodDiscount.AutoSize = true;
            this.lb_foodDiscount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodDiscount.Location = new System.Drawing.Point(15, 232);
            this.lb_foodDiscount.Name = "lb_foodDiscount";
            this.lb_foodDiscount.Size = new System.Drawing.Size(101, 23);
            this.lb_foodDiscount.TabIndex = 0;
            this.lb_foodDiscount.Text = "Giảm giá:";
            // 
            // text_foodName
            // 
            this.text_foodName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_foodName.Location = new System.Drawing.Point(166, 87);
            this.text_foodName.Name = "text_foodName";
            this.text_foodName.Size = new System.Drawing.Size(221, 27);
            this.text_foodName.TabIndex = 1;
            this.text_foodName.Validating += new System.ComponentModel.CancelEventHandler(this.text_foodName_Validating);
            // 
            // lb_foodName
            // 
            this.lb_foodName.AutoSize = true;
            this.lb_foodName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodName.Location = new System.Drawing.Point(15, 90);
            this.lb_foodName.Name = "lb_foodName";
            this.lb_foodName.Size = new System.Drawing.Size(52, 23);
            this.lb_foodName.TabIndex = 0;
            this.lb_foodName.Text = "Tên:";
            // 
            // lb_foodPrice
            // 
            this.lb_foodPrice.AutoSize = true;
            this.lb_foodPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodPrice.Location = new System.Drawing.Point(15, 184);
            this.lb_foodPrice.Name = "lb_foodPrice";
            this.lb_foodPrice.Size = new System.Drawing.Size(48, 23);
            this.lb_foodPrice.TabIndex = 0;
            this.lb_foodPrice.Text = "Giá:";
            // 
            // lb_food
            // 
            this.lb_food.AutoSize = true;
            this.lb_food.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_food.Location = new System.Drawing.Point(174, 4);
            this.lb_food.Name = "lb_food";
            this.lb_food.Size = new System.Drawing.Size(89, 25);
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
            this.panel5.Location = new System.Drawing.Point(770, 425);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(417, 127);
            this.panel5.TabIndex = 0;
            // 
            // btn_clearFood
            // 
            this.btn_clearFood.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearFood.BackgroundImage = global::RestaurantApp.Properties.Resources.update_icon;
            this.btn_clearFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clearFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearFood.Location = new System.Drawing.Point(339, 19);
            this.btn_clearFood.Name = "btn_clearFood";
            this.btn_clearFood.Size = new System.Drawing.Size(66, 71);
            this.btn_clearFood.TabIndex = 10;
            this.toolTipClear.SetToolTip(this.btn_clearFood, "Làm mới");
            this.btn_clearFood.UseVisualStyleBackColor = false;
            this.btn_clearFood.Click += new System.EventHandler(this.btn_clearFood_Click);
            // 
            // btn_addFood
            // 
            this.btn_addFood.BackColor = System.Drawing.Color.Transparent;
            this.btn_addFood.BackgroundImage = global::RestaurantApp.Properties.Resources.add;
            this.btn_addFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addFood.Location = new System.Drawing.Point(8, 19);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(66, 71);
            this.btn_addFood.TabIndex = 6;
            this.toolTipAddFood.SetToolTip(this.btn_addFood, "Thêm món ăn");
            this.btn_addFood.UseVisualStyleBackColor = false;
            // 
            // btn_deleteFood
            // 
            this.btn_deleteFood.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteFood.BackgroundImage = global::RestaurantApp.Properties.Resources.delete_icon;
            this.btn_deleteFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deleteFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deleteFood.Location = new System.Drawing.Point(89, 19);
            this.btn_deleteFood.Name = "btn_deleteFood";
            this.btn_deleteFood.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteFood.TabIndex = 7;
            this.toolTipDeleteFood.SetToolTip(this.btn_deleteFood, "Xóa món ăn");
            this.btn_deleteFood.UseVisualStyleBackColor = false;
            // 
            // btn_updateFood
            // 
            this.btn_updateFood.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateFood.BackgroundImage = global::RestaurantApp.Properties.Resources.Fix_icon;
            this.btn_updateFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_updateFood.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateFood.Location = new System.Drawing.Point(170, 19);
            this.btn_updateFood.Name = "btn_updateFood";
            this.btn_updateFood.Size = new System.Drawing.Size(66, 71);
            this.btn_updateFood.TabIndex = 8;
            this.toolTipUpdateFood.SetToolTip(this.btn_updateFood, "Cập nhật món ăn");
            this.btn_updateFood.UseVisualStyleBackColor = false;
            // 
            // btn_viewFood
            // 
            this.btn_viewFood.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewFood.BackgroundImage = global::RestaurantApp.Properties.Resources.Search_icon;
            this.btn_viewFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_viewFood.Location = new System.Drawing.Point(253, 19);
            this.btn_viewFood.Name = "btn_viewFood";
            this.btn_viewFood.Size = new System.Drawing.Size(66, 71);
            this.btn_viewFood.TabIndex = 9;
            this.toolTipViewFood.SetToolTip(this.btn_viewFood, "Xem danh sách món ăn");
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_food.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C0";
            this.foodPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.foodPrice.HeaderText = "Giá";
            this.foodPrice.Name = "foodPrice";
            this.foodPrice.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discount.DataPropertyName = "Discount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.discount.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.foodStatus.DefaultCellStyle = dataGridViewCellStyle9;
            this.foodStatus.HeaderText = "Trạng thái";
            this.foodStatus.Name = "foodStatus";
            this.foodStatus.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_searchfood);
            this.panel3.Controls.Add(this.text_searchFood);
            this.panel3.Location = new System.Drawing.Point(51, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 40);
            this.panel3.TabIndex = 0;
            // 
            // btn_searchfood
            // 
            this.btn_searchfood.BackgroundImage = global::RestaurantApp.Properties.Resources.kinh_lup_icon;
            this.btn_searchfood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchfood.Location = new System.Drawing.Point(329, 3);
            this.btn_searchfood.Name = "btn_searchfood";
            this.btn_searchfood.Size = new System.Drawing.Size(47, 30);
            this.btn_searchfood.TabIndex = 1;
            this.btn_searchfood.UseVisualStyleBackColor = true;
            // 
            // text_searchFood
            // 
            this.text_searchFood.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchFood.Location = new System.Drawing.Point(3, 3);
            this.text_searchFood.Name = "text_searchFood";
            this.text_searchFood.Size = new System.Drawing.Size(329, 30);
            this.text_searchFood.TabIndex = 0;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel_table);
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
            // panel_table
            // 
            this.panel_table.Controls.Add(this.text_tableId);
            this.panel_table.Controls.Add(this.lb_tableId);
            this.panel_table.Controls.Add(this.cb_tableStatus);
            this.panel_table.Controls.Add(this.lb_tableStatus);
            this.panel_table.Controls.Add(this.text_tableName);
            this.panel_table.Controls.Add(this.lb_tableName);
            this.panel_table.Controls.Add(this.num_tableSeats);
            this.panel_table.Controls.Add(this.lb_tableSeats);
            this.panel_table.Controls.Add(this.lb_titletable);
            this.panel_table.Location = new System.Drawing.Point(743, 64);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(437, 286);
            this.panel_table.TabIndex = 1;
            // 
            // text_tableId
            // 
            this.text_tableId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tableId.Location = new System.Drawing.Point(186, 66);
            this.text_tableId.Name = "text_tableId";
            this.text_tableId.ReadOnly = true;
            this.text_tableId.Size = new System.Drawing.Size(221, 27);
            this.text_tableId.TabIndex = 9;
            this.text_tableId.TextChanged += new System.EventHandler(this.text_tableId_TextChanged);
            // 
            // lb_tableId
            // 
            this.lb_tableId.AutoSize = true;
            this.lb_tableId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableId.Location = new System.Drawing.Point(25, 70);
            this.lb_tableId.Name = "lb_tableId";
            this.lb_tableId.Size = new System.Drawing.Size(40, 23);
            this.lb_tableId.TabIndex = 9;
            this.lb_tableId.Text = "ID:";
            // 
            // cb_tableStatus
            // 
            this.cb_tableStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tableStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tableStatus.FormattingEnabled = true;
            this.cb_tableStatus.Location = new System.Drawing.Point(186, 199);
            this.cb_tableStatus.Name = "cb_tableStatus";
            this.cb_tableStatus.Size = new System.Drawing.Size(221, 27);
            this.cb_tableStatus.TabIndex = 3;
            // 
            // lb_tableStatus
            // 
            this.lb_tableStatus.AutoSize = true;
            this.lb_tableStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableStatus.Location = new System.Drawing.Point(25, 203);
            this.lb_tableStatus.Name = "lb_tableStatus";
            this.lb_tableStatus.Size = new System.Drawing.Size(115, 23);
            this.lb_tableStatus.TabIndex = 7;
            this.lb_tableStatus.Text = "Trạng thái:";
            // 
            // text_tableName
            // 
            this.text_tableName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_tableName.Location = new System.Drawing.Point(186, 109);
            this.text_tableName.Name = "text_tableName";
            this.text_tableName.Size = new System.Drawing.Size(221, 27);
            this.text_tableName.TabIndex = 1;
            this.text_tableName.Validating += new System.ComponentModel.CancelEventHandler(this.text_tableName_Validating);
            // 
            // lb_tableName
            // 
            this.lb_tableName.AutoSize = true;
            this.lb_tableName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableName.Location = new System.Drawing.Point(25, 113);
            this.lb_tableName.Name = "lb_tableName";
            this.lb_tableName.Size = new System.Drawing.Size(52, 23);
            this.lb_tableName.TabIndex = 5;
            this.lb_tableName.Text = "Tên:";
            // 
            // num_tableSeats
            // 
            this.num_tableSeats.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_tableSeats.Location = new System.Drawing.Point(340, 153);
            this.num_tableSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_tableSeats.Name = "num_tableSeats";
            this.num_tableSeats.Size = new System.Drawing.Size(67, 27);
            this.num_tableSeats.TabIndex = 2;
            this.num_tableSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_tableSeats
            // 
            this.lb_tableSeats.AutoSize = true;
            this.lb_tableSeats.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tableSeats.Location = new System.Drawing.Point(25, 157);
            this.lb_tableSeats.Name = "lb_tableSeats";
            this.lb_tableSeats.Size = new System.Drawing.Size(129, 23);
            this.lb_tableSeats.TabIndex = 0;
            this.lb_tableSeats.Text = "Số chỗ ngồi:";
            // 
            // lb_titletable
            // 
            this.lb_titletable.AutoSize = true;
            this.lb_titletable.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titletable.Location = new System.Drawing.Point(181, 3);
            this.lb_titletable.Name = "lb_titletable";
            this.lb_titletable.Size = new System.Drawing.Size(84, 25);
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
            this.panel8.Location = new System.Drawing.Point(743, 431);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(437, 127);
            this.panel8.TabIndex = 2;
            // 
            // btn_clearTable
            // 
            this.btn_clearTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearTable.BackgroundImage = global::RestaurantApp.Properties.Resources.update_icon;
            this.btn_clearTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clearTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearTable.Location = new System.Drawing.Point(355, 21);
            this.btn_clearTable.Name = "btn_clearTable";
            this.btn_clearTable.Size = new System.Drawing.Size(66, 71);
            this.btn_clearTable.TabIndex = 8;
            this.toolTipClear.SetToolTip(this.btn_clearTable, "Làm mới");
            this.btn_clearTable.UseVisualStyleBackColor = false;
            this.btn_clearTable.Click += new System.EventHandler(this.btn_clearTable_Click);
            // 
            // btn_addTable
            // 
            this.btn_addTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_addTable.BackgroundImage = global::RestaurantApp.Properties.Resources.add;
            this.btn_addTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addTable.Location = new System.Drawing.Point(8, 21);
            this.btn_addTable.Name = "btn_addTable";
            this.btn_addTable.Size = new System.Drawing.Size(66, 71);
            this.btn_addTable.TabIndex = 4;
            this.toolTipAddTable.SetToolTip(this.btn_addTable, "Thêm bàn ăn");
            this.btn_addTable.UseVisualStyleBackColor = false;
            // 
            // btn_deleteTable
            // 
            this.btn_deleteTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteTable.BackgroundImage = global::RestaurantApp.Properties.Resources.delete_icon;
            this.btn_deleteTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deleteTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteTable.Location = new System.Drawing.Point(99, 21);
            this.btn_deleteTable.Name = "btn_deleteTable";
            this.btn_deleteTable.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteTable.TabIndex = 5;
            this.toolTipDeleteTable.SetToolTip(this.btn_deleteTable, "Xóa bàn ăn");
            this.btn_deleteTable.UseVisualStyleBackColor = false;
            // 
            // btn_updateTable
            // 
            this.btn_updateTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateTable.BackgroundImage = global::RestaurantApp.Properties.Resources.Fix_icon;
            this.btn_updateTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_updateTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateTable.Location = new System.Drawing.Point(184, 21);
            this.btn_updateTable.Name = "btn_updateTable";
            this.btn_updateTable.Size = new System.Drawing.Size(66, 71);
            this.btn_updateTable.TabIndex = 6;
            this.toolTipUpdateTable.SetToolTip(this.btn_updateTable, "Cập nhật bàn ăn");
            this.btn_updateTable.UseVisualStyleBackColor = false;
            // 
            // btn_viewTable
            // 
            this.btn_viewTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewTable.BackgroundImage = global::RestaurantApp.Properties.Resources.Search_icon;
            this.btn_viewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewTable.Location = new System.Drawing.Point(268, 21);
            this.btn_viewTable.Name = "btn_viewTable";
            this.btn_viewTable.Size = new System.Drawing.Size(66, 71);
            this.btn_viewTable.TabIndex = 7;
            this.toolTipViewTable.SetToolTip(this.btn_viewTable, "Xem danh sách bàn ăn");
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.tableName,
            this.seats,
            this.tableStatus});
            this.dataGridView_table.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_table.Name = "dataGridView_table";
            this.dataGridView_table.ReadOnly = true;
            this.dataGridView_table.Size = new System.Drawing.Size(688, 507);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.seats.DefaultCellStyle = dataGridViewCellStyle11;
            this.seats.HeaderText = "Số chỗ ngồi";
            this.seats.Name = "seats";
            this.seats.ReadOnly = true;
            // 
            // tableStatus
            // 
            this.tableStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableStatus.DataPropertyName = "Status";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tableStatus.DefaultCellStyle = dataGridViewCellStyle12;
            this.tableStatus.HeaderText = "Trạng thái";
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.ReadOnly = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_searchtable);
            this.panel10.Controls.Add(this.text_searchTable);
            this.panel10.Location = new System.Drawing.Point(39, 17);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(406, 41);
            this.panel10.TabIndex = 4;
            // 
            // btn_searchtable
            // 
            this.btn_searchtable.BackgroundImage = global::RestaurantApp.Properties.Resources.kinh_lup_icon;
            this.btn_searchtable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchtable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchtable.Location = new System.Drawing.Point(342, 3);
            this.btn_searchtable.Name = "btn_searchtable";
            this.btn_searchtable.Size = new System.Drawing.Size(47, 30);
            this.btn_searchtable.TabIndex = 1;
            this.btn_searchtable.UseVisualStyleBackColor = true;
            // 
            // text_searchTable
            // 
            this.text_searchTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchTable.Location = new System.Drawing.Point(18, 3);
            this.text_searchTable.Name = "text_searchTable";
            this.text_searchTable.Size = new System.Drawing.Size(329, 30);
            this.text_searchTable.TabIndex = 0;
            // 
            // tpMenu
            // 
            this.tpMenu.Controls.Add(this.panel_category);
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
            // panel_category
            // 
            this.panel_category.Controls.Add(this.text_categoryId);
            this.panel_category.Controls.Add(this.lb_categoryId);
            this.panel_category.Controls.Add(this.cb_categoryStatus);
            this.panel_category.Controls.Add(this.lb_categoryStatus);
            this.panel_category.Controls.Add(this.text_categoryname);
            this.panel_category.Controls.Add(this.lb_categoryName);
            this.panel_category.Controls.Add(this.label18);
            this.panel_category.Location = new System.Drawing.Point(713, 57);
            this.panel_category.Name = "panel_category";
            this.panel_category.Size = new System.Drawing.Size(447, 276);
            this.panel_category.TabIndex = 1;
            // 
            // text_categoryId
            // 
            this.text_categoryId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_categoryId.Location = new System.Drawing.Point(197, 65);
            this.text_categoryId.Name = "text_categoryId";
            this.text_categoryId.ReadOnly = true;
            this.text_categoryId.Size = new System.Drawing.Size(221, 27);
            this.text_categoryId.TabIndex = 8;
            this.text_categoryId.TextChanged += new System.EventHandler(this.text_categoryId_TextChanged);
            // 
            // lb_categoryId
            // 
            this.lb_categoryId.AutoSize = true;
            this.lb_categoryId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryId.Location = new System.Drawing.Point(30, 69);
            this.lb_categoryId.Name = "lb_categoryId";
            this.lb_categoryId.Size = new System.Drawing.Size(40, 23);
            this.lb_categoryId.TabIndex = 3;
            this.lb_categoryId.Text = "ID:";
            // 
            // cb_categoryStatus
            // 
            this.cb_categoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoryStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoryStatus.FormattingEnabled = true;
            this.cb_categoryStatus.Location = new System.Drawing.Point(197, 185);
            this.cb_categoryStatus.Name = "cb_categoryStatus";
            this.cb_categoryStatus.Size = new System.Drawing.Size(221, 27);
            this.cb_categoryStatus.TabIndex = 2;
            // 
            // lb_categoryStatus
            // 
            this.lb_categoryStatus.AutoSize = true;
            this.lb_categoryStatus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryStatus.Location = new System.Drawing.Point(30, 189);
            this.lb_categoryStatus.Name = "lb_categoryStatus";
            this.lb_categoryStatus.Size = new System.Drawing.Size(115, 23);
            this.lb_categoryStatus.TabIndex = 0;
            this.lb_categoryStatus.Text = "Trạng thái:";
            // 
            // text_categoryname
            // 
            this.text_categoryname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_categoryname.Location = new System.Drawing.Point(197, 123);
            this.text_categoryname.Name = "text_categoryname";
            this.text_categoryname.Size = new System.Drawing.Size(221, 27);
            this.text_categoryname.TabIndex = 1;
            this.text_categoryname.Validating += new System.ComponentModel.CancelEventHandler(this.text_categoryname_Validating);
            // 
            // lb_categoryName
            // 
            this.lb_categoryName.AutoSize = true;
            this.lb_categoryName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoryName.Location = new System.Drawing.Point(30, 127);
            this.lb_categoryName.Name = "lb_categoryName";
            this.lb_categoryName.Size = new System.Drawing.Size(52, 23);
            this.lb_categoryName.TabIndex = 0;
            this.lb_categoryName.Text = "Tên:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(165, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 25);
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
            this.panel12.Location = new System.Drawing.Point(713, 436);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(447, 108);
            this.panel12.TabIndex = 2;
            // 
            // btn_clearCategory
            // 
            this.btn_clearCategory.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearCategory.BackgroundImage = global::RestaurantApp.Properties.Resources.update_icon;
            this.btn_clearCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clearCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearCategory.Location = new System.Drawing.Point(363, 19);
            this.btn_clearCategory.Name = "btn_clearCategory";
            this.btn_clearCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_clearCategory.TabIndex = 7;
            this.toolTipClear.SetToolTip(this.btn_clearCategory, "Làm mới");
            this.btn_clearCategory.UseVisualStyleBackColor = false;
            this.btn_clearCategory.Click += new System.EventHandler(this.btn_clearCategory_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.Transparent;
            this.btn_addCategory.BackgroundImage = global::RestaurantApp.Properties.Resources.add;
            this.btn_addCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addCategory.Location = new System.Drawing.Point(12, 19);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_addCategory.TabIndex = 3;
            this.toolTipAddCategory.SetToolTip(this.btn_addCategory, "Thêm danh mục");
            this.btn_addCategory.UseVisualStyleBackColor = false;
            // 
            // btn_deleteCategory
            // 
            this.btn_deleteCategory.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteCategory.BackgroundImage = global::RestaurantApp.Properties.Resources.delete_icon;
            this.btn_deleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deleteCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteCategory.Location = new System.Drawing.Point(107, 19);
            this.btn_deleteCategory.Name = "btn_deleteCategory";
            this.btn_deleteCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteCategory.TabIndex = 4;
            this.toolTipDeleteCategory.SetToolTip(this.btn_deleteCategory, "Xóa danh mục");
            this.btn_deleteCategory.UseVisualStyleBackColor = false;
            // 
            // btn_updateCategory
            // 
            this.btn_updateCategory.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateCategory.BackgroundImage = global::RestaurantApp.Properties.Resources.Fix_icon;
            this.btn_updateCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_updateCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateCategory.Location = new System.Drawing.Point(198, 19);
            this.btn_updateCategory.Name = "btn_updateCategory";
            this.btn_updateCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_updateCategory.TabIndex = 5;
            this.toolTipUpdateCategory.SetToolTip(this.btn_updateCategory, "Cập nhật danh mục");
            this.btn_updateCategory.UseVisualStyleBackColor = false;
            // 
            // btn_viewCategory
            // 
            this.btn_viewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewCategory.BackgroundImage = global::RestaurantApp.Properties.Resources.Search_icon;
            this.btn_viewCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewCategory.Location = new System.Drawing.Point(282, 19);
            this.btn_viewCategory.Name = "btn_viewCategory";
            this.btn_viewCategory.Size = new System.Drawing.Size(66, 71);
            this.btn_viewCategory.TabIndex = 6;
            this.toolTipViewCategory.SetToolTip(this.btn_viewCategory, "Xem danh sách danh mục");
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoryStatus.DefaultCellStyle = dataGridViewCellStyle14;
            this.categoryStatus.HeaderText = "Trạng thái";
            this.categoryStatus.Name = "categoryStatus";
            this.categoryStatus.ReadOnly = true;
            // 
            // createdDateCategory
            // 
            this.createdDateCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdDateCategory.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "dd/MM/yyyy";
            this.createdDateCategory.DefaultCellStyle = dataGridViewCellStyle15;
            this.createdDateCategory.HeaderText = "Ngày tạo";
            this.createdDateCategory.Name = "createdDateCategory";
            this.createdDateCategory.ReadOnly = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btn_searchcategory);
            this.panel14.Controls.Add(this.text_searchCategory);
            this.panel14.Location = new System.Drawing.Point(64, 13);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(390, 38);
            this.panel14.TabIndex = 4;
            // 
            // btn_searchcategory
            // 
            this.btn_searchcategory.BackgroundImage = global::RestaurantApp.Properties.Resources.kinh_lup_icon;
            this.btn_searchcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchcategory.Location = new System.Drawing.Point(328, 3);
            this.btn_searchcategory.Name = "btn_searchcategory";
            this.btn_searchcategory.Size = new System.Drawing.Size(47, 30);
            this.btn_searchcategory.TabIndex = 5;
            this.btn_searchcategory.UseVisualStyleBackColor = true;
            // 
            // text_searchCategory
            // 
            this.text_searchCategory.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchCategory.Location = new System.Drawing.Point(3, 3);
            this.text_searchCategory.Name = "text_searchCategory";
            this.text_searchCategory.Size = new System.Drawing.Size(329, 30);
            this.text_searchCategory.TabIndex = 2;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel_user);
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
            // panel_user
            // 
            this.panel_user.AutoScroll = true;
            this.panel_user.Controls.Add(this.lb_dob);
            this.panel_user.Controls.Add(this.dateTime_dobUser);
            this.panel_user.Controls.Add(this.text_userId);
            this.panel_user.Controls.Add(this.lb_userId);
            this.panel_user.Controls.Add(this.cb_userStatus);
            this.panel_user.Controls.Add(this.lb_status);
            this.panel_user.Controls.Add(this.pn_gender);
            this.panel_user.Controls.Add(this.text_email);
            this.panel_user.Controls.Add(this.lb_email);
            this.panel_user.Controls.Add(this.cb_role);
            this.panel_user.Controls.Add(this.text_address);
            this.panel_user.Controls.Add(this.text_phone);
            this.panel_user.Controls.Add(this.lb_role);
            this.panel_user.Controls.Add(this.lb_gender);
            this.panel_user.Controls.Add(this.lb_address);
            this.panel_user.Controls.Add(this.lb_phone);
            this.panel_user.Controls.Add(this.text_password);
            this.panel_user.Controls.Add(this.lb_password);
            this.panel_user.Controls.Add(this.text_fullname);
            this.panel_user.Controls.Add(this.text_username);
            this.panel_user.Controls.Add(this.lb_fullname);
            this.panel_user.Controls.Add(this.lb_username);
            this.panel_user.Controls.Add(this.label25);
            this.panel_user.Location = new System.Drawing.Point(723, 6);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(452, 486);
            this.panel_user.TabIndex = 1;
            // 
            // lb_dob
            // 
            this.lb_dob.AutoSize = true;
            this.lb_dob.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dob.Location = new System.Drawing.Point(18, 363);
            this.lb_dob.Name = "lb_dob";
            this.lb_dob.Size = new System.Drawing.Size(112, 23);
            this.lb_dob.TabIndex = 28;
            this.lb_dob.Text = "Ngày sinh:";
            // 
            // dateTime_dobUser
            // 
            this.dateTime_dobUser.CustomFormat = "dd/MM/yyyy";
            this.dateTime_dobUser.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_dobUser.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_dobUser.Location = new System.Drawing.Point(223, 360);
            this.dateTime_dobUser.Name = "dateTime_dobUser";
            this.dateTime_dobUser.Size = new System.Drawing.Size(171, 26);
            this.dateTime_dobUser.TabIndex = 27;
            // 
            // text_userId
            // 
            this.text_userId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_userId.Location = new System.Drawing.Point(223, 36);
            this.text_userId.Name = "text_userId";
            this.text_userId.ReadOnly = true;
            this.text_userId.Size = new System.Drawing.Size(210, 27);
            this.text_userId.TabIndex = 16;
            this.text_userId.TextChanged += new System.EventHandler(this.text_userId_TextChanged);
            // 
            // lb_userId
            // 
            this.lb_userId.AutoSize = true;
            this.lb_userId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userId.Location = new System.Drawing.Point(18, 40);
            this.lb_userId.Name = "lb_userId";
            this.lb_userId.Size = new System.Drawing.Size(40, 23);
            this.lb_userId.TabIndex = 26;
            this.lb_userId.Text = "ID:";
            // 
            // cb_userStatus
            // 
            this.cb_userStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_userStatus.FormattingEnabled = true;
            this.cb_userStatus.Location = new System.Drawing.Point(223, 441);
            this.cb_userStatus.Name = "cb_userStatus";
            this.cb_userStatus.Size = new System.Drawing.Size(210, 27);
            this.cb_userStatus.TabIndex = 10;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(18, 445);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(115, 23);
            this.lb_status.TabIndex = 24;
            this.lb_status.Text = "Trạng thái:";
            // 
            // pn_gender
            // 
            this.pn_gender.Controls.Add(this.radio_female);
            this.pn_gender.Controls.Add(this.radio_male);
            this.pn_gender.Location = new System.Drawing.Point(223, 315);
            this.pn_gender.Name = "pn_gender";
            this.pn_gender.Size = new System.Drawing.Size(171, 28);
            this.pn_gender.TabIndex = 23;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_female.Location = new System.Drawing.Point(99, 1);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(48, 23);
            this.radio_female.TabIndex = 8;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Nữ";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Checked = true;
            this.radio_male.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_male.Location = new System.Drawing.Point(3, 1);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(60, 23);
            this.radio_male.TabIndex = 7;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Nam";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.Location = new System.Drawing.Point(223, 233);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(210, 27);
            this.text_email.TabIndex = 5;
            this.text_email.Validating += new System.ComponentModel.CancelEventHandler(this.text_email_Validating);
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(18, 237);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(70, 23);
            this.lb_email.TabIndex = 6;
            this.lb_email.Text = "Email:";
            // 
            // cb_role
            // 
            this.cb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_role.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(223, 401);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(210, 27);
            this.cb_role.TabIndex = 9;
            // 
            // text_address
            // 
            this.text_address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_address.Location = new System.Drawing.Point(223, 275);
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(210, 27);
            this.text_address.TabIndex = 6;
            this.text_address.Validating += new System.ComponentModel.CancelEventHandler(this.text_address_Validating);
            // 
            // text_phone
            // 
            this.text_phone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phone.Location = new System.Drawing.Point(223, 192);
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(210, 27);
            this.text_phone.TabIndex = 4;
            this.text_phone.Validating += new System.ComponentModel.CancelEventHandler(this.text_phone_Validating);
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(18, 405);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(81, 23);
            this.lb_role.TabIndex = 0;
            this.lb_role.Text = "Vai trò:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.Location = new System.Drawing.Point(18, 320);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(99, 23);
            this.lb_gender.TabIndex = 0;
            this.lb_gender.Text = "Giới tính:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(18, 279);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(83, 23);
            this.lb_address.TabIndex = 0;
            this.lb_address.Text = "Địa chỉ:";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(18, 196);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(143, 23);
            this.lb_phone.TabIndex = 0;
            this.lb_phone.Text = "Số điện thoại:";
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.Location = new System.Drawing.Point(223, 151);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(210, 27);
            this.text_password.TabIndex = 3;
            this.text_password.Validating += new System.ComponentModel.CancelEventHandler(this.text_password_Validating);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(18, 155);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(105, 23);
            this.lb_password.TabIndex = 0;
            this.lb_password.Text = "Mật khẩu:";
            // 
            // text_fullname
            // 
            this.text_fullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_fullname.Location = new System.Drawing.Point(223, 77);
            this.text_fullname.Name = "text_fullname";
            this.text_fullname.Size = new System.Drawing.Size(210, 27);
            this.text_fullname.TabIndex = 1;
            this.text_fullname.Validating += new System.ComponentModel.CancelEventHandler(this.text_fullname_Validating);
            // 
            // text_username
            // 
            this.text_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_username.Location = new System.Drawing.Point(223, 113);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(210, 27);
            this.text_username.TabIndex = 2;
            this.text_username.Validating += new System.ComponentModel.CancelEventHandler(this.text_username_Validating);
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fullname.Location = new System.Drawing.Point(18, 81);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(81, 23);
            this.lb_fullname.TabIndex = 0;
            this.lb_fullname.Text = "Họ tên:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(18, 117);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(110, 23);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Tài khoản:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(182, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 25);
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
            this.panel16.Location = new System.Drawing.Point(723, 498);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(452, 79);
            this.panel16.TabIndex = 2;
            // 
            // btn_clearUser
            // 
            this.btn_clearUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearUser.BackgroundImage = global::RestaurantApp.Properties.Resources.update_icon;
            this.btn_clearUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clearUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearUser.Location = new System.Drawing.Point(367, 3);
            this.btn_clearUser.Name = "btn_clearUser";
            this.btn_clearUser.Size = new System.Drawing.Size(66, 71);
            this.btn_clearUser.TabIndex = 15;
            this.toolTipClear.SetToolTip(this.btn_clearUser, "Làm mới");
            this.btn_clearUser.UseVisualStyleBackColor = false;
            this.btn_clearUser.Click += new System.EventHandler(this.btn_clearUser_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_addUser.BackgroundImage = global::RestaurantApp.Properties.Resources.add_user;
            this.btn_addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addUser.Location = new System.Drawing.Point(21, 3);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(66, 71);
            this.btn_addUser.TabIndex = 11;
            this.toolTipAddUser.SetToolTip(this.btn_addUser, "Thêm người dùng");
            this.btn_addUser.UseVisualStyleBackColor = false;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteUser.BackgroundImage = global::RestaurantApp.Properties.Resources.delete_icon;
            this.btn_deleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deleteUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteUser.Location = new System.Drawing.Point(111, 3);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteUser.TabIndex = 12;
            this.toolTipDeleteUser.SetToolTip(this.btn_deleteUser, "Xóa người dùng");
            this.btn_deleteUser.UseVisualStyleBackColor = false;
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateUser.BackgroundImage = global::RestaurantApp.Properties.Resources.Fix_icon;
            this.btn_updateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_updateUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateUser.Location = new System.Drawing.Point(199, 3);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(66, 71);
            this.btn_updateUser.TabIndex = 13;
            this.toolTipUpdateUser.SetToolTip(this.btn_updateUser, "Cập nhật người dùng");
            this.btn_updateUser.UseVisualStyleBackColor = false;
            // 
            // btn_viewUser
            // 
            this.btn_viewUser.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewUser.BackgroundImage = global::RestaurantApp.Properties.Resources.Search_icon;
            this.btn_viewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewUser.Location = new System.Drawing.Point(283, 3);
            this.btn_viewUser.Name = "btn_viewUser";
            this.btn_viewUser.Size = new System.Drawing.Size(66, 71);
            this.btn_viewUser.TabIndex = 14;
            this.toolTipViewUser.SetToolTip(this.btn_viewUser, "Xem danh sách người dùng");
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            this.dataGridView_user.Location = new System.Drawing.Point(3, 4);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.ReadOnly = true;
            this.dataGridView_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView_user.Size = new System.Drawing.Size(675, 525);
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.phone.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gender.DefaultCellStyle = dataGridViewCellStyle18;
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 79;
            // 
            // userStatus
            // 
            this.userStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userStatus.DataPropertyName = "Status";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.userStatus.DefaultCellStyle = dataGridViewCellStyle19;
            this.userStatus.HeaderText = "Trạng thái";
            this.userStatus.Name = "userStatus";
            this.userStatus.ReadOnly = true;
            this.userStatus.Width = 92;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.role.DataPropertyName = "Role";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.role.DefaultCellStyle = dataGridViewCellStyle20;
            this.role.HeaderText = "Vai trò";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 71;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dob.DataPropertyName = "Dob";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "dd/MM/yyyy";
            this.dob.DefaultCellStyle = dataGridViewCellStyle21;
            this.dob.HeaderText = "Ngày sinh";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 88;
            // 
            // createdDateUser
            // 
            this.createdDateUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.createdDateUser.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "dd/MM/yyyy";
            this.createdDateUser.DefaultCellStyle = dataGridViewCellStyle22;
            this.createdDateUser.HeaderText = "Ngày tạo";
            this.createdDateUser.Name = "createdDateUser";
            this.createdDateUser.ReadOnly = true;
            this.createdDateUser.Width = 83;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btn_searchuser);
            this.panel18.Controls.Add(this.text_searchUser);
            this.panel18.Location = new System.Drawing.Point(48, 8);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(390, 34);
            this.panel18.TabIndex = 4;
            // 
            // btn_searchuser
            // 
            this.btn_searchuser.BackgroundImage = global::RestaurantApp.Properties.Resources.kinh_lup_icon;
            this.btn_searchuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_searchuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchuser.Location = new System.Drawing.Point(329, 3);
            this.btn_searchuser.Name = "btn_searchuser";
            this.btn_searchuser.Size = new System.Drawing.Size(47, 30);
            this.btn_searchuser.TabIndex = 1;
            this.btn_searchuser.UseVisualStyleBackColor = true;
            // 
            // text_searchUser
            // 
            this.text_searchUser.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchUser.Location = new System.Drawing.Point(3, 3);
            this.text_searchUser.Name = "text_searchUser";
            this.text_searchUser.Size = new System.Drawing.Size(329, 30);
            this.text_searchUser.TabIndex = 0;
            // 
            // tbSale
            // 
            this.tbSale.Controls.Add(this.panel_sale);
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
            // panel_sale
            // 
            this.panel_sale.Controls.Add(this.text_saleId);
            this.panel_sale.Controls.Add(this.lb_saleId);
            this.panel_sale.Controls.Add(this.saleDiscountNum);
            this.panel_sale.Controls.Add(this.cb_saleStatus);
            this.panel_sale.Controls.Add(this.label5);
            this.panel_sale.Controls.Add(this.lb_saleDiscount);
            this.panel_sale.Controls.Add(this.text_saleName);
            this.panel_sale.Controls.Add(this.lb_saleName);
            this.panel_sale.Controls.Add(this.lb_sale);
            this.panel_sale.Location = new System.Drawing.Point(720, 60);
            this.panel_sale.Name = "panel_sale";
            this.panel_sale.Size = new System.Drawing.Size(444, 299);
            this.panel_sale.TabIndex = 7;
            // 
            // text_saleId
            // 
            this.text_saleId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_saleId.Location = new System.Drawing.Point(195, 83);
            this.text_saleId.Name = "text_saleId";
            this.text_saleId.ReadOnly = true;
            this.text_saleId.Size = new System.Drawing.Size(221, 27);
            this.text_saleId.TabIndex = 9;
            this.text_saleId.TextChanged += new System.EventHandler(this.text_saleId_TextChanged);
            // 
            // lb_saleId
            // 
            this.lb_saleId.AutoSize = true;
            this.lb_saleId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saleId.Location = new System.Drawing.Point(25, 88);
            this.lb_saleId.Name = "lb_saleId";
            this.lb_saleId.Size = new System.Drawing.Size(40, 23);
            this.lb_saleId.TabIndex = 4;
            this.lb_saleId.Text = "ID:";
            // 
            // saleDiscountNum
            // 
            this.saleDiscountNum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleDiscountNum.Location = new System.Drawing.Point(337, 199);
            this.saleDiscountNum.Name = "saleDiscountNum";
            this.saleDiscountNum.Size = new System.Drawing.Size(79, 27);
            this.saleDiscountNum.TabIndex = 2;
            // 
            // cb_saleStatus
            // 
            this.cb_saleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_saleStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_saleStatus.FormattingEnabled = true;
            this.cb_saleStatus.Location = new System.Drawing.Point(195, 249);
            this.cb_saleStatus.Name = "cb_saleStatus";
            this.cb_saleStatus.Size = new System.Drawing.Size(221, 27);
            this.cb_saleStatus.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái:";
            // 
            // lb_saleDiscount
            // 
            this.lb_saleDiscount.AutoSize = true;
            this.lb_saleDiscount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saleDiscount.Location = new System.Drawing.Point(25, 203);
            this.lb_saleDiscount.Name = "lb_saleDiscount";
            this.lb_saleDiscount.Size = new System.Drawing.Size(101, 23);
            this.lb_saleDiscount.TabIndex = 0;
            this.lb_saleDiscount.Text = "Giảm giá:";
            // 
            // text_saleName
            // 
            this.text_saleName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_saleName.Location = new System.Drawing.Point(195, 143);
            this.text_saleName.Name = "text_saleName";
            this.text_saleName.Size = new System.Drawing.Size(221, 27);
            this.text_saleName.TabIndex = 1;
            this.text_saleName.Validating += new System.ComponentModel.CancelEventHandler(this.text_saleName_Validating);
            // 
            // lb_saleName
            // 
            this.lb_saleName.AutoSize = true;
            this.lb_saleName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saleName.Location = new System.Drawing.Point(25, 147);
            this.lb_saleName.Name = "lb_saleName";
            this.lb_saleName.Size = new System.Drawing.Size(52, 23);
            this.lb_saleName.TabIndex = 0;
            this.lb_saleName.Text = "Tên:";
            // 
            // lb_sale
            // 
            this.lb_sale.AutoSize = true;
            this.lb_sale.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sale.Location = new System.Drawing.Point(106, 3);
            this.lb_sale.Name = "lb_sale";
            this.lb_sale.Size = new System.Drawing.Size(245, 25);
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
            this.panel22.Location = new System.Drawing.Point(720, 437);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(444, 113);
            this.panel22.TabIndex = 8;
            // 
            // btn_clearSale
            // 
            this.btn_clearSale.BackColor = System.Drawing.Color.Transparent;
            this.btn_clearSale.BackgroundImage = global::RestaurantApp.Properties.Resources.update_icon;
            this.btn_clearSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_clearSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clearSale.Location = new System.Drawing.Point(350, 19);
            this.btn_clearSale.Name = "btn_clearSale";
            this.btn_clearSale.Size = new System.Drawing.Size(66, 71);
            this.btn_clearSale.TabIndex = 8;
            this.toolTipClear.SetToolTip(this.btn_clearSale, "Làm mới");
            this.btn_clearSale.UseVisualStyleBackColor = false;
            this.btn_clearSale.Click += new System.EventHandler(this.btn_clearSale_Click);
            // 
            // btn_addSale
            // 
            this.btn_addSale.BackColor = System.Drawing.Color.Transparent;
            this.btn_addSale.BackgroundImage = global::RestaurantApp.Properties.Resources.add;
            this.btn_addSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addSale.Location = new System.Drawing.Point(20, 19);
            this.btn_addSale.Name = "btn_addSale";
            this.btn_addSale.Size = new System.Drawing.Size(66, 71);
            this.btn_addSale.TabIndex = 4;
            this.toolTipAddSale.SetToolTip(this.btn_addSale, "Thêm chương trình giảm giá");
            this.btn_addSale.UseVisualStyleBackColor = false;
            // 
            // btn_deleteSale
            // 
            this.btn_deleteSale.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteSale.BackgroundImage = global::RestaurantApp.Properties.Resources.delete_icon;
            this.btn_deleteSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_deleteSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deleteSale.Location = new System.Drawing.Point(101, 19);
            this.btn_deleteSale.Name = "btn_deleteSale";
            this.btn_deleteSale.Size = new System.Drawing.Size(66, 71);
            this.btn_deleteSale.TabIndex = 5;
            this.toolTipDeleteSale.SetToolTip(this.btn_deleteSale, "Xóa chương trình giảm giá");
            this.btn_deleteSale.UseVisualStyleBackColor = false;
            // 
            // btn_updateSale
            // 
            this.btn_updateSale.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateSale.BackgroundImage = global::RestaurantApp.Properties.Resources.Fix_icon;
            this.btn_updateSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_updateSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_updateSale.Location = new System.Drawing.Point(186, 19);
            this.btn_updateSale.Name = "btn_updateSale";
            this.btn_updateSale.Size = new System.Drawing.Size(66, 71);
            this.btn_updateSale.TabIndex = 6;
            this.toolTipUpdateSale.SetToolTip(this.btn_updateSale, "Cập nhật chương trình giảm giá");
            this.btn_updateSale.UseVisualStyleBackColor = false;
            // 
            // btn_viewSale
            // 
            this.btn_viewSale.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewSale.BackgroundImage = global::RestaurantApp.Properties.Resources.Search_icon;
            this.btn_viewSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_viewSale.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_viewSale.Location = new System.Drawing.Point(267, 19);
            this.btn_viewSale.Name = "btn_viewSale";
            this.btn_viewSale.Size = new System.Drawing.Size(66, 71);
            this.btn_viewSale.TabIndex = 7;
            this.toolTipViewSale.SetToolTip(this.btn_viewSale, "Xem danh sách chương trình giảm giá");
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
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleDiscount.DefaultCellStyle = dataGridViewCellStyle24;
            this.saleDiscount.HeaderText = "Giảm giá (%)";
            this.saleDiscount.Name = "saleDiscount";
            this.saleDiscount.ReadOnly = true;
            // 
            // saleStatus
            // 
            this.saleStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleStatus.DataPropertyName = "Status";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.saleStatus.DefaultCellStyle = dataGridViewCellStyle25;
            this.saleStatus.HeaderText = "Trạng thái";
            this.saleStatus.Name = "saleStatus";
            this.saleStatus.ReadOnly = true;
            // 
            // saleCreatedDate
            // 
            this.saleCreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saleCreatedDate.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Format = "dd/MM/yyyy";
            this.saleCreatedDate.DefaultCellStyle = dataGridViewCellStyle26;
            this.saleCreatedDate.HeaderText = "Ngày tạo";
            this.saleCreatedDate.Name = "saleCreatedDate";
            this.saleCreatedDate.ReadOnly = true;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btn_SearchSale);
            this.panel19.Controls.Add(this.text_searchSale);
            this.panel19.Location = new System.Drawing.Point(51, 13);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(403, 41);
            this.panel19.TabIndex = 5;
            // 
            // btn_SearchSale
            // 
            this.btn_SearchSale.BackgroundImage = global::RestaurantApp.Properties.Resources.kinh_lup_icon;
            this.btn_SearchSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SearchSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchSale.Location = new System.Drawing.Point(339, 3);
            this.btn_SearchSale.Name = "btn_SearchSale";
            this.btn_SearchSale.Size = new System.Drawing.Size(47, 30);
            this.btn_SearchSale.TabIndex = 1;
            this.btn_SearchSale.UseVisualStyleBackColor = true;
            // 
            // text_searchSale
            // 
            this.text_searchSale.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_searchSale.Location = new System.Drawing.Point(13, 3);
            this.text_searchSale.Name = "text_searchSale";
            this.text_searchSale.Size = new System.Drawing.Size(329, 30);
            this.text_searchSale.TabIndex = 0;
            // 
            // errorEmpty
            // 
            this.errorEmpty.ContainerControl = this;
            this.errorEmpty.Icon = ((System.Drawing.Icon)(resources.GetObject("errorEmpty.Icon")));
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1247, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountMenu
            // 
            this.accountMenu.BackColor = System.Drawing.Color.LightCyan;
            this.accountMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_userInformation,
            this.menuResetPassword,
            this.menuItem_logout});
            this.accountMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountMenu.ForeColor = System.Drawing.Color.Black;
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
            // orderId
            // 
            this.orderId.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.orderId.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderId.HeaderText = "Mã đơn hàng";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // orderTable
            // 
            this.orderTable.DataPropertyName = "Table";
            this.orderTable.HeaderText = "Bàn";
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            // 
            // saleOrder
            // 
            this.saleOrder.DataPropertyName = "Sale";
            this.saleOrder.HeaderText = "Giảm giá";
            this.saleOrder.Name = "saleOrder";
            this.saleOrder.ReadOnly = true;
            // 
            // totalPriceOrder
            // 
            this.totalPriceOrder.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle3.Format = "C0";
            this.totalPriceOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalPriceOrder.HeaderText = "Tổng trị giá";
            this.totalPriceOrder.Name = "totalPriceOrder";
            this.totalPriceOrder.ReadOnly = true;
            // 
            // checkin
            // 
            this.checkin.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm:ss";
            this.checkin.DefaultCellStyle = dataGridViewCellStyle4;
            this.checkin.HeaderText = "Giờ vào";
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            // 
            // checkout
            // 
            this.checkout.DataPropertyName = "ModifiedDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm:ss";
            this.checkout.DefaultCellStyle = dataGridViewCellStyle5;
            this.checkout.HeaderText = "Giờ ra";
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            // 
            // createdByOrder
            // 
            this.createdByOrder.DataPropertyName = "CreatedBy";
            this.createdByOrder.HeaderText = "Thu ngân";
            this.createdByOrder.Name = "createdByOrder";
            this.createdByOrder.ReadOnly = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1247, 665);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControlAdmin);
            this.MaximizeBox = false;
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
            this.panel_food.ResumeLayout(false);
            this.panel_food.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.food_discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_price)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_food)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpTable.ResumeLayout(false);
            this.panel_table.ResumeLayout(false);
            this.panel_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tableSeats)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_table)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tpMenu.ResumeLayout(false);
            this.panel_category.ResumeLayout(false);
            this.panel_category.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tpAccount.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.pn_gender.ResumeLayout(false);
            this.pn_gender.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tbSale.ResumeLayout(false);
            this.panel_sale.ResumeLayout(false);
            this.panel_sale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleDiscountNum)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Sale)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmpty)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControlAdmin;
        private TabPage tpMoney;
        private TabPage tpFoods;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private TabPage tpTable;
        private TabPage tpMenu;
        private TabPage tpAccount;
        private TextBox text_totalMoney;
        private TextBox text_countOrder;
        private Label label2;
        private DateTimePicker dtp_todate;
        private DateTimePicker dtp_fromdate;
        private Label label3;
        private Label label4;
        private Button btn_statis;
        private Button btn_print;
        private Panel panel_food;
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
        private Panel panel_table;
        private NumericUpDown num_tableSeats;
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
        private TextBox text_searchTable;
        private Panel panel_category;
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
        private Panel panel_user;
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
        private TextBox text_searchUser;
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
        private Panel panel_sale;
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
        private ErrorProvider errorEmpty;
        private Label lb_dob;
        private DateTimePicker dateTime_dobUser;
        private ToolTip toolTipPrint;
        private ToolTip toolTipClear;
        private ToolTip toolTipAddFood;
        private ToolTip toolTipDeleteFood;
        private ToolTip toolTipUpdateFood;
        private ToolTip toolTipViewFood;
        private ToolTip toolTipAddTable;
        private ToolTip toolTipDeleteTable;
        private ToolTip toolTipUpdateTable;
        private ToolTip toolTipViewTable;
        private ToolTip toolTipAddCategory;
        private ToolTip toolTipDeleteCategory;
        private ToolTip toolTipUpdateCategory;
        private ToolTip toolTipViewCategory;
        private ToolTip toolTipAddUser;
        private ToolTip toolTipDeleteUser;
        private ToolTip toolTipUpdateUser;
        private ToolTip toolTipViewUser;
        private ToolTip toolTipAddSale;
        private ToolTip toolTipDeleteSale;
        private ToolTip toolTipUpdateSale;
        private ToolTip toolTipViewSale;
        private TextBox text_searchCategory;
        private Button btn_searchcategory;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem accountMenu;
        public ToolStripMenuItem menuItem_userInformation;
        private ToolStripMenuItem menuResetPassword;
        public ToolStripMenuItem menuItem_logout;
        private DataGridView dataGridView_order;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn foodName;
        private DataGridViewTextBoxColumn foodPrice;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn categoryFood;
        private DataGridViewTextBoxColumn foodStatus;
        private DataGridViewTextBoxColumn orderId;
        private DataGridViewTextBoxColumn orderTable;
        private DataGridViewTextBoxColumn saleOrder;
        private DataGridViewTextBoxColumn totalPriceOrder;
        private DataGridViewTextBoxColumn checkin;
        private DataGridViewTextBoxColumn checkout;
        private DataGridViewTextBoxColumn createdByOrder;

        public DataGridView DataGridView_Table { get => dataGridView_table; set => dataGridView_table = value; }
        public DataGridView DataGridView_User { get => dataGridView_user; set => dataGridView_user = value; }
        public DataGridView DataGridView_Food { get => dataGridView_food; set => dataGridView_food = value; }
        public DataGridView DataGridView_Category { get => dataGridView_category; set => dataGridView_category = value; }
        public DataGridView DataGridView_Order { get => dataGridView_order; set => dataGridView_order = value; }

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

        public Button Btn_searchcategory { get => btn_searchcategory; set => btn_searchcategory = value; }
        public Button Btn_searchfood { get => btn_searchfood; set => btn_searchfood = value; }
        public Button Btn_SearchSale { get => btn_SearchSale; set => btn_SearchSale = value; }
        public Button Btn_searchuser { get => btn_searchuser; set => btn_searchuser = value; }
        public Button Btn_searchtable { get => btn_searchtable; set => btn_searchtable = value; }

        public Button Btn_Statis { get => btn_statis; set => btn_statis = value; }
        public Button Btn_PrintReport { get => btn_print; set => btn_print = value; }

        public TextBox Text_foodId { get => text_foodId; set => text_foodId = value; }
        public TextBox Text_foodName { get => text_foodName; set => text_foodName = value; }
        public ComboBox Cb_foodStatus { get => cb_foodStatus; set => cb_foodStatus = value; }
        public ComboBox Cb_foodCategory { get => cb_foodCategory; set => cb_foodCategory = value; }
        public NumericUpDown Food_discount { get => food_discount; set => food_discount = value; }
        public NumericUpDown Food_price { get => food_price; set => food_price = value; }      
        public ErrorProvider ErrorEmpty { get => errorEmpty; set => errorEmpty = value; }
        public Panel PanelFood { get => panel_food; set => panel_food = value; }
        public Panel PanelTable { get => panel_table; set => panel_food = value; }
        public Panel PanelCategory { get => panel_category; set => panel_food = value; }
        public Panel PanelUser { get => panel_user; set => panel_food = value; }
        public Panel PanelSale { get => panel_sale; set => panel_food = value; }
        public NumericUpDown Num_tableSeats { get => num_tableSeats; set => num_tableSeats = value; }
        public TextBox Text_tableId { get => text_tableId; set => text_foodId = value; }
        public TextBox Text_tableName { get => text_tableName; set => text_foodName = value; }
        public ComboBox Cb_tableStatus { get => cb_tableStatus; set => cb_foodStatus = value; }
        public TextBox Text_categoryname { get => text_categoryname; set => text_categoryname = value; }
        public ComboBox Cb_categoryStatus { get => cb_categoryStatus; set => cb_categoryStatus = value; }
        public TextBox Text_categoryId { get => text_categoryId; set => text_categoryId = value; }
        public NumericUpDown SaleDiscountNum { get => saleDiscountNum; set => saleDiscountNum = value; }
        public ComboBox Cb_saleStatus { get => cb_saleStatus; set => cb_saleStatus = value; }
        public TextBox Text_saleName { get => text_saleName; set => text_saleName = value; }
        public TextBox Text_saleId { get => text_saleId; set => text_saleId = value; }
        public TextBox Text_fullname { get => text_fullname; set => text_fullname = value; }
        public TextBox Text_username { get => text_username; set => text_username = value; }
        public RadioButton Radio_female { get => radio_female; set => radio_female = value; }
        public RadioButton Radio_male { get => radio_male; set => radio_male = value; }
        public ComboBox Cb_userStatus { get => cb_userStatus; set => cb_userStatus = value; }
        public TextBox Text_userId { get => text_userId; set => text_userId = value; }
        public TextBox Text_email { get => text_email; set => text_email = value; }
        public TextBox Text_address { get => text_address; set => text_address = value; }
        public TextBox Text_password { get => text_password; set => text_password = value; }
        public TextBox Text_phone { get => text_phone; set => text_phone = value; }
        public ComboBox Cb_role { get => cb_role; set => cb_role = value; }
        public DateTimePicker DateTime_dobUser { get => dateTime_dobUser; set => dateTime_dobUser = value; }

        public TextBox Text_SearchCategory { get => text_searchCategory; set => text_searchCategory = value; }
        public TextBox Text_SearchFood { get => text_searchFood; set => text_searchFood = value; }
        public TextBox Text_SearchSale { get => text_searchSale; set => text_searchSale = value; }
        public TextBox Text_SearchTable { get => text_searchTable; set => text_searchTable = value; }
        public TextBox Text_SearchUser { get => text_searchUser; set => text_searchUser = value; }
        public DateTimePicker Dtp_todate { get => dtp_todate; set => dtp_todate = value; }
        public DateTimePicker Dtp_fromdate { get => dtp_fromdate; set => dtp_fromdate = value; }
        public TextBox Text_CountOrder { get => text_countOrder; set => text_countOrder = value; }
        public TextBox Text_TotalPriceOrder { get => text_totalMoney; set => text_totalMoney = value; }
    }
}