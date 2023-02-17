namespace Saltazon.Api.Models
{
    public class ProductRegisterRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int StoreId { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }
}
