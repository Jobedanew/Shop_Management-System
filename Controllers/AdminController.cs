using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Management_System.Models;

namespace Shop_Management_System.Controllers
{
    internal class AdminController
    {
        Admins a = new Admins();
        public void AddAdmin(Admin admin)
        {
            a.AddAdmin(admin);

        }
        
        public void UpdateAdmin(Admin admin)
        {
            a.UpdateAdmin(admin);

        }
        public Admin SearchAdmin(string userId)
        {
            Admin admin = a.SearchAdmin(userId);
            return admin;

        }
        /*public List<Admin> GetAllUsers()
        {
            List<Admin> userList = a.GetAllAdmin();
            return userList;
        }*/

    }
}
