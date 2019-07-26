using Overtime.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.Models;
using Overtime.ViewModels;
using System.Data.Entity;
using Overtime.Context;

namespace Overtime.Repositories
{
    public class OvertimeTypeRepository : IOvertimeTypeRepository
    {
        bool status = false;
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();
        private OvertimeTypeVM overtimetypeVM;

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete(); // Parsing
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public List<OvertimeType> Get()//Get all
        {
            var get = applicationContext.OvertimeTypes.Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        public List<OvertimeType> Get(string value)//Get by Value String
        {
            var get = applicationContext.OvertimeTypes.Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public OvertimeType Get(int id)//Get by Id
        {
            var get = applicationContext.OvertimeTypes.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(OvertimeTypeVM overtimetypeVM)
        {
            var push = new OvertimeType(overtimetypeVM);
            applicationContext.OvertimeTypes.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, OvertimeTypeVM userVM)
        {
            //Untuk mengambil data By Id  sebelum di Update
            var get = Get(id);
            get.Update(overtimetypeVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
