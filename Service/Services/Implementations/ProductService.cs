using Service.Services.Interfaces;
using Shop.Core.Models;
using Service.Extentions;
using Shop.Core.Enum;

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
            Console.WriteLine("3.Get product by Id");
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
                    case "3":
                        GetProductsById();
                        break;
                    default:
                        Console.WriteLine("Please add valid option");
                        break;
                }
                Request = Console.ReadLine();
            }
        }
        public void Create()
        {
            Console.WriteLine("Add Name");
            string Name = Console.ReadLine();
            Name = Name.ValidateString();
            Console.WriteLine("Add Price");
            double Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose Category");
            Console.WriteLine($"1.{ProductTypeEnum.RedMeat}");
            Console.WriteLine($"2.{ProductTypeEnum.Poultry}");
            Console.WriteLine($"3.{ProductTypeEnum.Pork}");
            Console.WriteLine($"4.{ProductTypeEnum.Seafood}");
            int Category = int.Parse( Console.ReadLine());
            Console.WriteLine("Add StockCount");
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
            if (Result == null)
            {
                Console.WriteLine($"Product not found whit {id}");

            }
            else
                Console.WriteLine(Result);

        }
    }
}

