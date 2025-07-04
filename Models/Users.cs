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

    public class Users
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddUser(User user)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Users VALUES(@userId, @name, @password ,@age, @gender, @email, @contactNo, @role);");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@userId", user.UserId);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@contactNo", user.ContactNo);
            cmd.Parameters.AddWithValue("@gender", user.Gender);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@age", user.Age);
           
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteUser(string userId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Users WHERE userId=@userId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateUser(User user)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Users SET name=@name, password=@password, email=@email, contactNo=@contactNo, gender=@gender, role=@role, age=@age WHERE userId=@userId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@contactNo", user.ContactNo);
            cmd.Parameters.AddWithValue("@gender", user.Gender);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@age", user.Age);
            cmd.Parameters.AddWithValue("@userId", user.UserId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public User SearchUser(string userId, string password)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users WHERE userId=@userId AND password=@password;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@password", password);

            List<User> userList = GetData(cmd);

            if (userList.Count > 0)
            {
                return userList[0];
            }
            else
            {
                return null;
            }
        }

        public List<User> GetAllUsers()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Users;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }

        public List<User> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            List<User> userList = new List<User>();

            using (reader)
            {
                while (reader.Read())
                {
                    User u = new User();
                    u.UserId = reader.GetString(0);
                    u.Name = reader.GetString(1);
                    u.Password = reader.GetString(2);
                    u.Age = reader.GetInt32(3);
                    u.Gender = reader.GetString(4);
                    u.Email = reader.GetString(5);
                    u.ContactNo = reader.GetString(6);
                    u.Role = reader.GetInt32(7);

                    userList.Add(u);
                }

                reader.Close();
            }

            cmd.Connection.Close();

            return userList;
        }
    }
}
