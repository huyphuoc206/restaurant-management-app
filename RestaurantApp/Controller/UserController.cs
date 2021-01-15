using RestaurantApp.Constant;
using RestaurantApp.Model;
using RestaurantApp.ModelData;
using RestaurantApp.Utils;
using RestaurantApp.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Controller
{
    class UserController
    {
        private User view;
        private HttpClient client = new HttpClient();

        public UserController()
        {
            this.View = new User();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitController();
        }

        public User View { get => view; set => view = value; }

        private void InitController()
        {
            loadData();
            Event();
        }

        private async void loadData()
        {
            view.Cb_IndeQuantity.SelectedIndex = 0;
            view.cb_showTable.SelectedIndex = 0;
            List<TableModel> tables = await new TableModel().GetTables(client);
            List<SaleModel> sales = await new SaleModel().GetSales(client);
            List<SaleModel> salesShow = new List<SaleModel>();
            foreach (SaleModel sale in sales)
                if (sale.Status.Equals("1"))
                    salesShow.Add(sale);
            List<CategoryModel> categories = await new CategoryModel().GetCategories(client);
            List<CategoryModel> categoriesShow = new List<CategoryModel>();
            foreach (CategoryModel category in categories)
                if (category.Status.Equals("1"))
                    categoriesShow.Add(category);
            view.loadTables(getButtonsTables(tables, 0));
            view.loadCategories(categoriesShow);
            view.loadSales(salesShow);
            view.loadTableToSwitch(tables);
        }

        private void Event()
        {
            view.Cb_categories.SelectedIndexChanged += new EventHandler(cb_categories_SelectedIndexChanged);
            view.Btn_CancelTable.Click += new EventHandler(cancelTable);
            view.Btn_Pay.Click += new EventHandler(payOrder);
            view.cb_sales.SelectedIndexChanged += new EventHandler(cb_sales_SelectedIndexChanged);
            view.Btn_SwitchTable.Click += new EventHandler(switchTable);
            view.btn_printBill.Click += new EventHandler(printBill);
            view.cb_showTable.SelectedIndexChanged += new EventHandler(cb_showTable_SelectedIndexChanged);
        }

        private async void cb_showTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            int index = cb.SelectedIndex;
            List<TableModel> tables = await new TableModel().GetTables(client);
            view.loadTables(getButtonsTables(tables, index));
        }

        private async void printBill(object sender, EventArgs e)
        {
            TableModel table = view.list_orderDetails.Tag as TableModel; // lay ban dang dc chon
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần in hóa đơn.", "Chú ý");
                return;
            }
            if (table.Status.Equals("0"))
            {
                MessageBox.Show("Bàn này chưa gọi món.", "Chú ý");
                return;
            }
            BillData billData = new BillData();
            SaleModel sale = (SaleModel)view.cb_sales.SelectedItem;
            if (sale == null)
            {
                MessageBox.Show("Vui lòng chọn chương trình giảm giá.", "Chú ý");
                return;
            }
            OrderModel order = await table.GetOrderUnChecked(client);
            billData.orderId = order.ID;
            billData.checkin = order.CreatedDate;
            billData.checkout = DateTime.Now;
            billData.tableName = table.Name;
            billData.sale = sale;
            billData.totalPrice = view.Text_totalPrice.Text;
            PDFUtil.PrintingBill(view.list_orderDetails, billData);
        }

        private async void switchTable(object sender, EventArgs e)
        {
            TableModel currentTable = view.list_orderDetails.Tag as TableModel; // lay ban dang dc chon
            TableModel selectedTable = (TableModel)view.cb_switchTable.SelectedItem;
            if (currentTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn chuyển.", "Chú ý");
                return;
            }
            if (currentTable.Status.Equals("0"))
            {
                MessageBox.Show("Bàn này hiện tại đang trống, không có gì để chuyển.", "Chú ý");
                return;
            }
            if (currentTable.ID == selectedTable.ID)
            {
                MessageBox.Show("Không thể chuyển 2 bàn trùng nhau.", "Chú ý");
                return;
            }
            if (selectedTable.Status.Equals("1"))
            {
                MessageBox.Show(selectedTable.Name + " hiện đang có người, không thể chuyển qua bàn này.", "Chú ý");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn muốn chuyền từ " + currentTable.Name.ToLower() + " sang " + selectedTable.Name.ToLower() + "? ", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OrderModel order = await currentTable.GetOrderUnChecked(client);
                order.Table = selectedTable;
                order.ModifiedBy = LoginInfo.Username;
                order = await order.Update(client);
                if (order != null)
                {
                    MessageBox.Show("Chuyển " + currentTable.Name.ToLower() + " sang " + selectedTable.Name.ToLower() + " thành công", "Thông báo");
                    currentTable.Status = "0";
                    await currentTable.Update(client);
                    selectedTable.Status = "1";
                    await selectedTable.Update(client);
                    List<TableModel> tables = await selectedTable.GetTables(client);
                    view.loadTables(getButtonsTables(tables, view.cb_showTable.SelectedIndex));
                    showOrder(currentTable);
                }
            }
        }

        private async void cb_sales_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            SaleModel saleSelected = cb.SelectedItem as SaleModel;

            if (string.IsNullOrEmpty(view.Text_totalPrice.Text)) return;

            TableModel table = view.list_orderDetails.Tag as TableModel; // lay ban dang dc chon
            OrderModel currentOrder = await table.GetOrderUnChecked(client);
            List<OrderDetailModel> orderDetails = await currentOrder.GetOrderDetails(client);
            if (orderDetails.Count == 0)
            {
                MessageBox.Show("Bàn này chưa gọi món, vui lòng hủy bàn hoặc thêm món.", "Chú ý");
                view.cb_sales.SelectedIndex = -1;
                return;
            }
            long totalPrice = 0;
            foreach (OrderDetailModel o in orderDetails)
                totalPrice += o.Quantity * o.UnitPrice;
            totalPrice = totalPrice - totalPrice * saleSelected.Discount / 100;
            CultureInfo culture = new CultureInfo("vi-VN");
            view.Text_totalPrice.Text = totalPrice.ToString("c0", culture);
        }

        private async void payOrder(object sender, EventArgs e)
        {
            TableModel table = view.list_orderDetails.Tag as TableModel; // lay ban dang dc chon
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn cần thanh toán.", "Chú ý");
                return;
            }
            if (table.Status.Equals("0"))
            {
                MessageBox.Show("Bàn này không có đơn hàng cần thanh toán.", "Chú ý");
                return;
            }
            if (view.cb_sales.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn chương trình giảm giá.", "Chú ý");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thanh toán hóa đơn " + table.Name.ToLower() + "?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                OrderModel currentOrder = await table.GetOrderUnChecked(client);
                SaleModel sale = (SaleModel)view.cb_sales.SelectedItem;
                currentOrder.Sale = sale;
                currentOrder.ModifiedBy = LoginInfo.Username;
                currentOrder = await currentOrder.Pay(client);
                if (currentOrder != null)
                {
                    MessageBox.Show("Thanh toán " + table.Name.ToLower() + " thành công.");
                    table.Status = "0";
                    await table.Update(client);
                    List<TableModel> tables = await table.GetTables(client);
                    view.loadTables(getButtonsTables(tables, view.cb_showTable.SelectedIndex));
                    showOrder(table);
                }
                else
                {
                    MessageBox.Show("Bàn này chưa gọi món, vui lòng hủy bàn hoặc thêm món.", "Chú ý");
                    return;
                }
            }
        }

        private async void cancelTable(object sender, EventArgs e)
        {
            TableModel table = view.list_orderDetails.Tag as TableModel; // lay ban dang dc chon
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn muốn hủy.", "Chú ý");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn hủy " + table.Name.ToLower() + "?", "Chú ý", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool result = await table.CancelTable(client);
                if (result)
                {
                    MessageBox.Show("Hủy " + table.Name.ToLower() + " thành công.", "Thông báo");
                    List<TableModel> tables = await table.GetTables(client);
                    view.loadTables(getButtonsTables(tables, view.cb_showTable.SelectedIndex));
                    showOrder(table);
                }
                else
                    MessageBox.Show("Hủy thất bại, bàn này chưa gọi món.", "Thông báo");
            }
        }

        private async void cb_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;
            CategoryModel categorySelected = cb.SelectedItem as CategoryModel;
            List<FoodModel> food = await categorySelected.GetFoodByCategoryId(client);
            view.loadFoodByCategory(getButtonsFood(food));
        }

        private Button[] getButtonsFood(List<FoodModel> food)
        {
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
                btns_food[i].Font = new Font("Tahoma", 12f);
                btns_food[i].Click += btns_foodClick;
                btns_food[i].Tag = food[i];
            }
            return btns_food;
        }

        private void btns_foodClick(object sender, EventArgs e)
        {
            FoodModel food = (sender as Button).Tag as FoodModel;
            addFoodToOrder(food);
        }

        private async void addFoodToOrder(FoodModel food)
        {
            TableModel table = view.list_orderDetails.Tag as TableModel; // lay ban dang dc chon
            if (table == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Chú ý");
                return;
            }
            if (string.IsNullOrEmpty(view.Quantity.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng.", "Chú ý");
                return;
            }
            int quantity = Int32.Parse(view.Quantity.Text);
            string inde = (string)view.Cb_IndeQuantity.SelectedItem;
            OrderDetailModel orderDetail = new OrderDetailModel();
            orderDetail.Quantity = inde.Equals("+") ? quantity : quantity * -1;
            orderDetail.Food = food;
            if (table.Status.Equals("0")) // ban trong -> tao order va them order detail
            {
                if (orderDetail.Quantity < 1)
                {
                    MessageBox.Show("Số lượng phải là số dương.", "Chú ý");
                    return;
                }
                OrderModel order = new OrderModel();
                order.SetUnChecked();
                order = await table.CreateOrder(client, order);
                if (order != null)
                {
                    table.Status = "1";
                    await order.CreateOrderDetail(client, orderDetail);
                    await table.Update(client);
                    List<TableModel> tables = await new TableModel().GetTables(client);
                    view.loadTables(getButtonsTables(tables, view.cb_showTable.SelectedIndex));
                    view.loadTableToSwitch(tables);
                }

            }
            else // co nguoi -> them orderdetail
            {
                OrderModel currentOrder = await table.GetOrderUnChecked(client);
                await currentOrder.CreateOrderDetail(client, orderDetail);
            }
            showOrder(table);
            view.Quantity.Text = "";
        }

        private Button[] getButtonsTables(List<TableModel> tables, int status)
        {
            switch (status)
            {
                case 0:
                    break;
                case 1:
                    tables.RemoveAll(e => e.Status.Equals("1"));
                    break;
                case 2:
                    tables.RemoveAll(e => e.Status.Equals("0"));
                    break;
                case 3:
                    tables.Sort((x, y) => x.Seats.CompareTo(y.Seats));
                    break;
                case 4:
                    tables.Sort((x, y) => y.Seats.CompareTo(x.Seats));
                    break;
            }
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
                btns_table[i].Click += btns_tableClick;
                btns_table[i].Tag = tables[i];
            }
            return btns_table;
        }

        private async void btns_tableClick(object sender, EventArgs e)
        {
            TableModel table = (sender as Button).Tag as TableModel;
            // khi click vao 1 ban thi phai biet dang o ban nao, thi moi them mon an duoc, vi chi co 1 list view nen dung listview nay de biet table nao dang dc chon
            view.list_orderDetails.Tag = (sender as Button).Tag;
            view.CurrentTable.Text = table.Name;
            showOrder(table);
        }

        private async void showOrder(TableModel table)
        {
            view.cb_sales.SelectedIndex = -1;
            long totalPrice = 0;
            CultureInfo culture = new CultureInfo("vi-VN");
            view.clearOrder();
            // Neu ban dang trong => khong co order
            if (table.Status.Equals("0"))
                return;
            OrderModel currentOrder = await table.GetOrderUnChecked(client);
            if (currentOrder != null)
            {
                List<OrderDetailModel> orderDetails = await currentOrder.GetOrderDetails(client);
                foreach (OrderDetailModel item in orderDetails)
                {
                    ListViewItem lsvItem = new ListViewItem(item.Food.Name.ToString());
                    lsvItem.SubItems.Add(item.Quantity.ToString());
                    lsvItem.SubItems.Add(item.UnitPrice.ToString("c0", culture));
                    long totalPriceItem = item.Quantity * item.UnitPrice;
                    totalPrice += totalPriceItem;
                    lsvItem.SubItems.Add(totalPriceItem.ToString("c0", culture));
                    view.List_orderDetails.Items.Add(lsvItem);
                }
            }
            view.Text_totalPrice.Text = totalPrice.ToString("c0", culture);
        }
    }
}

