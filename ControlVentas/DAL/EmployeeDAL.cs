using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DAL
{
    public class EmployeeDAL : DAL<Employee>
    {
        public EmployeeDAL() { }

        public override Employee delete(Employee t)
        {
            throw new NotImplementedException();
        }

        public override Employee insert(Employee t)
        {
            throw new NotImplementedException();
        }

        public override Employee[] selectAll()
        {
            throw new NotImplementedException();
        }

        public override Employee update(Employee t)
        {
            throw new NotImplementedException();
        }
    }
}
