using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Product
    {
        private int productId;
        private string productName;
        private decimal unitPrice;
        private int unitsInStock;
        private Supplier supplier;
        private Category category;

        public Product()
        {
        }

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Category Category { get => category; set => category = value; }
    }
}
