using Overtime.Core;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Models
{
     public class OvertimeType : BaseModel
    {
        public string Name { get; set; }
        public string StartAvailable { get; set; }

        public OvertimeType() { }
        public OvertimeType(OvertimeTypeVM overtimetypeVM)
        {
            this.Name = overtimetypeVM.Name;
            this.StartAvailable = overtimetypeVM.StartAvailable;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(OvertimeTypeVM overtimetypeVM) // Pembuatan Constructor untuk Update
        {
            this.Name = overtimetypeVM.Name;
            this.StartAvailable = overtimetypeVM.StartAvailable;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete() // Pembuatan Constructor untuk Delete
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
