using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreCoreApplication.Controllers.Infrastructure.Interfaces;
using WebStoreCoreApplication.ViewModels;

namespace WebStoreCoreApplication.Controllers.Infrastructure.Services
{
    public class InMemoryEmployeeServices : IEmployeeService
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

        public void AddNew(EmployeeViewModel newmodel)
        {
            newmodel.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(newmodel);
        }

        public void Commit()
        {
            //
        }

        public void Delete(int id)
        {
            var employee = GetByID(id);
            if (employee is null) 
                return;

            _employees.Remove(employee);
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return _employees;
        }

        public EmployeeViewModel GetByID(int id)
        {
            return _employees.FirstOrDefault(e => e.Id.Equals(id));
        }
    }
}
