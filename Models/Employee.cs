using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop_Management_System.Models
{
    public class Employee:User
    {
        
        private int salary;

        public Employee():base()
        {
        }
        public Employee(string name, string userId, string password, string email, string contactNo, string gender, int role, int age, int salary):base(name,  userId,  password,  email,  contactNo,  gender,  role,  age)
        {
            
            this.Salary = salary;
        }

        
        public int Salary { get => salary; set => salary = value; }
    }
}
