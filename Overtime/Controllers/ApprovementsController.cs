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
    public class ApprovementsController
    {
        IApprovementRepository iApprovementRepository = new ApprovementRepository();

        public List<Approvement> Get()
        {
            return iApprovementRepository.Get();
        }

        public Approvement Get(int id)
        {
            return iApprovementRepository.Get(id);
        }

        public List<Approvement> Get(string value)
        {
            return iApprovementRepository.Get(value);
        }

        public bool Insert(ApprovementVM approvementVM)
        {
            return iApprovementRepository.Insert(approvementVM);
        }

        public bool Update(int id, ApprovementVM approvementVM)
        {
            return iApprovementRepository.Update(id, approvementVM);
        }

        public bool Delete(int id)
        {
            return iApprovementRepository.Delete(id);
        }
    }
}
