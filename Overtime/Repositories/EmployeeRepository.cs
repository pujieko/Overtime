using Overtime.Context;
using Overtime.Models;
using Overtime.Repositories.Interfaces;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        bool status = false;
        // constructor
        ApplicationContext applicationContext = new ApplicationContext();
        private object departmentsVM;

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete(); // parsing untuk didelete
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<Employee> Get()
        {
            // context dulu, name table, kondisi
            var get = applicationContext.Employees.Include("Manager").Include("Department").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<Employee> Get(string value)
        {
            var get = applicationContext.Employees.Where(x => x.IsDelete == false && (x.Id.ToString().Contains(value) || x.Name.Contains(value) || x.Address.Contains(value))).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            var get = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            var push = new Employee(employeeVM);
            var getManager = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.ManagerId);
            push.Manager = getManager;
            var getDepartment = applicationContext.Departments.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.DepartmentId);
            push.Department = getDepartment;
            applicationContext.Employees.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            // untuk mengambil data by Id terlebih dahulu sebelum update data
            var get = Get(id);
            if(get != null)
            {
                get.Update(employeeVM);
                var getManager = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.ManagerId);
                get.Manager = getManager;
                var getDepartment = applicationContext.Departments.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.DepartmentId);
                get.Department = getDepartment;
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
