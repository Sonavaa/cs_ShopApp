
namespace Shop.Core.Models
{
    public class Product
    {
        private static int _id;
        public int Id { get=> _id;} 
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }
        public Product()
        {
            _id++;
        }
        public Product(string name, double price, int stockCount)
        {
            this.Name = name;
            this.Price = price;
            this.StockCount = stockCount;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, StockCount: {StockCount}";
        }

    }
}
