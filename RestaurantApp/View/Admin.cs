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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            LoadDateTimerAllBill();
        }
        void LoadDateTimerAllBill()
        {
            DateTime today = DateTime.Now;
            dtp_fromdate.Value = new DateTime(today.Year, today.Month, 1);
            dtp_todate.Value = dtp_fromdate.Value.AddMonths(1).AddDays(-1);

        }
    }
}
