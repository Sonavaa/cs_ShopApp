using Shop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IProductService
    {
        public void Menu();
        public void Create();
        public void ShowProducts();
        public void GetProductsById();
    }
}