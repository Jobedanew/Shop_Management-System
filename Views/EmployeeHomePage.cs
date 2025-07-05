using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Management_System.Controllers;
using Shop_Management_System.Models;

namespace Shop_Management_System.Views
{
    public partial class EmployeeHomePage : Form
    {
        User u;
        public EmployeeHomePage(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void buttonCO_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOperation co = new CustomerOperation(u);
            co.Show();
        }

        private void buttonPO_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductOperation p = new ProductOperation(u);
            p.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeProfile emp = new EmployeeProfile(u);
            emp.Show();
            
        }

        private void EmployeeHomePage_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
