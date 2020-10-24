using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStoreCoreApplication.Controllers.Infrastructure.Interfaces;

namespace WebStoreCoreApplication.Controllers
{
    
    public class CatalogController : Controller
    {
        private readonly IProductServices _productServices;

        public CatalogController(IProductServices productService)
        {
            _productServices = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }
    }
}
