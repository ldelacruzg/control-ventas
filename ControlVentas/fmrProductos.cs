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
    public partial class fmrProductos : Form
    {
        public fmrProductos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dtProductosTableAdapter.Fill(this.dsDatos.dtProductos, dtpInicio.Text, dtpFin.Text);
            this.rpvProductos.RefreshReport();
        }

        private void fmrProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatos.dtProductos' Puede moverla o quitarla según sea necesario.
            //this.rpvProductos.RefreshReport();
        }
    }
}
