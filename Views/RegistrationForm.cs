using Shop_Management_System.Controllers;
using Shop_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shop_Management_System.Views
{
    public partial class RegistrationForm : Form
    {
        User u;
        public RegistrationForm(User u)
        {
            InitializeComponent();
            this.u = u;

        }

        private void Resistration_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (u.Role == 1)
            {
                this.Hide();
                CustomerOperation c = new CustomerOperation(u);
                c.Show();

            }
            else if (u.Role == 2)
            {
                this.Hide();
                CustomerOperation c = new CustomerOperation(u);
                c.Show();

            }

            else
            {
                this.Hide();
                LoginForm lg = new LoginForm();
                lg.Show();
            }
           
        }

        
        private void bnSingUp_Click(object sender, EventArgs e)
        {
            string name= txtBxName.Text;
            string id= txtBxID.Text;
            string contactNo = txtBxContact.Text;
            string ageStr = txtBxAge.Text;
            string email = txtBxEmail.Text;
            string address = txtBxAddress.Text;
            string gender = "";
            if (btnFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }
            

            CustomerController customer = new CustomerController();

            if((name != "") && (id != "") && (contactNo != "") && (gender != "") && (email != "") && (ageStr!="") && (address != ""))
            {
                int age = int.Parse(ageStr);           
                Customer c = new Customer(name,id,"0",email,contactNo,gender,3,age,address);
                customer.AddCustomer(c);
                MessageBox.Show("Customer Successfully Registered!");

            }
            else
            {
                MessageBox.Show("Fill Up The Form Properly");
            }
        }

        
    }
}
