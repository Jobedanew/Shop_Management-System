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
    public class Employees
    {

        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddEmployee(Employee e)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Users VALUES(@userId, @name, @password ,@age, @gender, @email, @contactNo, @role);");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", e.Name);
            cmd.Parameters.AddWithValue("@userId", e.UserId);
            cmd.Parameters.AddWithValue("@password", e.Password);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@contactNo", e.ContactNo);
            cmd.Parameters.AddWithValue("@gender", e.Gender);
            cmd.Parameters.AddWithValue("@role", e.Role);
            cmd.Parameters.AddWithValue("@age", e.Age);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            SqlCommand cmd1 = sda.GetQuery("INSERT INTO Employees VALUES(@employeeId, @salary);");
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@employeeId", e.UserId);
            cmd1.Parameters.AddWithValue("@salary", e.Salary);
            cmd1.Connection.Open();
            cmd1.ExecuteNonQuery();
            cmd1.Connection.Close();
        }

        public void DeleteEmployee(string employeeId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Users WHERE userId=@employeeId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@employeeId", employeeId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateEmployee(Employee e)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Users SET name=@name, password=@password ,age=@age, gender=@gender, email=@email, contactNo=@contactNo, role=@role WHERE userId=@userId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", e.Name);
            cmd.Parameters.AddWithValue("@userId", e.UserId);
            cmd.Parameters.AddWithValue("@password", e.Password);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@contactNo", e.ContactNo);
            cmd.Parameters.AddWithValue("@gender", e.Gender);
            cmd.Parameters.AddWithValue("@role", e.Role);
            cmd.Parameters.AddWithValue("@age", e.Age);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


            SqlCommand cmd1 = sda.GetQuery("UPDATE Employees SET  salary=@salary WHERE employeeId=@employeeId;");
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@employeeId", e.UserId);
            cmd1.Parameters.AddWithValue("@salary", e.Salary);
            cmd1.Connection.Open();
            cmd1.ExecuteNonQuery();
            cmd1.Connection.Close();
        }

        public Employee SearchEmployee(string employeeId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT u.userId, u.name, u.password, u.age, u.gender, u.email, u.contactNo, u.role, e.salary FROM Users u INNER JOIN  Employees e ON u.userId=e.employeeId WHERE employeeId=@employeeId ;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@employeeId", employeeId);
            List<Employee> EmployeeList = GetData(cmd);

            if (EmployeeList.Count > 0)
            {
                return EmployeeList[0];
            }

            else
            {
                return null;
            }
        }

        public List<Employee> GetAllEmployee()
        {
            SqlCommand cmd = sda.GetQuery("SELECT u.userId, u.name, u.password, u.age, u.gender, u.email, u.contactNo, u.role ,e.salary FROM Users u INNER JOIN Employees e ON u.userId=e.employeeId WHERE u.role=2;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }

        public List<Employee> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> EmployeeList = new List<Employee>();

            using (reader)
            {
                while (reader.Read())
                {

                    Employee e = new Employee();
                    e.UserId = reader.GetString(0);
                    e.Name = reader.GetString(1);
                    e.Password = reader.GetString(2);
                    e.Age = reader.GetInt32(3);
                    e.Gender = reader.GetString(4);
                    e.Email = reader.GetString(5);
                    e.ContactNo = reader.GetString(6);
                    e.Role = reader.GetInt32(7);
                    e.Salary = reader.GetInt32(8);
                    EmployeeList.Add(e);
                                     
                }
                reader.Close();
            }

            cmd.Connection.Close();
            return EmployeeList;
        }
    }
}
