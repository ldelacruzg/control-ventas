using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class ProductController : CRUD<ProductDAL, Product>
    {
        public ProductController() { }

        public override Product create()
        {
            throw new NotImplementedException();
        }

        public override Product destroy()
        {
            throw new NotImplementedException();
        }

        public override Product edit()
        {
            throw new NotImplementedException();
        }

        public override Product[] store()
        {
            throw new NotImplementedException();
        }
    }
}
