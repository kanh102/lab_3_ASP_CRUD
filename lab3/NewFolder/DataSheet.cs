using lab3.Models;

namespace lab3.NewFolder
{
    public class DataSheet
    {
        // gia lap csdl
        public static List<Category> categories = new List<Category>()
        {
            new Models.Category { Id = 1, Name = "Laptop" },
            new Models.Category { Id = 2, Name = "Phone" },
            new Models.Category { Id = 3,Name = "Tablet" },
        };

        public static List<Models.Product> products = new List<Models.Product>()
        {
            new Models.Product {Id = 1, Name = "iphone", Price = "18", Description ="so re lam"},
            new Models.Product {Id = 2, Name = "ss", Price = "20", Description ="bth"},
            new Models.Product {Id = 3, Name = "oppo", Price = "7", Description ="k dang gia cao"},
            new Models.Product {Id = 4, Name = "Honro", Price = "12", Description ="cung duoc ma"},
            new Models.Product {Id = 5, Name = "redmi", Price = "14", Description ="chong nuoc, chong bui"},

        };
    }
}
