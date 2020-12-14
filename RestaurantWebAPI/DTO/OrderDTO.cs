using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class OrderDTO : AbstractDTO
    {
        private long totalPrice;
        private long tableId;
        private long userId;
        private int status;

        public long TotalPrice { get => totalPrice; set => totalPrice = value; }
        public long TableId { get => tableId; set => tableId = value; }
        public long UserId { get => userId; set => userId = value; }
        public int Status { get => status; set => status = value; }
    }
}