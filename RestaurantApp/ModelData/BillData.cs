using RestaurantApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ModelData
{
    public class BillData
    {
        public long orderId;
        public static string RESTAURANT_NAME = "Nong Lam Restaurant";
        public static string address = "Phường Linh Trung, Thành phố Thủ Đức, TP.HCM";
        public string tableName;
        public SaleModel sale;
        public string totalPrice;
        public DateTime checkin;
        public DateTime checkout;
    }
}
