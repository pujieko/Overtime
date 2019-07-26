using Overtime.Core;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Models
{
    public class Role : BaseModel
    {
        public Role() { } // constructor
        public Role(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
        }

        public void Update(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
        }

        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

        public string Name { get; set; }
    }
}
