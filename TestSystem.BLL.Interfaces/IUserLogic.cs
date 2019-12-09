using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.DAL.Entities;

namespace TestSystem.BLL.Interfaces
{
    public interface IUserLogic
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);

        User GetUserByEmail(string email);
    }
}
