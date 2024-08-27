using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class VerProducto : Form
    {
        public VerProducto()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parcial01DataSet);

        }

        private void VerProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parcial01DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.parcial01DataSet.Productos);

        }
    }
}
