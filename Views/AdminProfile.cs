using Shop_Management_System.Models;
using Shop_Management_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_System.Views
{
    public partial class AdminProfile : Form
    {
        User u;
        public AdminProfile(User u)
        {
            InitializeComponent();
            this.u = u;

        }
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            AdminController admin = new AdminController();
            Admin a = admin.SearchAdmin("admin01");
            textBoxName.Text = a.Name.ToString();
            textBoxId.Text = a.UserId.ToString();
            textBoxPass.Text = a.Password.ToString();
            textBoxEmail.Text = a.Email.ToString();
            textBoxContact.Text = a.ContactNo.ToString();
            textBoxAge.Text = a.Age.ToString();
            textBoxGender.Text = a.Gender.ToString();
            textBoxRole.Text = a.Role.ToString();
            textBoxProfit.Text = a.Profit.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage ahp =new AdminHomePage(u);
            ahp.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                AdminController admin = new AdminController();
                Admin a = admin.SearchAdmin("admin01");

                a.Name = textBoxName.Text;
                a.Password = textBoxPass.Text;
                a.Email = textBoxEmail.Text;
                a.ContactNo = textBoxContact.Text;
                a.Age = Convert.ToInt32(textBoxAge.Text);
                /*int role = a.Role;
                string id = a.UserId;
                int profit = Convert.ToInt32(a.Profit);
                string gender = a.Gender;
                */
                AdminController ac = new AdminController();
                ac.UpdateAdmin(a);

                MessageBox.Show("Profile Updated Successfully");
            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.Message);
            }
        }
    }
}
