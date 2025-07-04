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
    public class Products
    {
        SqlDbDataAccess sda = new SqlDbDataAccess();

        public void AddProduct(Product p)
        {
            SqlCommand cmd = sda.GetQuery("INSERT INTO Products VALUES(@productId, @productName, @quantity, @price,@saleAmount);");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@productId", p.ProductId);
            cmd.Parameters.AddWithValue("@productName", p.ProductName);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@price", p.Price);
            cmd.Parameters.AddWithValue("@saleAmount", p.SaleAmount);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void DeleteProduct(string productId)
        {
            SqlCommand cmd = sda.GetQuery("DELETE FROM Products WHERE productId=@productId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void UpdateProduct(Product p)
        {
            SqlCommand cmd = sda.GetQuery("UPDATE Products SET productName=@productName, quantity=@quantity, price=@price,saleAmount = @saleAmount WHERE productId=@productId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@productId", p.ProductId);
            cmd.Parameters.AddWithValue("@productName", p.ProductName);
            cmd.Parameters.AddWithValue("@quantity", p.Quantity);
            cmd.Parameters.AddWithValue("@price", p.Price);
            cmd.Parameters.AddWithValue("@saleAmount", p.SaleAmount);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public Product SearchProduct(string productId)
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Products WHERE productId=@productId;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@productId", productId);
            List<Product> productList = GetData(cmd);

            if (productList.Count > 0)
            {
                return productList[0];
            }

            else
            {
                return null;
            }
        }

        public List<Product> GetAllProduct()
        {
            SqlCommand cmd = sda.GetQuery("SELECT * FROM Products;");
            cmd.CommandType = CommandType.Text;
            return GetData(cmd);
        }

        public List<Product> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> productList = new List<Product>();

            using (reader)
            {
                while (reader.Read())
                {
                    Product p = new Product();

                    p.ProductId = reader.GetString(0);
                    p.ProductName = reader.GetString(1);
                    p.Quantity = reader.GetInt32(2);
                    p.Price = Convert.ToSingle(reader.GetDouble(3));
                    p.SaleAmount = reader.GetInt32(4);

                    productList.Add(p);
                }
                reader.Close();
            }

            cmd.Connection.Close();
            return productList;
        }
    }
}
