using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.DAL
{
    public class Connection
    {
        private string server, database, user, password;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;

        public Connection() { }

        public Connection(string server, string database) { }

        public Connection(string server, string database, string user, string password) { }

        public bool conect() { return true; }
        public bool disconnect() { return true; }


    }
}
