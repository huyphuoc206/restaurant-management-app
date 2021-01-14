using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ModelData
{
    public class ReportInfo
    {
        public DateTime fromDate;
        public DateTime toDate;
        public string countOrder;
        public string totalPriceOrder;

        public ReportInfo(DateTime fromDate, DateTime toDate, string countOrder, string totalPriceOrder)
        {
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.countOrder = countOrder;
            this.totalPriceOrder = totalPriceOrder;
        }
    }
}
