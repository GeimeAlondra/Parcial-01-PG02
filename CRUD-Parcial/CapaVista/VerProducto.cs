using CapaLogica;
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
        ProductoRepository _productoRepository;

        public VerProducto()
        {
            InitializeComponent();
            CargarProductos();
            _productoRepository = new ProductoRepository();
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

        private void CargarProductos()
        {
            _productoRepository = new ProductoRepository();

            productosDataGrid.DataSource = _productoRepository.ObtenerTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            RegistrarProducto objRegistroProducto = new RegistrarProducto();
            objRegistroProducto.Show();
        }

        private void productosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (productosDataGrid.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                //Esta linea de abajo creo que no esta haciendo nada pero me da miedo borrarla XD
                int Id = Convert.ToInt32(productosDataGrid.CurrentRow.Cells["Id"].Value.ToString());

                    RegistrarProducto objRegistroProducto = new RegistrarProducto(Id);
                    objRegistroProducto.Show();
                    

                }
            else if(productosDataGrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int Id = Convert.ToInt32(productosDataGrid.CurrentRow.Cells["Id"].Value.ToString());
                _productoRepository = new ProductoRepository();
                _productoRepository.EliminarProducto(Id);
                int resultado = _productoRepository.EliminarProducto(Id);

                if (resultado == 0)
                {
                    MessageBox.Show("Producto eliminado con exito", "| Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                else
                {
                    MessageBox.Show("No se logro eliminar el Producto", "| Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CargarProductos();
            }
        }
    }
}
