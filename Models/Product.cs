using XXR_Nutrition.Data.Enum;

namespace XXR_Nutrition.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
