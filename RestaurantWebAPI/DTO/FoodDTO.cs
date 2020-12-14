using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public class FoodDTO : AbstractDTO
    {
        private string name;
        private long price;
        private int discount;
        private int status;
        private long categoryId;

        public string Name { get => name; set => name = value; }
        public long Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Status { get => status; set => status = value; }
        public long CategoryId { get => categoryId; set => categoryId = value; }
    }
}