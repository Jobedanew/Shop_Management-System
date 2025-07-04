using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Management_System.Models;

namespace Shop_Management_System.Controllers
{
    internal class CustomerController
    {
        Customers c = new Customers();

        public void AddCustomer(Customer customer)
        {
            c.AddCustomer(customer);
        }

        public void DeleteCustomer(string customerId)
        {
            c.DeleteCustomer(customerId);
        }

        public void UpdateCustomer(Customer customer)
        {
            c.UpdateCustomer(customer);
        }

        public Customer SearchCustomer(string customerId)
        {
            Customer customer = c.SearchCustomer(customerId);
            return customer;
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> customerList = c.GetAllCustomer();
            return customerList;
        }
    }
}
