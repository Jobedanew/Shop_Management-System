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
    public partial class EmployeeProfile : Form
    {
        User u;
        public EmployeeProfile(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            EmployeeController emc = new EmployeeController();
            Employee em = emc.SearchEmployee(u.UserId);
            
            textBoxName.Text = em.Name;
            textBoxId.Text = em.UserId;
            textBoxEmail.Text = em.Email;
            textBoxContact.Text = em.ContactNo;
            textBoxGender.Text = em.Gender;
            textBoxPass.Text = em.Password;
            textBoxAge.Text = em.Age.ToString();
            textBoxRole.Text = em.Role.ToString();
            textBoxSalary.Text = em.Salary.ToString();
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage emp = new EmployeeHomePage(u);
            emp.Show();

        }
    }
}
