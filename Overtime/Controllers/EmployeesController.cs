using Overtime.Models;
using Overtime.Repositories;
using Overtime.Repositories.Interfaces;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Controllers
{
    public class EmployeesController
    {
        IEmployeeRepository iEmployeeRepository = new EmployeeRepository();

        public List<Employee> Get()
        {
            return iEmployeeRepository.Get();
        }

        public Employee Get(int id)
        {
            return iEmployeeRepository.Get(id);
        }

        public List<Employee> Get(string value)
        {
            return iEmployeeRepository.Get(value);
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            return iEmployeeRepository.Insert(employeeVM);
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            return iEmployeeRepository.Update(id, employeeVM);
        }

        public bool Delete(int id)
        {
            return iEmployeeRepository.Delete(id);
        }

    }
}
