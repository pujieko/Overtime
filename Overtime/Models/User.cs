using Overtime.Core;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; } //<<<<< UNTUK MEMBUAT RELASI FOREIGN KEY KE TABLE ROLE
        public User() { }
        public User(UserVM userVM)//Pembuatan constructor untuk insert
        {
            this.Email = userVM.Email;
            this.Password = userVM.Password;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(UserVM userVM) // Pembuatan Constructor untuk Update
        {
            this.Email = userVM.Email;
            this.Password = userVM.Password;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

        //CONNECT FOREIGN KEY 


    }
}
