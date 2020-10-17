using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;
using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebStoreCoreApplication.Controllers.Infrastructure.Interfaces;
using WebStoreCoreApplication.ViewModels;
using WebStoreCoreApplication.Controllers;

namespace WebStoreCoreApplication.Controllers
{
    [Route("peoples")]
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Route("idx")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("all")]
        public IActionResult Employees()
        {
            return View(_employeeService.GetAll());
        }
        [Route("{id}")]
        public IActionResult EmployeeDetails(int id)
        {
            var employeeviewmodel = _employeeService.GetByID(id);
           
            if (employeeviewmodel == null) 
                return NotFound();
            
            return View(employeeviewmodel);
        }

        [Route("edit/{id?}")]
        public IActionResult Edit (int? id)
        {
            if (!id.HasValue) 
                return View(new EmployeeViewModel());
            
            var model = _employeeService.GetByID(id.Value);
            
            if (model == null)
                return NotFound();

            return View(model);
        }
    }
}