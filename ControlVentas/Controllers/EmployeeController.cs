using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class EmployeeController : CRUD<EmployeeDAL, Employee>
    {
        public EmployeeController() { }

        public override Employee create()
        {
            throw new NotImplementedException();
        }

        public override Employee destroy()
        {
            throw new NotImplementedException();
        }

        public override Employee edit()
        {
            throw new NotImplementedException();
        }

        public override Employee[] store()
        {
            throw new NotImplementedException();
        }
    }
}
