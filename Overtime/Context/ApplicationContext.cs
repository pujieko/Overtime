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
        public DbSet<Department>  Departments { get; set; }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet <OvertimeType> OvertimeTypes { get; set; }
        
        public DbSet<Site> Sites { get; set; } 

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }
      public DbSet<RequestDetail> RequestDetails { get; set; }
    }
}
