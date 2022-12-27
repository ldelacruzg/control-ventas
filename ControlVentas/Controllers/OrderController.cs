using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class OrderController : CRUD<OrderDAL, Order>
    {
        public OrderController() { }

        public override Order create()
        {
            throw new NotImplementedException();
        }

        public override Order destroy()
        {
            throw new NotImplementedException();
        }

        public override Order edit()
        {
            throw new NotImplementedException();
        }

        public override Order[] store()
        {
            throw new NotImplementedException();
        }
    }
}
