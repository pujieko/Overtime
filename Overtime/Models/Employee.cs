using Overtime.Core;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Models
{
    public class Employee : BaseModel
    {
        public Employee() { } // constructor
        public Employee(EmployeeVM employeeVM)
        {
            this.Name = employeeVM.Name;
            this.PhoneNumber = employeeVM.PhoneNumber;
            this.Gender = employeeVM.Gender;
            this.Address = employeeVM.Address;
            this.Salary = employeeVM.Salary;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public void Update(EmployeeVM employeeVM)
        {
            this.Name = employeeVM.Name;
            this.PhoneNumber = employeeVM.PhoneNumber;
            this.Gender = employeeVM.Gender;
            this.Address = employeeVM.Address;
            this.Salary = employeeVM.Salary;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;

        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
        public string Name { get; internal set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public Employee Manager { get; set; }
        //public Employee Department { get; set; }
    }
}
