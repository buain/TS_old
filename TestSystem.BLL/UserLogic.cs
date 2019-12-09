using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem.BLL.Interfaces;
using TestSystem.DAL.Entities;
using TestSystem.DAL.Interfaces;

namespace TestSystem.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserStorage userDao;
        public UserLogic() { }
        public UserLogic(IUserStorage userDao)
        {
            this.userDao = userDao;
        }
        public IEnumerable<User> GetAllUsers()
        {
            return userDao.GetAllUsers();
        }
        public User GetUserById(int id)
        {
            return userDao.GetUserById(id);
        }

        public User GetUserByEmail(string email)
        {
            return userDao.GetUserByEmail(email);
        }
    }
}
