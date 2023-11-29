namespace OcelotProject.Model
{
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public int sellerId { get; set; }
    }
}
