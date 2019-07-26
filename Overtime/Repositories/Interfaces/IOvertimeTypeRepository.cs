using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories.Interfaces
{
    public interface IOvertimeTypeRepository
    {
        //Interface hanya membuat method kosong
        List<OvertimeType> Get();
        OvertimeType Get(int id);
        List<OvertimeType> Get(string value);
        bool Insert(OvertimeTypeVM overtimetypeVM);
        bool Update(int id, OvertimeTypeVM overtimetypeVM);
        bool Delete(int id);
    }
}
