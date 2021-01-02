using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class OrderModel : AbstractModel
    {
        private long totalPrice;
        private SaleModel sale;
        private TableModel table;
        private string status;

        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Status { get => status; set => status = value; }
        public SaleModel Sale { get => sale; set => sale = value; }
        internal TableModel Table { get => table; set => table = value; }
    }
}
