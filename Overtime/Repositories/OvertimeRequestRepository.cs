using Overtime.Context;
using Overtime.Models;
using Overtime.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.ViewModels;
using System.Data.Entity;

namespace Overtime.Repositories
{
    public class OvertimeRequestRepository : IOvertimeRequestRepository
    {
        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();


        public List<OvertimeRequest> Get()//Get all
        {
            var get = applicationContext.OvertimeRequests.Include("Employee").Include("Site").Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        public List<OvertimeRequest> Get(string value)//Get by Value String
        {
            var get = applicationContext.OvertimeRequests.Where(x => (x.Id.ToString().Contains(value)) || x.DateOverTime.ToString().Contains(value) && x.IsDelete == false).ToList();
            return get;
        }

        public OvertimeRequest Get(int id)//Get by Id
        {
            var get = applicationContext.OvertimeRequests.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(OvertimeRequestVM overtimerequestVM)
        {
            var push = new OvertimeRequest(overtimerequestVM);
            var getEmployee = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == overtimerequestVM.EmployeeId);
            push.Employee = getEmployee;
            var getSite = applicationContext.Sites.SingleOrDefault(x => x.IsDelete == false && x.Id == overtimerequestVM.SiteId);
            push.Site = getSite;
            applicationContext.OvertimeRequests.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, OvertimeRequestVM overtimerequestVM)
        {
            //Untuk mengambil data By Id
            var get = Get(id);
            if (get != null)
            {
                get.Update(overtimerequestVM);
                var getEmployee = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == overtimerequestVM.EmployeeId);
                get.Employee = getEmployee;
                var getSite = applicationContext.Sites.SingleOrDefault(x => x.IsDelete == false && x.Id == overtimerequestVM.SiteId);
                get.Site = getSite;
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
