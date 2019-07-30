using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.ViewModels
{
    public class ApprovementVM
    {
        public string ManagerName { get; set; }
        public DateTime? DateApproveMgr {get; set; }
        public string ApproveManager { get; set; }
        public string FinanceName { get; set; }
        public DateTime? DateApproveFin { get; set; }
        public string ApproveFinance { get; set; }
        public int OvertimeRequestId { get; set; } 

        public ApprovementVM() { } // constructor
        public ApprovementVM(string managername, DateTime? dateapprovemgr, string approvemanager, string financename, DateTime? dateapprovefin, string approvefinance, int overtimerequestId)
        {
            this.ManagerName = managername;
            this.DateApproveMgr = dateapprovemgr;
            this.ApproveManager = approvemanager;
            this.DateApproveFin = dateapprovefin;
            this.ApproveFinance = approvefinance;
            this.OvertimeRequestId = overtimerequestId;
        }

        public void Update(string managername, DateTime? dateapprovemgr, string approvemanager, string financename, DateTime? dateapprovefin, string approvefinance, int overtimerequestId)
        {
            this.ManagerName = managername;
            this.DateApproveMgr = dateapprovemgr;
            this.ApproveManager = approvemanager;
            this.DateApproveFin = dateapprovefin;
            this.ApproveFinance = approvefinance;
            this.OvertimeRequestId = overtimerequestId;
        }
    }
}
