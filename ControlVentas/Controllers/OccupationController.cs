using ControlVentas.DAL;
using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public class OccupationController : CRUD<OccupationDAL, Occupation>
    {
        public OccupationController() { }

        public override Occupation create()
        {
            throw new NotImplementedException();
        }

        public override Occupation destroy()
        {
            throw new NotImplementedException();
        }

        public override Occupation edit()
        {
            throw new NotImplementedException();
        }

        public override Occupation[] store()
        {
            throw new NotImplementedException();
        }
    }
}
