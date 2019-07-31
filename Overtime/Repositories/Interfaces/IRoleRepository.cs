using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories.Interfaces
{
    public interface IRoleRepository
    {
        //Interface hanya membuat method kosong
        List<Role> Get();
        Role Get(int id);
        List<Role> Get(string value);
        bool Insert(RoleVM roleVM);
        bool Update(int id, RoleVM roleVM);
        bool Delete(int id);

    }
}
