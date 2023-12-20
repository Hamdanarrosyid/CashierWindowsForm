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
        public int Create(Product product)
        {
            return repository.Create(product);
        }
        public List<Product> GetAll(string filterName = "")
        {
            return repository.GetAll(filterName);
        }

        public int Update(Product product)
        {
            return repository.Update(product);
        }

        public int Delete(int productId)
        {
            return repository.Delete(productId);
        }


        public Product Get(int productId)
        {
            return repository.Get(productId);
        }


    }
}
