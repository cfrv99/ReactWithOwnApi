using ReactSimple.WebApi.Domain.Entities;
using ReactSimple.WebApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSimple.WebApi.Services
{
    public class ProductManager : IProductService
    {
        private DataContext context;

        public ProductManager(DataContext context)
        {
            this.context = context;
        }

        public bool Add(Product product)
        {
            context.Products.Add(product);
            return context.SaveChanges() > 0;
        }

        public Product GetProduct(int id)
        {
            var product = context.Products.FirstOrDefault(i => i.Id == id);
            return product;
        }

        public List<Product> GetProducts()
        {
            var products = context.Products.ToList();
            return products;
        }

        public List<Product> GetProductsByCategory(int? caregoryId)
        {
            var products = context.Products.Where(i => i.CategoryId == caregoryId).ToList();
            return products;
        }
    }
}
