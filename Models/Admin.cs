using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management_System.Models
{
    public class Admin: User
    {
        //private string adminId;
        private float profit;

        public Admin():base()
        {
        }

        public Admin (string name, string userId, string password, string email, string contactNo, string gender, int role,int age, float profit) :base(name, userId, password, email, contactNo, gender, role, age)
        {
            
            this.Profit = profit;
        }
        public float Profit { get => profit; set => profit = value; }
    }
}
