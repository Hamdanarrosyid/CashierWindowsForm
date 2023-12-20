using CashierWindowsForm.Models.Entity;
using CashierWindowsForm.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierWindowsForm.Controllers
{
    public class BrandController
    {
        private readonly BrandRepository brandRepository = new BrandRepository();

        public int Create(Brand brand)
        {
            return brandRepository.Create(brand);
        }

        public int Update(Brand brand)
        {
            return brandRepository.Update(brand);
        }

        public int Delete(int brandId)
        {
            return brandRepository.Delete(brandId);
        }

        public List<Brand> GetAll()
        {
            return brandRepository.GetAll();
        }
        public Brand Get(int id)
        {
            return brandRepository.Get(id);
        }
    }
}
