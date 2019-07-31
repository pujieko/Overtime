using Overtime.Models;
using Overtime.Repositories;
using Overtime.Repositories.Interfaces;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Controllers
{
    public class OvertimeRequestsController
    {
        IOvertimeRequestRepository iOvertimeRequestRepository = new OvertimeRequestRepository();

        public List<OvertimeRequest> Get()
        {
            return iOvertimeRequestRepository.Get();
        }

        public OvertimeRequest Get(int id)
        {
            return iOvertimeRequestRepository.Get(id);
        }

        public List<OvertimeRequest> Get(string value)
        {
            return iOvertimeRequestRepository.Get(value);
        }

        public bool Insert(OvertimeRequestVM overtimerequestVM)
        {
            return iOvertimeRequestRepository.Insert(overtimerequestVM);
        }

        public bool Update(int id, OvertimeRequestVM overtimerequestVM)
        {
            return iOvertimeRequestRepository.Update(id, overtimerequestVM);
        }

        public bool Delete(int id)
        {
            return iOvertimeRequestRepository.Delete(id);
        }
    }
}
