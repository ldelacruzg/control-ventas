using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class SupplierController: CRUD<SupplierDAL, Supplier>
    {
        public SupplierController() { }

        public override Supplier create()
        {
            throw new NotImplementedException();
        }

        public override Supplier destroy()
        {
            throw new NotImplementedException();
        }

        public override Supplier edit()
        {
            throw new NotImplementedException();
        }

        public override Supplier[] store()
        {
            throw new NotImplementedException();
        }
    }
}
