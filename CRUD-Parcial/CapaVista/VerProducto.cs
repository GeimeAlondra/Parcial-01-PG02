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
        // Instancia de ProductoRepository para manejar operaciones con productos
        ProductoRepository _productoRepository;

        // Constructor de la clase VerProducto
        public VerProducto()
        {
            // Inicializa los componentes del formulario
            InitializeComponent(); 

            // Llama a un método para cargar los productos
            CargarProductos();  
            
            // Inicializa la instancia de ProductoRepository
            _productoRepository = new ProductoRepository();  
        }

        // Maneja el evento de clic en el botón de guardar en el BindingNavigator
        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Valida los datos del formulario
            this.Validate();

            // Finaliza la edición de los datos en el BindingSource
            this.productosBindingSource.EndEdit();

            // Actualiza todos los cambios en el DataSet a la base de datos
            this.tableAdapterManager.UpdateAll(this.parcial01DataSet);  
        }

        // Maneja el evento de carga del formulario
        private void VerProducto_Load(object sender, EventArgs e)
        {
            // Carga los datos de la tabla 'Productos' en el DataSet 'parcial01DataSet'
            this.productosTableAdapter.Fill(this.parcial01DataSet.Productos);  
        }

        // Método para cargar todos los productos en el DataGrid
        private void CargarProductos()
        {
            // Inicializa la instancia de ProductoRepository
            _productoRepository = new ProductoRepository();

            // Asigna la lista de productos al DataSource del DataGrid
            productosDataGrid.DataSource = _productoRepository.ObtenerTodos();  
        }

        // Método para filtrar los productos por nombre
        private void Filtrar()
        {
            // Inicializa la instancia de ProductoRepository
            _productoRepository = new ProductoRepository();

            // Obtiene el texto del TextBox para buscar
            string nombre = txtBuscar.Text;

            // Asigna la lista filtrada al DataSource del DataGrid
            productosDataGrid.DataSource = _productoRepository.FiltroNombre(nombre);  
        }

        // Maneja el evento de cambio de texto en el TextBox de búsqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Llama al método Filtrar cuando el texto del TextBox cambia
            Filtrar();  
        }

        // Maneja el evento de clic en el botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario RegistrarProducto, pasando la instancia actual (this) como parámetro
            RegistrarProducto objRegistroProducto = new RegistrarProducto(this);

            // Suscribe al evento LlenarDataGridViewRequested del formulario RegistrarProducto para manejar la actualización del DataGridView
            objRegistroProducto.LlenarDataGridViewRequested += Form1_LlenarDataGridViewRequested;

            // Muestra el formulario RegistrarProducto
            objRegistroProducto.Show();
        }

        // Maneja el evento LlenarDataGridViewRequested para actualizar el DataGridView
        private void Form1_LlenarDataGridViewRequested(object sender, EventArgs e)
        {
            // Llama al método CargarProductos para actualizar el DataGridView con los datos más recientes
            CargarProductos();
        }

        // Maneja el evento de clic en las celdas del DataGridView
        private void productosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si la columna clickeada es la de editar
            if (productosDataGrid.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Obtiene el Id del producto desde la celda de la fila actual
                int Id = Convert.ToInt32(productosDataGrid.CurrentRow.Cells["Id"].Value.ToString());

                // Crea una nueva instancia del formulario RegistrarProducto para editar el producto, pasando el Id como parámetro
                RegistrarProducto objRegistroProducto = new RegistrarProducto(this, Id);

                // Suscribe al evento LlenarDataGridViewRequested del formulario RegistrarProducto para manejar la actualización del DataGridView
                objRegistroProducto.LlenarDataGridViewRequested += Form1_LlenarDataGridViewRequested;

                // Muestra el formulario RegistrarProducto
                objRegistroProducto.Show();
            }
            // Verifica si la columna clickeada es la de eliminar
            else if (productosDataGrid.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                // Obtiene el Id del producto desde la celda de la fila actual
                int Id = Convert.ToInt32(productosDataGrid.CurrentRow.Cells["Id"].Value.ToString());

                // Crea una nueva instancia del repositorio de productos
                _productoRepository = new ProductoRepository();

                // Llama al método EliminarProducto para eliminar el producto con el Id especificado
                int resultado = _productoRepository.EliminarProducto(Id);

                // Muestra un mensaje de éxito o error basado en el resultado de la eliminación
                if (resultado > 0)
                {
                    MessageBox.Show("Producto eliminado con éxito", "| Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se logró eliminar el Producto", "| Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Actualiza el DataGridView con los datos más recientes
                CargarProductos();
            }
        }

    }
}
