using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Controllers
{
    public abstract class CRUD<T,U>
    {
        protected T dal;

        public abstract U[] store();

        public abstract U create();
        public abstract U edit();
        public abstract U destroy();

    }
}
