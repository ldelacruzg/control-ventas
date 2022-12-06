using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas
{
    public partial class fmrVentas : Form
    {
        public fmrVentas()
        {
            InitializeComponent();
        }

        private void fmrVentas_Load(object sender, EventArgs e)
        {
            string cadena;
            DataSet data;
            Conexion conexionAccessBDD = new Conexion();
            //cadena = "select o.OrderID, c.ContactName, e.FirstName, o.OrderDate from Orders o inner join Customers c on o.CustomerID = c.CustomerID inner join Employees e on e.EmployeeID = o.EmployeeID where datepart(day, o.OrderDate) = datepart(day, getdate()) and datepart(month, o.OrderDate) = datepart(month, getdate()) and datepart(year, o.OrderDate) = datepart(year, getdate())";

            cadena =  "select o.OrderID as NumVenta, o.OrderDate as Fecha, c.ContactName as Cliente, sum(d.Discount) as Descuento, sum(cast((d.Quantity * d.UnitPrice * (1 - d.Discount)) as decimal(10, 2))) as Total";
            cadena += " from Orders o inner join [Order Details] d on o.OrderID = d.OrderID";
            cadena += "    inner join Customers c on c.CustomerID = o.CustomerID";
            cadena += " where convert(date, o.OrderDate, 5) = convert(date, getdate(), 5)";
            cadena += " group by o.CustomerID, o.OrderID, o.OrderDate, c.ContactName";


            Microsoft.Reporting.WinForms.ReportDataSource dataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            rpvVentas.LocalReport.DataSources.Clear();
            data = conexionAccessBDD.Consulta(cadena);
            rpvVentas.LocalReport.ReportEmbeddedResource = "ControlVentas.rptVentas.rdlc";
            try
            {
                dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("dsVentas", data.Tables[0]);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            rpvVentas.LocalReport.DataSources.Add(dataSource);
            dataSource.Value = data.Tables[0];
            rpvVentas.LocalReport.Refresh();
            rpvVentas.RefreshReport();
        }
    }
}
