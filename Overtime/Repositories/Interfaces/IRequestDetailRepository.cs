using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories.Interfaces
{
    public interface IRequestDetailRepository
    {
        List<RequestDetail> Get();
        RequestDetail Get(int id);
        List<RequestDetail> Get(string value);
        bool Insert(RequestDetailVM requestdetailVM);
        bool Update(int id, RequestDetailVM requestdetailVM);
        bool Delete(int id);
    }
}
