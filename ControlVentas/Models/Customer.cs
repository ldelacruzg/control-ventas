using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Customer : Company
    {
        private string customerId;

        public Customer()
        {
        }

        public string CustomerId { get => customerId; set => customerId = value; }
    }
}
