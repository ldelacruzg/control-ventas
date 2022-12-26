using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Order
    {
        private int orderId;
        private List<OrderDetail> orderDetails;
        private DateTime orderDate;
        private Customer customer;
        private Employee employee;

        public Order()
        {
        }

        public int OrderId { get => orderId; set => orderId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Employee Employee { get => employee; set => employee = value; }
        internal List<OrderDetail> OrderDetails { get => orderDetails; set => orderDetails = value; }
    }
}
