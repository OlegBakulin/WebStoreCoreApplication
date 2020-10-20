using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreCoreApplication.Controllers.Infrastructure.Interfaces;
using WebStoreCoreApplication.Domain.Entities;

namespace WebStoreCoreApplication.Controllers.Infrastructure.Services
{
    public class InMemoryProductServices : IProductServices
    {
        public IEnumerable<Brand> GetBrands()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
