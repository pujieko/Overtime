using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
    public class UserVM
    {

       
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public UserVM() { } // constructor
        public UserVM(string email, string password, int roleid ) // Membuat constructor untuk insert
        {
            this.Email = email;
            this.Password = password;
            this.RoleId = roleid;
        }

        public void Update(string email, string password, int roleid) // Pembuatan Constructor untuk Update
        {
            this.Email = email;
            this.Password = password;
            this.RoleId = roleid;
        }
    }
}
