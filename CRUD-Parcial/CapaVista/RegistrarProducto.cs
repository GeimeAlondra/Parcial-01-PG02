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
        ProductoRepository _productoRepository;
        int id;
        private VerProducto _form1;

        public RegistrarProducto(VerProducto form1, int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id > 0)
            {
                CargarCampos(id);
            }
            else
            {
                productosBindingSource.MoveLast();
                productosBindingSource.AddNew();

                Producto producto = new Producto();
                productosBindingSource.DataSource = producto;
            }
        }

        // Métodos para cargar el datagrid despues de realizar una inserción o actualización
        public event EventHandler LlenarDataGridViewRequested;

        private void OnLlenarDataGridViewRequested()
        {
            LlenarDataGridViewRequested?.Invoke(this, EventArgs.Empty);
        }

        private void RegistrarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parcial01DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.parcial01DataSet.Productos);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos(int id)
        {
            _productoRepository = new ProductoRepository();
            productosBindingSource.DataSource = _productoRepository.ObtenerPorID(id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private bool ValidarCampos()
        {
            bool camposValidos = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Se requiere el nombre del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Se requiere la descripción del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Se requiere el precio del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Se requiere el stock del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Se requiere el precio del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategoria.Focus();
                camposValidos = false;
            }

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Se requiere la marca del producto", "| Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                camposValidos = false;
            }

            return camposValidos;
        }

        private void GuardarProducto()
        {
            _productoRepository = new ProductoRepository();
            try
            {
                if (!ValidarCampos())
                {
                    return; // Si los campos no son válidos, se sale del metodo
                }
                int resultado;
               
                // Indicamos si guardaremos o actualizaremos
                if (id > 0)
                {
                    productosBindingSource.EndEdit();
                    Producto producto;
                    producto = (Producto)productosBindingSource.Current;
                    resultado = _productoRepository.ActualizarProducto(producto);
                    if (resultado > 0)
                    {
                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        txtCategoria.Clear();
                        txtMarca.Clear();
                        MessageBox.Show("Producto actualizado con exito", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar el producto", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    productosBindingSource.EndEdit();

                    Producto producto;
                    producto = (Producto)productosBindingSource.Current;

                    resultado = _productoRepository.GuardarProducto(producto);

                    if (resultado > 0)
                    {
                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        txtCategoria.Clear();
                        txtMarca.Clear();
                        MessageBox.Show("Producto agregado con exito", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el Producto", "| Registro Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                OnLlenarDataGridViewRequested();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "| Registro Producto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y el carácter de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // Validación para permitir solo caracteres enteros en el textBox de Stock
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Validación para permitir solo caracteres alfabeticos en el textBox de Categoria
        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
