using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.Views.Components
{
    public partial class ListComponent : Main
    {
        private FormComponent formComponent;

        public ListComponent()
        {
            InitializeComponent();
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado...");
        }

        private void ListComponent_Load(object sender, EventArgs e)
        {
            
        }
    }
}
