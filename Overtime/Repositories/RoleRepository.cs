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
    public class RoleRepository : IRoleRepository
    {
        bool status = false; //Membuat variable status false
        //Membuat Objek
        ApplicationContext applicationContext = new ApplicationContext();


        public List<Role> Get()//Get all
        {
            var get = applicationContext.Roles.Where(x => x.IsDelete == false).ToList();
            return get; //Contextnya,nama table, kondisi
        }

        public List<Role> Get(string value)//Get by Value String
        {
            var get = applicationContext.Roles.Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public Role Get(int id)//Get by Id
        {
            var get = applicationContext.Roles.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(RoleVM roleVM)
        {
            var push = new Role(roleVM);
            applicationContext.Roles.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, RoleVM roleVM)
        {
            //Untuk mengambil data By Id
            var get = Get(id);
            if (get != null)
            {
                get.Update(roleVM);
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
