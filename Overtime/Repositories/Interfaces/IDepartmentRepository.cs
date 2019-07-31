using Overtime.Models;
using Overtime.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        //Interface hanya membuat method kosong
        List<Department> Get();
        Department Get(int id);
        List<Department> Get(string value);
        bool Insert(DepartmentVM departmentVM);
        bool Update(int id, DepartmentVM departmentVM);
        bool Delete(int id);
    }
}