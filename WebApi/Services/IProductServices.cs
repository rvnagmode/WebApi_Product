using WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public interface IProductServices
    {
         IEnumerable<Product> GetAllProduct();
         int AddProduct(Product prod);
         int ModifyProduct(Product prod);
         int DeleteProduct(int id);
    }
}
