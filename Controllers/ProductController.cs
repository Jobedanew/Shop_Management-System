using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Management_System.Models;

namespace Shop_Management_System.Controllers
{
    internal class ProductController
    {
        Products p = new Products();

        public void AddProduct(Product product)
        {
            p.AddProduct(product);
        }

        public void DeleteProduct(string productId)
        {
            p.DeleteProduct(productId);
        }

        public void UpdateProduct(Product product)
        {
            p.UpdateProduct(product);
        }

        public Product SearchProduct(string productId)
        {
            Product product = p.SearchProduct(productId);
            return product;
        }

        public List<Product> GetAllProduct()
        {
            List<Product> productList = p.GetAllProduct();
            return productList;
        }
    }
}