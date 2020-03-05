using ReactSimple.WebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactSimple.WebApi.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
