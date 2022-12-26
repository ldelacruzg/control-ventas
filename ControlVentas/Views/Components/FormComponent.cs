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
    public enum ActionType
    {
        REGISTER,
        EDIT
    }

    public partial class FormComponent : Form
    {
        private ActionType actionType;

        public FormComponent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Método no implementado...");
        }
    }
}
