using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 
namespace Shop_Management_System.Models
{
    public class User 
    {
        protected string name;
        protected string userId;
        protected string password;
        protected string email;
        protected string contactNo;
        protected string gender;
        protected int role;
        protected int age;

        public User()
        {
        }

        public User(string name, string userId, string password, string email, string contactNo, string gender, int role, int age)
        {
            this.Name = name;
            this.UserId = userId;
            this.Password = password;
            this.Email = email;
            this.ContactNo = contactNo;
            this.Gender = gender;
            this.Role = role;
            this.Age = age;
        }

        public string Name { get => this.name; set => this.name = value; }
        public string UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Role { get => role; set => role = value; }
        public int Age { get => age; set => age = value; }
    }
}
