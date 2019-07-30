using Overtime.Core;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Models
{
    public class OvertimeRequest : BaseModel
    {
        public OvertimeRequest() { } // constructor
        public OvertimeRequest(OvertimeRequestVM overtimerequestVM)
        {
            this.DateOverTime = overtimerequestVM.DateOverTime;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(OvertimeRequestVM overtimerequestVM)
        {
            this.DateOverTime = overtimerequestVM.DateOverTime;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
        public DateTime? DateOverTime { get; set; }
        public Employee Employee { get; set; }
        public Site Site { get; set; }
    }
}
