using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CapaVista
{
    public partial class RegistrarProducto : Form
    {
        // Declara una instancia del repositorio de productos
        ProductoRepository _productoRepository;

        // Declara una variable para almacenar el ID del producto
        int id;

        // Declara una referencia al formulario VerProducto
        private VerProducto _form1;

        // Constructor de la clase RegistrarProducto
        public RegistrarProducto(VerProducto form1, int _id = 0)
        {
            InitializeComponent();

            // Asigna el valor del ID pasado al constructor
            id = _id;

            // Si se pasa un ID mayor a 0, carga los datos del producto con ese ID
            if (id > 0)
            {
                // Llama a un método para cargar los datos del producto en los campos del formulario
                CargarCampos(id);
            }
            else
            {
                // Mueve el BindingSource a la última posición (probablemente no aplicable aquí ya que es una nueva instancia)
                productosBindingSource.MoveLast();

                // Añade un nuevo registro al BindingSource
                productosBindingSource.AddNew();

                // Crea una nueva instancia de Producto y la asigna como la fuente de datos del BindingSource
                Producto producto = new Producto();
                productosBindingSource.DataSource = producto;
            }
        }

        // Métodos para cargar el datagrid despues de realizar una inserción o actualización
        public event EventHandler LlenarDataGridViewRequested;

        // Método que activa el evento LlenarDataGridViewRequested
        private void OnLlenarDataGridViewRequested()
        {
            // Invoca el evento si tiene suscriptores
            LlenarDataGridViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parcial01DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.parcial01DataSet.Productos);

            // Si estamos agregando un nuevo producto (ID es 0), establecemos los campos de precio y stock como vacíos
            if (id == 0)
            {
                txtPrecio.Text = string.Empty;
                txtStock.Text = string.Empty;
            }
        }

        // Método manejador del evento Click del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cierra el formulario actual
            this.Close();
        }

        // Método para cargar los datos del producto en los campos del formulario
        private void CargarCampos(int id)
        {
            // Inicializa la instancia del repositorio de productos
            _productoRepository = new ProductoRepository();

            // Obtiene el producto con el ID especificado y establece el producto en el BindingSource
            productosBindingSource.DataSource = _productoRepository.ObtenerPorID(id);
        }

        // Método manejador del evento Click del botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Llama al método GuardarProducto para guardar los datos del producto
            GuardarProducto();
        }

        // Método para validar los campos del formulario
        private bool ValidarCampos()
        {
            // Inicializa un indicador de validez de campos como verdadero
            bool camposValidos = true;

            // Verifica si el campo Nombre está vacío
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                // Muestra un mensaje de advertencia si el campo está vacío
                MessageBox.Show("Se requiere el nombre del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Enfoca el campo Nombre para que el usuario pueda ingresarlo
                txtNombre.Focus();
                // Marca los campos como inválidos
                camposValidos = false;
            }

            // Verifica si el campo Descripción está vacío
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                // Muestra un mensaje de advertencia si el campo está vacío
                MessageBox.Show("Se requiere la descripción del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Enfoca el campo Descripción para que el usuario pueda ingresarlo
                txtDescripcion.Focus();
                // Marca los campos como inválidos
                camposValidos = false;
            }

            // Verifica si el campo Precio está vacío
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                // Muestra un mensaje de advertencia si el campo está vacío
                MessageBox.Show("Se requiere el precio del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Enfoca el campo Precio para que el usuario pueda ingresarlo
                txtPrecio.Focus();
                // Marca los campos como inválidos
                camposValidos = false;
            }

            // Verifica si el campo Stock está vacío
            if (string.IsNullOrEmpty(txtStock.Text))
            {
                // Muestra un mensaje de advertencia si el campo está vacío
                MessageBox.Show("Se requiere el stock del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Enfoca el campo Stock para que el usuario pueda ingresarlo
                txtStock.Focus();
                // Marca los campos como inválidos
                camposValidos = false;
            }

            // Verifica si el campo Categoría está vacío
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                // Muestra un mensaje de advertencia si el campo está vacío
                MessageBox.Show("Se requiere la categoría del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Enfoca el campo Categoría para que el usuario pueda ingresarlo
                txtCategoria.Focus();
                // Marca los campos como inválidos
                camposValidos = false;
            }

            // Verifica si el campo Marca está vacío
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                // Muestra un mensaje de advertencia si el campo está vacío
                MessageBox.Show("Se requiere la marca del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Enfoca el campo Marca para que el usuario pueda ingresarlo
                txtMarca.Focus();
                // Marca los campos como inválidos
                camposValidos = false;
            }

            // Devuelve si todos los campos son válidos
            return camposValidos;
        }

        // Método para guardar o actualizar un producto
        private void GuardarProducto()
        {
            // Inicializa el repositorio de productos
            _productoRepository = new ProductoRepository();

            try
            {
                // Valida los campos del formulario
                if (!ValidarCampos())
                {
                    // Si los campos no son válidos, sale del método
                    return;
                }

                int resultado;

                // Verifica si se está actualizando un producto existente (id > 0) o agregando uno nuevo
                if (id > 0)
                {
                    // Finaliza la edición del BindingSource para aplicar los cambios
                    productosBindingSource.EndEdit();

                    // Obtiene el producto actual del BindingSource
                    Producto producto = (Producto)productosBindingSource.Current;

                    // Llama al método para actualizar el producto en la base de datos
                    resultado = _productoRepository.ActualizarProducto(producto);

                    if (resultado > 0)
                    {
                        // Limpia los campos del formulario después de una actualización exitosa
                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        txtCategoria.Clear();
                        txtMarca.Clear();

                        // Muestra un mensaje de éxito y cierra el formulario
                        MessageBox.Show("Producto actualizado con éxito", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // Muestra un mensaje de error si la actualización falla
                        MessageBox.Show("No se logró actualizar el producto", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Finaliza la edición del BindingSource para aplicar los cambios
                    productosBindingSource.EndEdit();

                    // Obtiene el producto actual del BindingSource
                    Producto producto = (Producto)productosBindingSource.Current;

                    // Llama al método para guardar un nuevo producto en la base de datos
                    resultado = _productoRepository.GuardarProducto(producto);

                    if (resultado > 0)
                    {
                        // Limpia los campos del formulario después de agregar el producto
                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        txtCategoria.Clear();
                        txtMarca.Clear();

                        // Muestra un mensaje de éxito y cierra el formulario
                        MessageBox.Show("Producto agregado con éxito", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        // Muestra un mensaje de error si el guardado falla
                        MessageBox.Show("No se logró guardar el producto", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Dispara el evento para llenar el DataGridView
                OnLlenarDataGridViewRequested();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre una excepción
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "| Registro Producto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validación para permitir solo caracteres enteros numericos y punto en el textBox de Precio
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y el carácter de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }

        // Validación para permitir solo caracteres enteros numericos en el textBox de Stock
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un control (como Backspace) y no es un dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }

        // Validación para permitir solo caracteres alfabéticos en el textBox de Categoria
        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un control (como Backspace), no es una letra y no es un espacio en blanco
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }
    }
}
