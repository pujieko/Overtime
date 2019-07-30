using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
   public class EmployeeVM
    {
        // Apa yang dibutuhkan di View dan Model, yg diinputkan secara sadar diletakan di ViewModel
        public string Name { get; internal set; }
        public string PhoneNumber{ get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public int ManagerId { get; set; }
        public int DepartmentId { get; set; }

        public EmployeeVM() { } // constructor
        public EmployeeVM(string name, string phonenumber, string gender, string address, int salary, int managerId, int departmentid)
        {
            this.Name = name;
            this.PhoneNumber = phonenumber;
            this.Gender = gender;
            this.Address = address;
            this.Salary = salary;
            this.ManagerId = managerId;
            this.DepartmentId = departmentid;
        }

        public void Update(string name, string phonenumber, string gender, string address, int salary, int managerId, int departmentid)
        {
            this.Name = name;
            this.PhoneNumber = phonenumber;
            this.Gender = gender;
            this.Address = address;
            this.Salary = salary;
            this.ManagerId = managerId;
            this.DepartmentId = departmentid;
        }
    }
}
