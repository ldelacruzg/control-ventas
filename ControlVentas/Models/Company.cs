using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public abstract class Company
    {
        private string companyName;
        private string contantName;
        private string address;
        private string phone;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string ContantName { get => contantName; set => contantName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
