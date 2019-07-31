using Overtime.Core;
using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Overtime.Models
{
    public class RequestDetail : BaseModel
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }
        public string UploadFile { get; set; }
        public string Activity { get; set; }
        public OvertimeRequest OvertimeRequest { get; set; } //<<<<< UNTUK MEMBUAT RELASI FOREIGN KEY KE TABLE ROLE
        public RequestDetail() { }
        public RequestDetail(RequestDetailVM requestdetailVM)//Pembuatan constructor untuk insert
        {
            this.StartTime = requestdetailVM.StartTime;
            this.EndTime = requestdetailVM.EndTime;
            this.Status = requestdetailVM.Status;
            this.UploadFile = requestdetailVM.UploadFile;
            this.Activity = requestdetailVM.Activity;
            //this.ImageToByte = requestdetailVM.ImageToByte;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(RequestDetailVM requestdetailVM) // Pembuatan Constructor untuk Update
        {
            this.StartTime = requestdetailVM.StartTime;
            this.EndTime = requestdetailVM.EndTime;
            this.Status = requestdetailVM.Status;
            this.UploadFile = requestdetailVM.UploadFile;
            this.Activity = requestdetailVM.Activity;
            //this.ImageToByte = requestdetailVM.ImageToByte;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
