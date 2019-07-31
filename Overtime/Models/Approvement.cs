using Overtime.Core;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Models
{
    public class Approvement : BaseModel
    {
        public Approvement() { }
        public Approvement(ApprovementVM approvementVM)
        {
            this.ManagerName = approvementVM.ManagerName;
            this.DateApproveMgr = approvementVM.DateApproveMgr;
            this.ApproveManager = approvementVM.ApproveManager;
            this.DateApproveFin = approvementVM.DateApproveFin;
            this.ApproveFinance = approvementVM.ApproveFinance;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(ApprovementVM approvementVM) // Pembuatan Constructor untuk Update
        {
            this.ManagerName = approvementVM.ManagerName;
            this.DateApproveMgr = approvementVM.DateApproveMgr;
            this.ApproveManager = approvementVM.ApproveManager;
            this.DateApproveFin = approvementVM.DateApproveFin;
            this.ApproveFinance = approvementVM.ApproveFinance;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }

        public string ManagerName { get; set; }
        public DateTime? DateApproveMgr { get; set; }
        public string ApproveManager { get; set; }
        public string FinanceName { get; set; }
        public DateTime? DateApproveFin { get; set; }
        public string ApproveFinance { get; set; }
        public OvertimeRequest OvertimeRequest { get; set; }
    }
}
