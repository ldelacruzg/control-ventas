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
    public partial class AgregarProducto : Form
    {
        string cantidad;
        DataSet datos = new DataSet();
        DataGridViewRow fila = new DataGridViewRow();

        public DataGridViewRow Fila { get => fila; set => fila = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }

        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            DataSource();
        }

        public void DataSource()
        {
            Conexion conexion = new Conexion();
            datos = conexion.Consulta("select p.ProductID, p.ProductName, c.CategoryName, p.UnitPrice, p.UnitsInStock from Products p inner join Categories c on p.CategoryID = c.CategoryID where p.UnitsInStock > 0");
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = datos.Tables[0];
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                fila = dgvProductos.CurrentRow;
                if (int.Parse(txtCantidad.Text) >= 1 && int.Parse(txtCantidad.Text) <= int.Parse(fila.Cells[4].Value.ToString()))
                {
                    cantidad = txtCantidad.Text;
                    string ProductName = Fila.Cells[1].Value.ToString();
                    DialogResult pregunta = MessageBox.Show("Esta seguro de agregar este Producto = " + ProductName, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (pregunta == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else if (pregunta == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Pasaste el numero de Unidades en Stock");
                }
            }
            else
            {
                MessageBox.Show("Ingresa una cantidad");
            }
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtProductName.Text != "")
            {
                Conexion conexion = new Conexion();
                datos = conexion.Consulta("select p.ProductID, p.ProductName, c.CategoryName, p.UnitPrice, p.UnitsInStock from Products p inner join Categories c on p.CategoryID = c.CategoryID where p.UnitsInStock > 0 and p.ProductName like '"+ txtProductName.Text +"%'");
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = datos.Tables[0];
            }
            else
            {
                // mostrar toda la tabla
                DataSource();
            }
        }
    }
}
