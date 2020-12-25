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
            AccountProfile accountProfile = new AccountProfile();
            accountProfile.Show();
        }

        private void menuItem_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
