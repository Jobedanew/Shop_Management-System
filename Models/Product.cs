using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shop_Management_System.Models
{
    public class Product
    {
        private string productId;
        private string productName;
        private int quantity;
        private float price;
        private int saleAmount;

        public Product()
        {
        }
        public Product(string productId, string productName, int quantity, float price,int saleAmount)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.Price = price;
            this.SaleAmount = saleAmount;
        }

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public int SaleAmount { get => saleAmount; set => saleAmount = value; }
    }
}
