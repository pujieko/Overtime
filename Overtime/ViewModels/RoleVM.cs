using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
    public class RoleVM
    {
        public string Name { get; internal set; }

        public RoleVM() { } //consctructor
        public RoleVM(string name)
        {
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
