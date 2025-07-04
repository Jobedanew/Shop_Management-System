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
    public class Admins
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddAdmin(Admin a)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Users VALUES(@userId, @name, @password ,@age, @gender, @email, @contactNo, @role);");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@userId", a.UserId);
            cmd.Parameters.AddWithValue("@password", a.Password);
            cmd.Parameters.AddWithValue("@email", a.Email);
            cmd.Parameters.AddWithValue("@contactNo", a.ContactNo);
            cmd.Parameters.AddWithValue("@gender", a.Gender);
            cmd.Parameters.AddWithValue("@role", a.Role);
            cmd.Parameters.AddWithValue("@age", a.Age);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();



            SqlCommand cmd2 = sda.GetQuery("INSERT INTO Admins VALUES(@adminId, @profit);");
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@adminId", a.UserId);
            cmd2.Parameters.AddWithValue("@profit", a.Profit);

            cmd2.Connection.Open();
            cmd2.ExecuteNonQuery();
            cmd2.Connection.Close();
        }

        public void DeleteAdmin(string adminId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Admins WHERE adminId=@adminId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateAdmin(Admin a)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Users SET name=@name, password=@password, email=@email, contactNo=@contactNo, gender=@gender, role=@role, age=@age WHERE userId=@userId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@password", a.Password);
            cmd.Parameters.AddWithValue("@email", a.Email);
            cmd.Parameters.AddWithValue("@contactNo", a.ContactNo);
            cmd.Parameters.AddWithValue("@gender", a.Gender);
            cmd.Parameters.AddWithValue("@role", a.Role);
            cmd.Parameters.AddWithValue("@age", a.Age);
            cmd.Parameters.AddWithValue("@userId", a.UserId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


            SqlCommand cmd1 = sda.GetQuery("UPDATE Admins SET profit=@profit WHERE adminId=@adminId;");
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@adminId", a.UserId);
            cmd1.Parameters.AddWithValue("@profit", a.Profit);
            cmd1.Connection.Open();
            cmd1.ExecuteNonQuery();
            cmd1.Connection.Close();
        }

        public Admin SearchAdmin(string adminId)
        {
            //Admin a = new Admin();
            //a.UserId = adminId;
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users WHERE userId=@userId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userId",adminId);

            SqlCommand cmd1 = sda.GetQuery("SELECT * FROM Admins WHERE adminId=@adminId;");
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.AddWithValue("@adminId",adminId);

            List<Admin> AdminList = GetData(cmd,cmd1);

            if (AdminList.Count > 0)
            {
                return AdminList[0];
            }
            else
            {
                return null;
            }
        }

        /*public List<Admin> GetAllAdmin()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Admins;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }*/

        public List<Admin> GetData(SqlCommand cmd , SqlCommand cmd1)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            
            List<Admin> AdminList = new List<Admin>();
            Admin a = new Admin();
            using (reader)
            {
                while (reader.Read())
                {
                                
                    a.UserId = reader.GetString(0);
                    a.Name = reader.GetString(1);
                    a.Password = reader.GetString(2);
                    a.Age = reader.GetInt32(3);
                    a.Gender = reader.GetString(4);
                    a.Email = reader.GetString(5);
                    a.ContactNo = reader.GetString(6);                
                    a.Role = reader.GetInt32(7);       
                   
                    AdminList.Add(a);
                }
                reader.Close();
            }
            cmd.Connection.Close();

            cmd1.Connection.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();

            using (reader1)
            {
                while (reader1.Read())
                {
                    
                    a.Profit = Convert.ToSingle(reader1.GetDouble(1));
                    AdminList.Add(a);
                }
                reader1.Close();
            }

            cmd1.Connection.Close();
            return AdminList;
        }
    }
}
