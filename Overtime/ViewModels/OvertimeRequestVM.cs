using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
    public class OvertimeRequestVM
    {
        public DateTime? DateOverTime { get; set; }
        public int EmployeeId { get; set; }
        public int SiteId { get; set; }

        public OvertimeRequestVM(DateTime? dateovertime, int employeeId, int siteId)
        {
            this.DateOverTime = dateovertime;
            this.EmployeeId = employeeId;
            this.SiteId = siteId;
        }

        public void Update(DateTime? dateovertime, int employeeId, int siteId)
        {
            this.DateOverTime = dateovertime;
            this.EmployeeId = employeeId;
            this.SiteId = siteId;
        }
    }
}
