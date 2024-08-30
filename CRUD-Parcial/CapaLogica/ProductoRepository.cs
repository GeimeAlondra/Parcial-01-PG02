using CapaDatos;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductoRepository
    {
        // Declara una instancia de la capa de acceso a datos para productos
        ProductoDAL _productoDAL;

        // Obtiene todos los productos de la base de datos
        public List<Producto> ObtenerTodos()
        {
            // Inicializa la instancia de ProductoDAL
            _productoDAL = new ProductoDAL();

            // Llama al método ObtenerTodos de ProductoDAL y retorna la lista de productos
            return _productoDAL.ObtenerTodos();
        }

        // Obtiene un producto específico por su ID
        public Producto ObtenerPorID(int id)
        {
            // Inicializa la instancia de ProductoDAL
            _productoDAL = new ProductoDAL();

            // Llama al método ObtenerPorID de ProductoDAL y retorna el producto encontrado
            return _productoDAL.ObtenerPorID(id);
        }

        // Filtra productos por nombre
        public List<Producto> FiltroNombre(string nombre)
        {
            // Inicializa la instancia de ProductoDAL
            _productoDAL = new ProductoDAL();

            // Llama al método FiltroNombre de ProductoDAL y retorna la lista de productos que coinciden con el nombre
            return _productoDAL.FiltroNombre(nombre);
        }

        // Guarda un nuevo producto en la base de datos
        public int GuardarProducto(Producto producto)
        {
            // Inicializa la instancia de ProductoDAL
            _productoDAL = new ProductoDAL();

            // Llama al método GuardarProducto de ProductoDAL y retorna el número de filas afectadas
            return _productoDAL.GuardarProducto(producto);
        }

        // Actualiza un producto existente en la base de datos
        public int ActualizarProducto(Producto producto)
        {
            // Inicializa la instancia de ProductoDAL
            _productoDAL = new ProductoDAL();

            // Llama al método ActualizarProducto de ProductoDAL y retorna el número de filas afectadas
            return _productoDAL.ActualizarProducto(producto);
        }

        // Elimina un producto de la base de datos por su ID
        public int EliminarProducto(int id)
        {
            // Inicializa la instancia de ProductoDAL
            _productoDAL = new ProductoDAL();

            // Llama al método EliminarProducto de ProductoDAL y retorna el número de filas afectadas
            return _productoDAL.EliminarProducto(id);
        }
    }
}
