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
    public class SiteRepository : ISiteRepository
    {
        bool status = false;
        // constructor
        ApplicationContext applicationContext = new ApplicationContext();
        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
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

        public List<Site> Get()
        {
            // context dulu, name table, kondisi
            var get = applicationContext.Sites.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<Site> Get(string value)
        {
            var get = applicationContext.Sites.Where(x => x.IsDelete == false && (x.Id.ToString().Contains(value) || x.Name.Contains(value) || x.Address.Contains(value))).ToList();
            return get;
        }

        public Site Get(int id)
        {
            var get = applicationContext.Sites.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(SiteVM siteVM)
        {
            var push = new Site(siteVM);
            applicationContext.Sites.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, SiteVM siteVM)
        {
            // untuk mengambil data by Id terlebih dahulu sebelum update data
            var get = Get(id);
            if(get!= null)
            {
                get.Update(siteVM);
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
