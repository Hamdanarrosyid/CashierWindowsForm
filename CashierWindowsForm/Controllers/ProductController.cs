using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.controllers
{
    internal class ProductController
    {
        private readonly ProductRepository repository = new ProductRepository();
        public int CreateProduct(Product product)
        {
            return repository.Create(product);
        }
        public List<Product> Read()
        {
            return repository.ReadAll();
        }
    }
}
