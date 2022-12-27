using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DAL
{
    public class CustomerDAL : DAL<Customer>
    {
        public CustomerDAL() { }

        public override Customer delete(Customer t)
        {
            throw new NotImplementedException();
        }

        public override Customer insert(Customer t)
        {
            throw new NotImplementedException();
        }

        public override Customer[] selectAll()
        {
            throw new NotImplementedException();
        }

        public override Customer update(Customer t)
        {
            throw new NotImplementedException();
        }
    }
}
