using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DAL
{
    public class ProductDAL : DAL<Product>
    {
        public ProductDAL() { }
        public override Product delete(Product t)
        {
            throw new NotImplementedException();
        }

        public override Product insert(Product t)
        {
            throw new NotImplementedException();
        }

        public override Product[] selectAll()
        {
            throw new NotImplementedException();
        }

        public override Product update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
