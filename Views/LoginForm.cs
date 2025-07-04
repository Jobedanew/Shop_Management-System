using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Management_System.Models;
using Shop_Management_System.Controllers;

namespace Shop_Management_System.Views
{
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId=textBoxUserId.Text;
            string password=textBoxPassword.Text;
            
            if (userId == "" || password == "")
            {
                MessageBox.Show("User ID Or Password Can Not Be Empty");
            }

            else 
            {
                UserController usr = new UserController();
                User u = usr.SearchUser(userId, password);

                if (u != null)
                {
                    
                    if (u.UserId.Equals(userId) && u.Password.Equals(password) && u.Role.Equals(1))
                    {
                        this.Hide();
                        AdminHomePage adminHomePage = new AdminHomePage(u);
                        adminHomePage.Show();
                    }
                    else if (u.UserId.Equals(userId) && u.Password.Equals(password) && u.Role.Equals(2))
                    {
                        this.Hide();
                        EmployeeHomePage em = new EmployeeHomePage(u);
                        em.Show();
                    }
                    
                    else
                    {
                        MessageBox.Show("Invalid user Id or password");
                    }

                }
                else
                {
                    MessageBox.Show("No account has been found!");
                }
            }

        }

       /* private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg = new RegistrationForm(u);
            reg.Show();
        }*/

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

