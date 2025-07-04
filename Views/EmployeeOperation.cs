using Shop_Management_System.Controllers;
using Shop_Management_System.Models;
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
    public partial class EmployeeOperation : Form
    {
        User u;
        public EmployeeOperation(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void butonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string Id = textBoxid.Text;
                string name = textBoxname.Text;
                string pass = textBoxpass.Text;
                string contact =textBoxconact.Text;
                string email = textBoxemail.Text;
                string gender = comboBoxgender.Text;
                //int role =Convert.ToInt32(textBoxrole.Text);
                int age = Convert.ToInt32(textBoxage.Text);
                int salary = Convert.ToInt32(textBoxsalary.Text);


                EmployeeController emc = new EmployeeController();
                Employee em = new Employee(name,Id,pass,email,contact,gender,2,age,salary);

                emc.AddEmployee(em);

                MessageBox.Show("Employee Added Successfully");
                Grid.DataSource = emc.GetAllEmployee();
                Grid.Refresh();

            }
            catch(Exception exp) 
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void EmployeeOperation_Load(object sender, EventArgs e)
        {
            EmployeeController emc = new EmployeeController();
            Grid.DataSource=emc.GetAllEmployee();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string Id = textBoxid.Text;
                string name = textBoxname.Text;
                string pass = textBoxpass.Text;
                string contact = textBoxconact.Text;
                string email = textBoxemail.Text;
                string gender = comboBoxgender.Text;
                //int role = Convert.ToInt32(textBoxrole.Text);
                int age = Convert.ToInt32(textBoxage.Text);
                int salary = Convert.ToInt32(textBoxsalary.Text);


                EmployeeController emc = new EmployeeController();
                Employee em = new Employee(name, Id, pass, email, contact, gender, 2, age, salary);

                emc.UpdateEmployee(em);

                MessageBox.Show("Employee Updated Successfully");
                Grid.DataSource = emc.GetAllEmployee();
                Grid.Refresh();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxid.Text;

                EmployeeController emc = new EmployeeController();
                Employee em = emc.SearchEmployee(id);

                if (em != null)
                {
                    emc.DeleteEmployee(id);
                    MessageBox.Show("Employee Deleted Successfully!");
                    
                }
                else
                {
                    MessageBox.Show("No Employee Found!");
                }
                Grid.DataSource = emc.GetAllEmployee();
                Grid.Refresh();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            
                textBoxage.Clear();
                textBoxconact.Clear();
                textBoxemail.Clear();
                comboBoxgender.SelectedIndex=-1;
                textBoxrole.Clear();
                textBoxsalary.Clear();
                textBoxname.Clear();
                textBoxid.Clear();
                textBoxpass.Clear();
                textBoxid.Enabled=true;
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxid.Text;
                EmployeeController emc = new EmployeeController();
                Employee em = emc.SearchEmployee(id);

                if (em != null)
                {
                    textBoxid.Text = em.UserId;
                    textBoxage.Text = em.Age.ToString();
                    textBoxconact.Text = em.ContactNo;
                    textBoxemail.Text = em.Email;
                    comboBoxgender.Text = em.Gender;
                    textBoxname.Text = em.Name;
                    textBoxpass.Text = em.Password;
                    textBoxrole.Text = em.Role.ToString();
                    textBoxsalary.Text = em.Salary.ToString();

                    MessageBox.Show("Employee Has Been Found!");

                }
                else
                {
                    MessageBox.Show("No Employee Found!");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHomePage ap = new AdminHomePage(u);
            ap.Show();
        }
    }
}
