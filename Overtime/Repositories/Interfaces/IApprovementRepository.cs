using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories.Interfaces
{
    public interface IApprovementRepository
    {
        List<Approvement> Get();
        Approvement Get(int id);
        List<Approvement> Get(string value);
        bool Insert(ApprovementVM approvementVM);
        bool Update(int id, ApprovementVM approvementVM);
        bool Delete(int id);
    }
}