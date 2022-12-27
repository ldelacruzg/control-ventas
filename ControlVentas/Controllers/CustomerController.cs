using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class CustomerController : CRUD<CustomerDAL, Customer>
    {
        public CustomerController() { }

        public override Customer create()
        {
            throw new NotImplementedException();
        }

        public override Customer destroy()
        {
            throw new NotImplementedException();
        }

        public override Customer edit()
        {
            throw new NotImplementedException();
        }

        public override Customer[] store()
        {
            throw new NotImplementedException();
        }
    }
}
