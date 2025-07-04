using Shop_Management_System.Models;
using Shop_Management_System.Controllers;
using Shop_Management_System.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_System
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AdminInfo();
            Application.Run(new LoginForm());
        }
        private static void AdminInfo()
        {
            AdminController a = new AdminController();
            Admin existing = a.SearchAdmin("admin01");

            if (existing != null)
            {
                return; 
            }
            
            Admin admin = new Admin( "Jobeda", "admin01", "donno", "hello@gmail.com", "0123456789", "Female", 1, 16, 0f);
            a.AddAdmin(admin);
           

        }
    }
}
