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
   public  class RequestDetailsController
    {
        IRequestDetailRepository iRequestDetailRepository = new RequestDetailRepository();
        public List<RequestDetail> Get()
        {
            return iRequestDetailRepository.Get();
        }
        public RequestDetail Get(int id) //Method untuk menampilkan berdasarkan ID
        {
            return iRequestDetailRepository.Get(id);
        }
        public List<RequestDetail> Get(string value) //Method untuk menampilkan data sesuai dengan nilai yang dicari
        {
            return iRequestDetailRepository.Get(value);

        }
        public bool Insert(RequestDetailVM userVM)
        {
            return iRequestDetailRepository.Insert(userVM);
        }
        public bool Update(int id, RequestDetailVM requestdetailVM)
        {
            return iRequestDetailRepository.Update(id, requestdetailVM);
        }
        public bool Delete(int id)
        {
            return iRequestDetailRepository.Delete(id);
        }

    }
}
