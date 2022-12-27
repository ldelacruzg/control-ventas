using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class CategoryController : CRUD<CategoryDAL, Category>
    {
        public CategoryController() { }

        public override Category create()
        {
            throw new NotImplementedException();
        }

        public override Category destroy()
        {
            throw new NotImplementedException();
        }

        public override Category edit()
        {
            throw new NotImplementedException();
        }

        public override Category[] store()
        {
            throw new NotImplementedException();
        }
    }
}
