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

namespace Shop_Management_System.Views
{
    public partial class AdminHomePage : Form
    {
        User u;
        public AdminHomePage(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ProductOperation op = new ProductOperation(u);           
            op.Show();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile ap = new AdminProfile(u);
            ap.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOperation co = new CustomerOperation(u);
            co.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeOperation eo = new EmployeeOperation(u);
            eo.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
