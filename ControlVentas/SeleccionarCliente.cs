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
    public partial class SeleccionarCliente : Form
    {
        DataSet datos = new DataSet();
        private string cliente;
        private string clienteID;

        public string Cliente { get => cliente; set => cliente = value; }
        public string ClienteID { get => clienteID; set => clienteID = value; }

        public SeleccionarCliente()
        {
            InitializeComponent();
        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {
            DataSource();
        }

        private void txtClienteID_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtClienteID.Text != "")
            {
                Conexion conexion = new Conexion();
                datos = conexion.Consulta("Customers", "CustomerID, CompanyName, ContactName, Address, Phone", "CustomerID like '" + txtClienteID.Text + "%'");
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = datos.Tables[0];
            }
            else
            {
                // mostrar toda la tabla
                DataSource();
            }
        }

        public void DataSource()
        {
            Conexion conexion = new Conexion();
            datos = conexion.Consulta("select CustomerID, CompanyName, ContactName, Address, Phone from Customers");
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = datos.Tables[0];
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvClientes.CurrentRow;
            cliente = fila.Cells[0].Value + ";" + fila.Cells[2].Value;
            clienteID = fila.Cells[0].Value.ToString();
            DialogResult pregunta = MessageBox.Show("Esta seguro de seleccionar este Cliente = " + cliente, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (pregunta == DialogResult.Yes)
            {
                this.Close();
            }
            else if (pregunta == DialogResult.No)
            {
                cliente = "";
                this.Close();
            }
        }
    }
}
