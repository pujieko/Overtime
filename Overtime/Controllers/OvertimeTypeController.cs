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
    public class OvertimeTypeController
    {
        IOvertimeTypeRepository iOvertimeTypeRepository = new OvertimeTypeRepository();
        public List<OvertimeType> Get()
        {
            return iOvertimeTypeRepository.Get();
        }
        public OvertimeType Get(int id) //Method untuk menampilkan berdasarkan ID
        {
            return iOvertimeTypeRepository.Get(id);
        }
        public List<OvertimeType> Get(string value) //Method untuk menampilkan data sesuai dengan nilai yang dicari
        {
            return iOvertimeTypeRepository.Get(value);

        }
        public bool Insert(OvertimeTypeVM overtimetypeVM)
        {
            return iOvertimeTypeRepository.Insert(overtimetypeVM);
        }
        public bool Update(int id, OvertimeTypeVM overtimetypeVM)
        {
            return iOvertimeTypeRepository.Update(id, overtimetypeVM);
        }
        public bool Delete(int id)
        {
            return iOvertimeTypeRepository.Delete(id);
        }

    }
}
