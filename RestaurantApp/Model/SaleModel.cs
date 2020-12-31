namespace RestaurantApp.Model
{
    public class SaleModel : AbstractModel
    {
        private string name;
        private int discount;
        private int status;

        public string Name { get => name; set => name = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Status { get => status; set => status = value; }
    }
}