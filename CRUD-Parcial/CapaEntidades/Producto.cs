using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Producto
    {
        // Identificador único del producto
        public int Id { get; set; }

        // Nombre del producto
        public string Nombre { get; set; }

        // Descripción del producto
        public string Descripcion { get; set; }

        // Precio del producto de tipo decimal para manejar valores monetarios
        public decimal Precio { get; set; }

        // Cantidad en stock del producto
        public int Stock { get; set; }

        // Marca del producto
        public string Marca { get; set; }

        // Categoría del producto
        public string Categoria { get; set; }
    }
}
