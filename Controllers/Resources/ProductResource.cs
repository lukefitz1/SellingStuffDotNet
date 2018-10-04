namespace SellingStuffDotNet.Controllers.Resources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public double Price { get; set; }
        public double SpecialPrice { get; set; }
        public int Inventory { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public double Weight { get; set; }
        public bool Status { get; set; }
        public string MainImage { get; set; }
    }
}