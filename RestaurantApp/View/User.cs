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

        private void btns_quantity_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            quantity.Text += btn.Text;
        }
    }
}
