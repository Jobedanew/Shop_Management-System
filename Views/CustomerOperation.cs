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
    public partial class CustomerOperation : Form
    {
        User u;
        public CustomerOperation(User u)
        {
            InitializeComponent();
            this.u = u;
          
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg = new RegistrationForm(u);                 
            reg.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox4Name.Text;
                string id = textBoxId.Text;
                string email = textBoxEmail.Text;
                //string password = textBoxPass.Text;
                string contact = textBoxContact.Text;
                int age = Convert.ToInt32(textBoxAge.Text);
                string gender = comboBox1.Text;
                string address = textBoxAddress.Text;                   

                CustomerController cc = new CustomerController();
                Customer c = new Customer(id,name,"0",email,contact,gender,3,age,address);
                cc.UpdateCustomer(c);

                MessageBox.Show("Customer Updated Successfully!");
                Grid.DataSource = cc.GetAllCustomer();
                Grid.Refresh();

            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.Message);

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId.Text;

                CustomerController cc = new CustomerController();
                cc.DeleteCustomer(id);

                MessageBox.Show("Customer Deleted Successfully!");
                Grid.DataSource = cc.GetAllCustomer();
                Grid.Refresh();

                
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            if(u.Role == 1)
            {
                this.Hide();
                AdminHomePage a=new AdminHomePage(u);
                a.Show();

            }
            else if(u.Role == 2)
            {
                this.Hide();
                EmployeeHomePage em = new EmployeeHomePage(u);
                em.Show();
            }

        }

        private void CustomerOperation_Load(object sender, EventArgs e)
        {
            CustomerController cc =new CustomerController();          
            Grid.DataSource = cc.GetAllCustomer();
            Grid.Refresh();
              
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBox4Name.Clear();
            textBoxAge.Clear();
            textBoxAddress.Clear();
            textBoxContact.Clear();
            comboBox1.SelectedIndex=-1;
            textBoxEmail.Clear();
            textBoxId.Enabled = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId.Text;

                CustomerController cc = new CustomerController();
                Customer c = cc.SearchCustomer(id);
                             
                if (c != null)
                {
                    textBoxId.Text = c.UserId;
                    textBox4Name.Text = c.Name;
                    textBoxAge.Text= Convert.ToString(c.Age);
                    textBoxAddress.Text=c.Address;
                    textBoxContact.Text=c.Address;
                    comboBox1.Text=c.Gender;
                    textBoxEmail.Text=c.Email;

                    MessageBox.Show("Customer Has Been Found!");
                }
                else
                {
                    MessageBox.Show("Customer Not Found!");
                }
                Grid.DataSource = cc.GetAllCustomer();
                Grid.Refresh();



            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.Message);
            }
        }
    }
}
