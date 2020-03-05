using ReactSimple.WebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSimple.WebApi.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        List<Product> GetProductsByCategory(int? caregoryId);
        bool Add(Product product);
    }
}
