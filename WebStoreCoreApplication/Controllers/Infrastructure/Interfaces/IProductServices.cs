﻿using System.Collections.Generic;
using WebStoreCoreApplication.Domain.Entities;

namespace WebStoreCoreApplication.Controllers.Infrastructure.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
    }
}
