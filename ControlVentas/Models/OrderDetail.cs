using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class OrderDetail
    {
        private Order order;
        private Product product;
        private decimal unitPrice;
        private int quantity;
        private decimal discount;

        public OrderDetail() { }

        public Order Order { get => order; set => order = value; }
        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Discount { get => discount; set => discount = value; }
        public decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
    }
}
