using Overtime.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Context
{
    //Application Context berfungsi untuk mengkoneksikan ke Dbase
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("Overtime") { }

        public DbSet<Site> Sites { get; set; } 

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<OvertimeRequest> OvertimeRequests { get; set; }
        public DbSet<Approvement> Approvements { get; set; }
    }
}
