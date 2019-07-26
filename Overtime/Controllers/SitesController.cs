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
    public class SitesController
    {
        ISiteRepository iSiteRepository = new SiteRepository();

        public List<Site> Get()
        {
            return iSiteRepository.Get();
        }

        public Site Get(int id)
        {
            return iSiteRepository.Get(id);
        }

        public List<Site> Get(string value)
        {
            return iSiteRepository.Get(value);
        }

        public bool Insert(SiteVM siteVM)
        {
            return iSiteRepository.Insert(siteVM);
        }

        public bool Update(int id, SiteVM siteVM)
        {
            return iSiteRepository.Update(id, siteVM);
        }

        public bool Delete(int id)
        {
            return iSiteRepository.Delete(id);
        }
    }
}
