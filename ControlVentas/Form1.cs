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
    public partial class fmrPrincipal : Form
    {
        DataSet datos = new DataSet();
        string clienteID;
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            SeleccionarCliente sCliente = new SeleccionarCliente();
            sCliente.ShowDialog();
            txtCliente.Text = sCliente.Cliente;
            clienteID = sCliente.ClienteID;
            if (txtCliente.Text != "")
            {
                // se crea una nueva orden
                Conexion conexion = new Conexion();
                if (conexion.InsertarSQL("insert into Orders (CustomerID, EmployeeID, OrderDate) values ('" + clienteID + "', 1, getdate())"))
                {
                    txtNumeroDeVenta.Text = ObtenerIDVenta();
                    btnCliente.Enabled = false;
                    MessageBox.Show("Orden registrada, agregue los productos...");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar una nueva orden");
                }
            }
        }

        private void fmrPrincipal_Load(object sender, EventArgs e)
        {
            //txtNumeroDeVenta.Text = ObtenerIDVenta();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                AgregarProducto aProducto = new AgregarProducto();
                aProducto.ShowDialog();
                if (aProducto.Fila.Cells.Count > 0)
                {
                    dgvVenta.Rows.Add(txtNumeroDeVenta.Text, aProducto.Fila.Cells[0].Value, aProducto.Fila.Cells[3].Value, aProducto.Cantidad, 0);
                    txtSubTotal.Text = (
                        double.Parse(txtSubTotal.Text)
                        + (double.Parse(aProducto.Fila.Cells[3].Value.ToString()) * int.Parse(aProducto.Cantidad))
                    ).ToString();
                    txtTotal.Text = txtSubTotal.Text;
                }
            }
            else
            {
                MessageBox.Show("No hay Cliente seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string ObtenerIDVenta()
        {
            Conexion conexion = new Conexion();
            datos = conexion.Consulta("select top 1 OrderID from Orders order by OrderID desc");
            return datos.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVenta.Rows.Count > 0)
            {
                DialogResult pregunta = MessageBox.Show("Seguro de registrar la venta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (pregunta == DialogResult.Yes)
                {
                    // en products quitar las unidades en stock (actualizar)
                    // en orders registrar un orderid, clienteid, empleadoid, fecha
                    // en orders details guardar cada producto registrado (fila)
                    Conexion conexion = new Conexion();
                    // agregar items (productos)
                    int i; bool registroProducto;
                    for (i = 0; i < dgvVenta.Rows.Count; i++)
                    {
                        // registrar el producto
                        registroProducto = conexion.InsertarSQL("insert into [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) values ("
                            + txtNumeroDeVenta.Text + ", "
                            + dgvVenta.Rows[i].Cells[1].Value + ", "
                            + "'" + dgvVenta.Rows[i].Cells[2].Value.ToString().Replace(',', '.') + "', "
                            + dgvVenta.Rows[i].Cells[3].Value + ", "
                            + double.Parse(dgvVenta.Rows[i].Cells[4].Value.ToString())
                            + ")");

                        if (registroProducto)
                        {
                            // descuenta las unidades en stock del producto
                            datos = conexion.Consulta("select UnitsInStock from Products where ProductID = " + dgvVenta.Rows[i].Cells[1].Value + "");
                            int cantAct = int.Parse(datos.Tables[0].Rows[0].ItemArray[0].ToString()) - int.Parse(dgvVenta.Rows[i].Cells[3].Value.ToString());
                            conexion.InsertarSQL("update Products set UnitsInStock = " + cantAct + " where ProductID = " + dgvVenta.Rows[i].Cells[1].Value);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el producto " + dgvVenta.Rows[i].Cells[1].Value);
                        }
                    }

                    if (i == dgvVenta.Rows.Count)
                    {
                        MessageBox.Show("¡Venta registrada!");
                    }

                    txtCliente.Text = ""; dgvVenta.Rows.Clear();
                    txtSubTotal.Text = "0"; txtTotal.Text = "0";
                    txtNumeroDeVenta.Text = ""; btnCliente.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No hay items agregados", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntInformeVentasDelDia_Click(object sender, EventArgs e)
        {
            fmrVentas ventas = new fmrVentas();
            ventas.ShowDialog();
        }

        private void btnInformeProductosVendidos_Click(object sender, EventArgs e)
        {
            fmrProductos productos = new fmrProductos();
            productos.ShowDialog();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
