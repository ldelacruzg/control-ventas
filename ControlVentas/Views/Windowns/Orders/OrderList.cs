using ControlVentas.Views.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.Views.Windowns.Orders
{
    public partial class OrderList : ListComponent
    {
        public OrderList()
        {
            InitializeComponent();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn product = new DataGridViewTextBoxColumn();
            product.Name = "Product";

            DataGridViewTextBoxColumn price = new DataGridViewTextBoxColumn();
            price.Name = "Price";

            dgvData.Columns.Add(product);
            dgvData.Columns.Add(price);

            dgvData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            dgvData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvData.Rows[0].Cells[0].Value = "Anyway";
            dgvData.Rows[0].Cells[1].Value = Math.Round(1520.50542, 2);
        }
    }
}
