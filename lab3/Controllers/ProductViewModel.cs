using lab3.Models;

namespace lab3.Controllers
{
    public class ProductViewModel
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CategorytId { get; set; } = string.Empty;
        public Category Category { get; set; } = null!;
    }
}
