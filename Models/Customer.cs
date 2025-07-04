using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shop_Management_System.Models
{
    public class Customer:User 
    {
       
        
        private string address;
       

        public Customer():base() 
        {
        }
       
        public Customer(string name, string userId, string password, string email, string contactNo, string gender, int role, int age, string address) :base(name,userId,password,email,contactNo, gender, role, age)
        {
           
            this.Address = address;
        }

       
        public string Address { get => address; set => address = value; }

    }
}
