using Shop_Management_System.Controllers;
using Shop_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Management_System.Views
{
    
    public partial class ProductOperation : Form
    {
        User u;
        public ProductOperation(User u)
        {
            InitializeComponent();
            this.u = u;
            
        }

        private void ProductOperation_Load(object sender, EventArgs e)
        {
            ProductController p = new ProductController();
            Grid.DataSource = p.GetAllProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string pName = txtBxNAme.Text;
                string id = txtBxId.Text;
                float price = Convert.ToSingle(txtBxPrice.Text);
                int quantity = Convert.ToInt32(txtBxQuantity.Text);
                

                ProductController pController = new ProductController();
                Product p=new Product(id,pName,quantity,price,0);
                pController.AddProduct(p);

                MessageBox.Show("Product Added Succesfully!");
                Grid.DataSource = pController.GetAllProduct();
                Grid.Refresh();

            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.Message);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string pName = txtBxNAme.Text;
                string id = txtBxId.Text;
                float price = Convert.ToSingle(txtBxPrice.Text);
                int quantity = Convert.ToInt32(txtBxQuantity.Text);
                int sale= Convert.ToInt32(txtBxSale.Text);

                ProductController pc = new ProductController();
                Product p = new Product(id, pName, quantity, price,sale);
                pc.UpdateProduct(p);

                MessageBox.Show("Product Updated Successfully!");
                Grid.DataSource = pc.GetAllProduct();
                Grid.Refresh();

            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.StackTrace);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtBxId.Text;

                ProductController pController = new ProductController();
                pController.DeleteProduct(id);

                MessageBox.Show("Product Deleted Successfully!");
                Grid.DataSource = pController.GetAllProduct();
                Grid.Refresh();
            }
            catch (Exception exp) {
                MessageBox.Show("Incorrect format" + exp.StackTrace);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtBxId.Text;              

                ProductController pController = new ProductController();
                Product p = pController.SearchProduct(id);

                if (p != null) 
                {
                    txtBxNAme.Text = p.ProductName;
                    txtBxId.Text = p.ProductId;
                    txtBxPrice.Text = p.Price.ToString();
                    txtBxQuantity.Text = p.Quantity.ToString();
                    txtBxSale.Text= p.SaleAmount.ToString();

                    MessageBox.Show("Product Found!");
                }
                else
                {
                    MessageBox.Show("Product Not Found!");
                }

                Grid.DataSource = pController.GetAllProduct();
                Grid.Refresh();


            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.StackTrace);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxId.Clear();
            txtBxNAme.Clear();
            txtBxPrice.Clear();
            txtBxQuantity.Clear();
            txtBxSale.Clear();
            txtBxId.Enabled = true;
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (u.Role == 1)
            {
                this.Hide();
                AdminHomePage adminHomePage = new AdminHomePage(u);
                adminHomePage.Show();

            }
            else
            {
                this.Hide();
                EmployeeHomePage emp = new EmployeeHomePage(u);
                emp.Show();
            }
        }
       
        private void btnSale_Click(object sender, EventArgs e)
        {
            try
            {
                
                string id = txtBxId.Text;
                int sale = Convert.ToInt32(txtBxSale.Text);
                ProductController pc = new ProductController();
                Product ps = pc.SearchProduct(id);
                int quantity = ps.Quantity;
                string pName = ps.ProductName;
                float price = ps.Price;

                if (ps != null &&  sale > 0 && quantity>0)
                {
                    int q = quantity - sale;
                    float pro = sale * price;
                    sale = sale + (ps.SaleAmount);


                    if (quantity <= 0) 
                    {
                        pc.DeleteProduct(id);
                    }
                        


                    Product p = new Product(id, pName, q, price, sale);                    
                    pc.UpdateProduct(p);
                    
                    MessageBox.Show("Updated Product List!");
                    txtBxQuantity.Text = Convert.ToString(q);
                    txtBxSale.Text = Convert.ToString(sale);
                    Grid.DataSource = pc.GetAllProduct();
                    Grid.Refresh();

                    AdminController ac =new AdminController();
                    Admin a =  ac.SearchAdmin("admin01");
                    a.Profit = (a.Profit) + pro;                 
                    ac.UpdateAdmin(a);

                }
                else
                {
                    MessageBox.Show("No Matching Product");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Incorrect format" + exp.Message);
            }
        }

       
    }
}
