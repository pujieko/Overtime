using Overtime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Overtime.ViewModels
{
    public class RequestDetailVM
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Status { get; set; }
        public string UploadFile { get; set; }
        //public Image UploadFile { get; set; }
        public string Activity { get; set; }
        public int OvertimeRequestId { get; set; }
        public RequestDetailVM() { }
        public RequestDetailVM(string starttime, string endtime, string status, string uploadfile, string activity, /*byte[] imagetobyte*/ int overtimerequestid)
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.Status = status;
            this.UploadFile = uploadfile;
            this.Activity = activity;
            //this.ImageToByte = imagetobyte;
            this.OvertimeRequestId = overtimerequestid;
        }
        public void Update(string starttime, string endtime, string status, string uploadfile,string activity,/*byte[] imagetobyte*/int overtimerequestid) // Pembuatan Constructor untuk Update
        {
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.Status = status;
            this.UploadFile = uploadfile;
            this.Activity = activity;
            //this.ImageToByte = imagetobyte;
            this.OvertimeRequestId = overtimerequestid;
        }
    }
}
