using Overtime.Context;
using Overtime.Models;
using Overtime.Repositories.Interfaces;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories
{
    public  class RequestDetailRepository : IRequestDetailRepository
    {
        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();
        private RequestDetailVM requestdetailVM;
        public List<RequestDetail> Get()//Get all
        {
            var get = applicationContext.RequestDetails.Include("OvertimeRequest").Where(x => x.IsDelete == false).ToList(); //<< JOIN TABLE OvertimeRequest
            return get; //Contextnya,nama table, kondisi
        }
        public List<RequestDetail> Get(string value)//Get by Value String
        {
            var get = applicationContext.RequestDetails.Where(x => (x.StartTime.Contains(value) || x.EndTime.Contains(value) || x.Activity.Contains(value) || x.Id.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }
        public RequestDetail Get(int id)//Get by Id
        {
            var get = applicationContext.RequestDetails.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }
        public bool Insert(RequestDetailVM requestdetailVM)
        {
            var push = new RequestDetail(requestdetailVM);
            //var getOvertimeRequest = applicationContext.OvertimeRequests.SingleOrDefault(x => x.IsDelete == false && x.Id == requestdetailVM.OvertimeRequestId);
            //push.OvertimeRequest = getOvertimeRequest;
            applicationContext.RequestDetails.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
        public bool Update(int id, RequestDetailVM requestdetailVM)
        //=================================================
        // {
        //Untuk mengambil data By Id  sebelum di Update
        //   var get = Get(id);
        // get.Update(requestdetailVM);
        // applicationContext.Entry(get).State = EntityState.Modified;
        // var result = applicationContext.SaveChanges();
        // return result > 0;
        // }
        //=================================================
        {
            //Untuk mengambil data By Id
            var get = Get(id);
            if (get != null)
            {
                get.Update(requestdetailVM);
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
