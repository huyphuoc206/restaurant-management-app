
namespace RestaurantApp.View


{
    using System;
    using System.Windows.Forms;
 
    partial class User
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Label();
            this.panel_bill = new System.Windows.Forms.Panel();
            this.label_order = new System.Windows.Forms.Label();
            this.panel_table = new System.Windows.Forms.Panel();
            this.label_table = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel_bill.SuspendLayout();
            this.panel_table.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 

            //Thêm bàn phím ghi số lượng
            loadQuantityFood(btns_quantity);
            this.Controls.AddRange(btns_quantity);


            this.panel_menu.Controls.Add(this.button_clear);
            this.panel_menu.Controls.Add(this.quantity);
            this.panel_menu.Controls.Add(this.label_quantity);
            this.panel_menu.Controls.Add(this.label_menu);
            this.panel_menu.Location = new System.Drawing.Point(315, 23);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(630, 715);
            this.panel_menu.TabIndex = 0;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(391, 35);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 30);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Xóa";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(300, 35);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(31, 13);
            this.quantity.TabIndex = 0;
        
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
           // this.label_quantity.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(242, 35);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(75, 30);
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
            this.panel_bill.Controls.Add(this.label_order);
            this.panel_bill.Location = new System.Drawing.Point(951, 23);
            this.panel_bill.Name = "panel_bill";
            this.panel_bill.Size = new System.Drawing.Size(300, 715);
            this.panel_bill.TabIndex = 0;
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
            this.panel_table.Location = new System.Drawing.Point(12, 23);
            this.panel_table.Name = "panel_table";
            this.panel_table.Size = new System.Drawing.Size(300, 715);
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
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.panel_table);
            this.Controls.Add(this.panel_bill);
            this.Controls.Add(this.panel_menu);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_bill.ResumeLayout(false);
            this.panel_bill.PerformLayout();
            this.panel_table.ResumeLayout(false);
            this.panel_table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        public void loadQuantityFood(Button[] btns_quantity)
        {
            for(int i = 0; i < 10; i++)
            {
                int y =5 +60*(i + 1);
                btns_quantity[i] = new Button();
                btns_quantity[i].SetBounds(320, y, 50, 50);
                btns_quantity[i].Text = "" + i;
                btns_quantity[i].Click += new System.EventHandler(btns_quantity_click);
            }
        }
        public void 
    



        private Panel panel_menu;
        private Label label_menu;
        private Panel panel_bill;
        private Label label_order;
        private Panel panel_table;
        private Label label_table;
        private Label quantity;
        private Label label_quantity;
        private Button[] btns_quantity = new Button[10];
        private Button button_clear;
    }
}