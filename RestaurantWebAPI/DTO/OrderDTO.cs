using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class OrderDTO : AbstractDTO
    {
        private long totalPrice;
        private SaleDTO sale;
        private TableDTO table;
        private int status;

        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Status { get => status; set => status = value; }
        public SaleDTO Sale { get => sale; set => sale = value; }
        public TableDTO Table { get => table; set => table = value; }
    }
}