using Service.Services.Interfaces;
using Shop.Core.Models;
using Service.Extentions;

namespace Service.Services.Implementations
{
    public class ProductService : IProductService
    {
        Product[] products = new Product[0];
        public void Menu()
        {
            Product[] products = new Product[0];
            Console.WriteLine("1.Create product");
            Console.WriteLine("2.Show products");
            Console.WriteLine("0.close");
            string Request = Console.ReadLine();
            while (Request != "0")
            {
                switch (Request)
                {
                    case "1":
                        Create();
                        break;
                    case "2":
                        ShowProducts();
                        break;
                    default:
                        Console.WriteLine("please add valid option");
                        break;
                }
                Request = Console.ReadLine();
            }
        }
        public void Create()
        {
            Console.WriteLine("Name daxil edin");
            string Name = Console.ReadLine();
            Name = Name.ValidateString();
            Console.WriteLine("Price daxil edin");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine("StockCount daxil edin");
            int StockCount = int.Parse(Console.ReadLine());
            Product product = new Product();
            product.Name= Name;
            product.Price= Price;
            product.StockCount= StockCount;
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public void ShowProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
       

        public void GetProductsById()
        {
            Console.WriteLine("Add Id");
            int id = int.Parse(Console.ReadLine());
            Product Result = default;
            foreach (Product product in products)
            {
                if (product.Id == id)
                {
                    Result = product;
                    break;
                }
            }
            if (Result != null)
            {
                Console.WriteLine($"Product not found whit {id}");

            }
            else
                Console.WriteLine(Result);

        }
    }
}

