using ReactSimple.WebApi.Domain.Entities;
using ReactSimple.WebApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSimple.WebApi.Services
{
    public class CategoryManager : ICategoryService
    {
        private DataContext context;

        public CategoryManager(DataContext context)
        {
            this.context = context;
        }

        
        public List<Category> GetCategories()
        {
            var categories = context.Categories.ToList();
            return categories;
        }
    }
}
