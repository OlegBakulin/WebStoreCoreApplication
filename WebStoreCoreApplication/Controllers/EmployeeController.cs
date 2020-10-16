using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStoreCoreApplication.Controllers.Infrastructure.Interfaces;
using WebStoreCoreApplication.ViewModels;

namespace WebStoreCoreApplication.Controllers
{
    [Route("peoples" +
        "")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [Route("idx")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("all")]
        public IActionResult Employees()
        {
            return View(employeeService.GetAll());
        }
        [Route("{id}")]
        public IActionResult EmployeeDetails(int id)
        {
            var employeeviewmodel = employeeService.GetByID(id);
            if (employeeviewmodel == null) return NotFound();
            return View(employeeviewmodel);
        }
    }
}