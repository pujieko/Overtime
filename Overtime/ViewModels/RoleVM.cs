using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
    public class RoleVM
    {
        public string Name { get; set; }

        public RoleVM() { }
        public RoleVM(string name) // Pembuatan construct
        {
            this.Name = name;
        }
        public void Update(string name) // Pembuatan Constructor untuk Update
        {
            this.Name = name;
        }
    }
}
