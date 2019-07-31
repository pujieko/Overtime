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
        bool status = false;
        // constructor
        ApplicationContext applicationContext = new ApplicationContext();
        public bool Delete(int id)
        {
            var get = Get(id);
            if(get != null)
            {
                get.Delete(); // parsing untuk didelete
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
            
        }

        public List<Role> Get()
        {
            // context dulu, name table, kondisi
            var get = applicationContext.Roles.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<Role> Get(string value)
        {
            var get = applicationContext.Roles.Where(x => x.IsDelete == false && (x.Id.ToString().Contains(value) || x.Name.Contains(value))).ToList();
            return get;
        }

        public Role Get(int id)
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
            // untuk mengambil data by Id terlebih dahulu sebelum update data
            var get = Get(id);
            if(get != null)
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
    }
}
