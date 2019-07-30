using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
    public class OvertimeTypeVM
    {
        public string Name { get; set; }
        public string StartAvailable { get; set; }

        public OvertimeTypeVM() { }
        public OvertimeTypeVM(string name, string startavailable)
        {
            this.Name = name;
            this.StartAvailable = startavailable;
        }
        public void Update(string name, string startavailable ) // Pembuatan Constructor untuk Update
        {
            this.Name = name;
            this.StartAvailable = startavailable;
        }
    }
}
