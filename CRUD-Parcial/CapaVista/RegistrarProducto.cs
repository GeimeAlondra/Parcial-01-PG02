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

namespace CapaVista
{
    public partial class RegistrarProducto : Form
    {
        ProductoRepository _productoRepository;
        int id;

        public RegistrarProducto(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if(id > 0)
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

        //private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.productosBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.parcial01DataSet);

        //}

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

        private void GuardarProducto()
        {
            _productoRepository = new ProductoRepository();
            try
            {
                //if (!ValidarCampos())
                //{
                //    return; // Si los campos no son válidos, salir del método
                //}
                int resultado;
                //debemo indicar si es una actualizacion o es un nuevo producto
               
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un Error: {ex}", "| Registro Producto",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
