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
    public class UsersController
    {
        IUserRepository iUserRepository = new UserRepository();
        public List<User> Get()
        {
            return iUserRepository.Get();
        }
        public User Get(int id) //Method untuk menampilkan berdasarkan ID
        {
            return iUserRepository.Get(id);
        }
        public List<User> Get(string value) //Method untuk menampilkan data sesuai dengan nilai yang dicari
        {
            return iUserRepository.Get(value);

        }
        public bool Insert(UserVM userVM)
        {
            return iUserRepository.Insert(userVM);
        }
        public bool Update(int id, UserVM userVM)
        {
            return iUserRepository.Update(id, userVM);
        }
        public bool Delete(int id)
        {
            return iUserRepository.Delete(id);
        }

    }
}
