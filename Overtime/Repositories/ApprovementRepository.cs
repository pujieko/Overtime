using Overtime.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.Models;
using Overtime.ViewModels;
using Overtime.Context;
using System.Data.Entity;

namespace Overtime.Repositories
{
    public class ApprovementRepository : IApprovementRepository
    {
        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();


        public List<Approvement> Get()//Get all
        {
            var get = applicationContext.Approvements.Include("OvertimeRequest").Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        public List<Approvement> Get(string value)//Get by Value String
        {
            var get = applicationContext.Approvements.Where(x => (x.Id.ToString().Contains(value) || x.ManagerName.Contains(value) || x.DateApproveMgr.ToString().Contains(value) || x.ApproveManager.Contains(value) || x.DateApproveFin.ToString().Contains(value) || x.ApproveFinance.Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public Approvement Get(int id)//Get by Id
        {
            var get = applicationContext.Approvements.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(ApprovementVM approvementVM)
        {
            var push = new Approvement(approvementVM);
            var getOvertimeRequest = applicationContext.OvertimeRequests.SingleOrDefault(x => x.IsDelete == false && x.Id == approvementVM.OvertimeRequestId);
            push.OvertimeRequest = getOvertimeRequest;
            applicationContext.Approvements.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, ApprovementVM approvementVM)
        {
            //Untuk mengambil data By Id
            var get = Get(id);
            if (get != null)
            {
                get.Update(approvementVM);
                var getOvertimeRequest = applicationContext.OvertimeRequests.SingleOrDefault(x => x.IsDelete == false && x.Id == approvementVM.OvertimeRequestId);
                get.OvertimeRequest = getOvertimeRequest;
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;

            }
            else
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete(); // Parsing
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
