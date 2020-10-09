using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStoreCoreApplication.ViewModels;

namespace WebStoreCoreApplication.Controllers
{
    public class BaseController : Controller
    {
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                Name = "Петр",
                SName = "Петров",
                FName = "Петрович",
                Age = 33,
                Position ="BOSS"
            },
            new EmployeeViewModel
            {
                Id = 2,
                Name = "Фёдр",
                SName = "Фёдоров",
                FName = "Фёдорович",
                Age = 25,
                Position ="Программист"}
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View(_employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employeeviewmodel = _employees.FirstOrDefault(x => x.Id == id);
            if (employeeviewmodel == null) return NotFound();
            return View(employeeviewmodel);
        }
    }
}