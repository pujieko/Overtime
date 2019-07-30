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
    public class RolesController
    {
        IRoleRepository iRoleRepository = new RoleRepository();
        public List<Role> Get() //Method untuk menampilkan data keseluruhan
        {
            return iRoleRepository.Get();
        }
        public Role Get(int id) //Method untuk menampilkan berdasarkan ID
        {
            return iRoleRepository.Get(id);
        }
        public List<Role> Get(string value) //Method untuk menampilkan data sesuai dengan nilai yang dicari
        {
            return iRoleRepository.Get(value);

        }
        public bool Insert(RoleVM roleVM)
        {
            return iRoleRepository.Insert(roleVM);
        }
        public bool Update(int id, RoleVM roleVM)
        {
            return iRoleRepository.Update(id, roleVM);
        }
        public bool Delete(int id)
        {
            return iRoleRepository.Delete(id);
        }
    }
}
