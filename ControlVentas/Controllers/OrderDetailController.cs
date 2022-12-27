using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class OrderDetailController : CRUD<OrderDetailDAL, OrderDetail>
    {
        public OrderDetailController() { }

        public override OrderDetail create()
        {
            throw new NotImplementedException();
        }

        public override OrderDetail destroy()
        {
            throw new NotImplementedException();
        }

        public override OrderDetail edit()
        {
            throw new NotImplementedException();
        }

        public override OrderDetail[] store()
        {
            throw new NotImplementedException();
        }
    }
}
