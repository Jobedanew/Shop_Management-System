using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Management_System.Models;

namespace Shop_Management_System.Controllers
{
    internal class UserController
    {
        Users a = new Users();

       /* 
        public void AddUser(User user)
        {
            a.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            a.UpdateUser(user);
        }
       */
        public User SearchUser(string userId,string password)
        {
            User user = a.SearchUser(userId,password);
            return user;
        }

        public List<User> GetAllUsers()
        {
            List<User> userList = a.GetAllUsers();
            return userList;
        }
    }
}
