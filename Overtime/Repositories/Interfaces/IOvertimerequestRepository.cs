using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories.Interfaces
{
    public interface IOvertimeRequestRepository
    {
        List<OvertimeRequest> Get();
        OvertimeRequest Get(int id);
        List<OvertimeRequest> Get(string value);
        bool Insert(OvertimeRequestVM overtimerequestVM);
        bool Update(int id, OvertimeRequestVM overtimerequestVM);
        bool Delete(int id);
    }
}
