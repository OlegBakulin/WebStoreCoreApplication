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

        [HttpPost]
        [Route("edit/{id?}")]
        public IActionResult Edit (EmployeeViewModel employeemodel) //int? id)
        {
            if (employeemodel.Id > 0)
            {
                var dbitem = _employeeService.GetByID(employeemodel.Id);

                if (ReferenceEquals(dbitem, null))
                    return NotFound();
                dbitem.IName = employeemodel.IName;
                dbitem.FName = employeemodel.FName;
                dbitem.OName = employeemodel.OName;
                dbitem.Age = employeemodel.Age;
                dbitem.Position = employeemodel.Position;
            }
            else
            {
                _employeeService.AddNew(employeemodel);
            }
            _employeeService.Commit();
            return RedirectToAction(nameof(Employees));
            /*
            if (!id.HasValue) 
                return View(new EmployeeViewModel());
            
            var model = _employeeService.GetByID(id.Value);
            
            if (model == null)
                return NotFound();

            return View(model);
            */
        }
    }
}