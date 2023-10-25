
using Shop.Core.Enum;

namespace Shop.Core.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get => _id; set { } } 
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductTypeEnum Category { get; set; }
        public int StockCount { get; set; }
        public Product()
        {
            _id++;
        }
        public Product(int id, string name, double price, ProductTypeEnum category, int stockCount)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.StockCount = stockCount;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Category: {Category}, StockCount: {StockCount}";
        }

    }
}
