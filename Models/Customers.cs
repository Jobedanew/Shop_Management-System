using Shop_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management_System.Models
{
    public class Customers
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddCustomer(Customer c)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Users VALUES(@userId, @name, @password ,@age, @gender, @email, @contactNo, @role);");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@userId", c.UserId);
            cmd.Parameters.AddWithValue("@password", c.Password);
            cmd.Parameters.AddWithValue("@email", c.Email);
            cmd.Parameters.AddWithValue("@contactNo", c.ContactNo);
            cmd.Parameters.AddWithValue("@gender", c.Gender);
            cmd.Parameters.AddWithValue("@role", c.Role);
            cmd.Parameters.AddWithValue("@age", c.Age);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            SqlCommand cmd2 = sda.GetQuery("INSERT INTO Customers VALUES(@customerId, @address);");
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@customerId", c.UserId);
            cmd2.Parameters.AddWithValue("@address", c.Address);

            cmd2.Connection.Open();
            cmd2.ExecuteNonQuery();
            cmd2.Connection.Close();

        }

        public void DeleteCustomer(string customerId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Users WHERE userId=@customerId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@customerId", customerId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateCustomer(Customer c)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Users SET  name=@name, password=@password ,age=@age, gender= @gender, email=@email, contacNo=@contactNo, role=@role WHERE userId=@userId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.Parameters.AddWithValue("@userId", c.UserId);
            cmd.Parameters.AddWithValue("@password", c.Password);
            cmd.Parameters.AddWithValue("@email", c.Email);
            cmd.Parameters.AddWithValue("@contactNo", c.ContactNo);
            cmd.Parameters.AddWithValue("@gender", c.Gender);
            cmd.Parameters.AddWithValue("@role", c.Role);
            cmd.Parameters.AddWithValue("@age", c.Age);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
                         
            SqlCommand cmd1 = sda.GetQuery("UPDATE Customers SET address=@address WHERE customerId=@customerId;");
            cmd1.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@customerId",c.UserId);
            cmd1.Parameters.AddWithValue("@address", c.Address);
            cmd1.Connection.Open();
            cmd1.ExecuteNonQuery();
            cmd1.Connection.Close();
        }

        public Customer SearchCustomer(string customerId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT u.userId, u.name, u.password, u.age, u.gender, u.email, u.contactNo, u.role, c.address FROM Users u  INNER JOIN Customers c ON u.userId = c.customerId WHERE customerId = @customerId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@customerId", customerId);

            List<Customer> CustomerList = GetData(cmd);

            if (CustomerList.Count > 0)
            {
                return CustomerList[0];
            }
            else
            {
                return null;
            }
        }

        public List<Customer> GetAllCustomer()
        {
            SqlCommand cmd = sda.GetQuery("SELECT u.userId, u.name, u.password, u.age, u.gender, u.email, u.contactNo, u.role, c.address FROM Users u INNER JOIN Customers c ON u.userId = c.customerId WHERE u.role = 3;");
            cmd.CommandType = CommandType.Text;

            List<Customer> CustomerList = GetData(cmd);

            return GetData(cmd);


        }

        public List<Customer> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> customerList = new List<Customer>();

            
            using (reader)
            {
                while (reader.Read())
                {
                    Customer c = new Customer();
                    c.UserId = reader.GetString(0);
                    c.Name = reader.GetString(1);
                    c.Password = reader.GetString(2);
                    c.Age = reader.GetInt32(3);
                    c.Gender = reader.GetString(4);
                    c.Email = reader.GetString(5);
                    c.ContactNo = reader.GetString(6);
                    c.Role = reader.GetInt32(7);
                    c.Address = reader.GetString(8);
                    customerList.Add(c);
                }

                reader.Close();
            }

            cmd.Connection.Close();
            return customerList;
        }
    }
}
