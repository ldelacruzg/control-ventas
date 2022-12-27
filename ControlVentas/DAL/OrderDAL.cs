using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DAL
{
    public class OrderDAL : DAL<Order>
    {
        public OrderDAL() { }

        public override Order delete(Order t)
        {
            throw new NotImplementedException();
        }

        public override Order insert(Order t)
        {
            throw new NotImplementedException();
        }

        public override Order[] selectAll()
        {
            throw new NotImplementedException();
        }

        public override Order update(Order t)
        {
            throw new NotImplementedException();
        }
    }
}
