using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierWindowsForm.controllers
{
    public class ProductController
    {
        private readonly ProductRepository repository = new ProductRepository();
        private readonly BrandRepository brandRepository = new BrandRepository();
        public int CreateProduct(Product product)
        {
            return repository.Create(product);
        }
        public List<Product> Read()
        {
            return repository.ReadAll();
        }

        public int CreateBrand(Brand brand)
        {
            return brandRepository.Create(brand);
        }

       
    }
}
