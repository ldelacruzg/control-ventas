using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DAL
{
    public abstract class DAL<T>
    {
        protected Connection connection = new Connection();
        public abstract T[] selectAll();

        public abstract T insert(T t);

        public abstract T update(T t);

        public abstract T delete(T t);


    }
}
