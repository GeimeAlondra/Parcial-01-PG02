using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        public Producto LeerDelDataReader(SqlDataReader reader)
        {
            // Crea una nueva instancia de Producto
            Producto producto = new Producto();

            // Asigna el valor correspondiente a cada campo, manejando los posibles valores nulos
            producto.Id = reader["Id"] == DBNull.Value ? 0 : (int)reader["Id"];
            producto.Nombre = reader["Nombre"] == DBNull.Value ? "" : (string)reader["Nombre"];
            producto.Descripcion = reader["Descripcion"] == DBNull.Value ? "" : (string)reader["Descripcion"];
            producto.Precio = reader["Precio"] == DBNull.Value ? 0 : (decimal)reader["Precio"];
            producto.Stock = reader["Stock"] == DBNull.Value ? 0 : (int)reader["Stock"];
            producto.Marca = reader["Marca"] == DBNull.Value ? "" : (string)reader["Marca"];
            producto.Categoria = reader["Categoria"] == DBNull.Value ? "" : (string)reader["Categoria"];

            // Retorna el objeto Producto completamente inicializado
            return producto;
        }

        public List<Producto> ObtenerTodos()
        {
            // Establece la conexión a la base de datos usando un bloque using para garantizar su cierre
            using (var conexion = DBConectar.GetSqlConnection())
            {
                // Construye la consulta SQL para seleccionar todas las columnas de la tabla Productos
                String selectFrom = "";

                selectFrom = selectFrom + "SELECT [Id] " + "\n";
                selectFrom = selectFrom + "      ,[Nombre] " + "\n";
                selectFrom = selectFrom + "      ,[Descripcion] " + "\n";
                selectFrom = selectFrom + "      ,[Precio] " + "\n";
                selectFrom = selectFrom + "      ,[Stock] " + "\n";
                selectFrom = selectFrom + "      ,[Marca] " + "\n";
                selectFrom = selectFrom + "      ,[Categoria] " + "\n";
                selectFrom = selectFrom + "  FROM [Productos]";

                // Crea y configura el comando SQL con la consulta construida
                using (SqlCommand comando = new SqlCommand(selectFrom, conexion))
                {
                    // Ejecuta la consulta y obtiene un SqlDataReader para leer los resultados
                    SqlDataReader reader = comando.ExecuteReader();

                    // Inicializa una lista para almacenar los productos recuperados
                    List<Producto> Productos = new List<Producto>();

                    // Lee cada registro del SqlDataReader
                    while (reader.Read())
                    {
                        // Convierte el registro actual en un objeto Producto
                        var producto = LeerDelDataReader(reader);

                        // Agrega el producto a la lista
                        Productos.Add(producto);
                    }

                    // Retorna la lista de productos
                    return Productos;
                }
            }
        }

        public Producto ObtenerPorID(int id)
        {
            // Establece la conexión a la base de datos usando un bloque using para garantizar su cierre
            using (var conexion = DBConectar.GetSqlConnection())
            {
                // Construye la consulta SQL para seleccionar un producto por su ID
                String selectForID = "";

                selectForID = selectForID + "SELECT [Id] " + "\n";
                selectForID = selectForID + "      ,[Nombre] " + "\n";
                selectForID = selectForID + "      ,[Descripcion] " + "\n";
                selectForID = selectForID + "      ,[Precio] " + "\n";
                selectForID = selectForID + "      ,[Stock] " + "\n";
                selectForID = selectForID + "      ,[Marca] " + "\n";
                selectForID = selectForID + "      ,[Categoria] " + "\n";
                selectForID = selectForID + "  FROM [Productos]";
                selectForID = selectForID + "  Where Id = @id"; // Agrega la cláusula WHERE para filtrar por ID

                // Crea y configura el comando SQL con la consulta construida
                using (SqlCommand comando = new SqlCommand(selectForID, conexion))
                {
                    // Añade el parámetro para el ID al comando SQL
                    comando.Parameters.AddWithValue("Id", id);

                    // Ejecuta la consulta y obtiene un SqlDataReader para leer el resultado
                    var reader = comando.ExecuteReader();

                    // Inicializa el objeto Producto en null
                    Producto producto = null;

                    // Si se encuentra un registro, se mapea a un objeto Producto
                    if (reader.Read())
                    {
                        producto = LeerDelDataReader(reader);
                    }

                    // Retorna el producto encontrado o null si no se encontró ninguno
                    return producto;
                }
            }
        }

        public List<Producto> FiltroNombre(string nombre)
        {
            // Establece la conexión a la base de datos usando un bloque using para garantizar su cierre
            using (var conexion = DBConectar.GetSqlConnection())
            {
                // Construye la consulta SQL para buscar productos cuyo nombre coincida con la cadena dada
                string busqueda = $"SELECT Id, Nombre, Descripcion, Precio, Stock, Marca, Categoria " +
                                  "FROM [dbo].[Productos] " +
                                  $"WHERE Nombre LIKE @Nombre";

                // Crea y configura el comando SQL con la consulta
                using (SqlCommand comando = new SqlCommand(busqueda, conexion))
                {
                    // Añade el parámetro de búsqueda con comodines para la cláusula LIKE
                    comando.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

                    // Ejecuta la consulta y obtiene un SqlDataReader para leer los resultados
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        // Inicializa una lista para almacenar los productos encontrados
                        List<Producto> productosEncontrados = new List<Producto>();

                        // Itera sobre cada registro encontrado
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto Producto y asigna los valores leídos
                            Producto producto = new Producto
                            {
                                Id = reader.GetInt32(0),           // Obtiene el Id
                                Nombre = reader.GetString(1),      // Obtiene el Nombre
                                Descripcion = reader.GetString(2), // Obtiene la Descripcion
                                Precio = reader.GetDecimal(3),     // Obtiene el Precio
                                Stock = reader.GetInt32(4),        // Obtiene el Stock
                                Marca = reader.GetString(5),       // Obtiene la Marca
                                Categoria = reader.GetString(6)    // Obtiene la Categoria
                            };

                            // Agrega el producto a la lista
                            productosEncontrados.Add(producto);
                        }

                        // Retorna la lista de productos encontrados
                        return productosEncontrados;
                    }
                }
            }
        }

        public int parametrosProducto(Producto producto, SqlCommand comando)
        {
            // Añade el valor de Id como parámetro al comando SQL
            comando.Parameters.AddWithValue("Id", producto.Id);

            // Añade el valor de Nombre como parámetro al comando SQL
            comando.Parameters.AddWithValue("Nombre", producto.Nombre);

            // Añade el valor de Descripcion como parámetro al comando SQL
            comando.Parameters.AddWithValue("Descripcion", producto.Descripcion);

            // Añade el valor de Precio como parámetro al comando SQL
            comando.Parameters.AddWithValue("Precio", producto.Precio);

            // Añade el valor de Stock como parámetro al comando SQL
            comando.Parameters.AddWithValue("Stock", producto.Stock);

            // Añade el valor de Marca como parámetro al comando SQL
            comando.Parameters.AddWithValue("Marca", producto.Marca);

            // Añade el valor de Categoria como parámetro al comando SQL
            comando.Parameters.AddWithValue("Categoria", producto.Categoria);

            // Ejecuta el comando SQL y obtiene el número de filas afectadas
            var insertados = comando.ExecuteNonQuery();

            // Retorna el número de filas afectadas
            return insertados;
        }

        public int GuardarProducto(Producto producto)
        {
            // Establece la conexión a la base de datos usando un bloque using para garantizar su cierre
            using (var conexion = DBConectar.GetSqlConnection())
            {
                // Construye la consulta SQL para insertar un nuevo producto en la tabla Productos
                String insertInto = "";

                insertInto = insertInto + "INSERT INTO [dbo].[Productos] " + "\n";
                insertInto = insertInto + "           ([Nombre] " + "\n";
                insertInto = insertInto + "           ,[Descripcion] " + "\n";
                insertInto = insertInto + "           ,[Precio] " + "\n";
                insertInto = insertInto + "           ,[Stock] " + "\n";
                insertInto = insertInto + "           ,[Marca] " + "\n";
                insertInto = insertInto + "           ,[Categoria]) " + "\n";

                insertInto = insertInto + "     VALUES " + "\n";
                insertInto = insertInto + "           (@Nombre " + "\n";
                insertInto = insertInto + "           ,@Descripcion " + "\n";
                insertInto = insertInto + "           ,@Precio " + "\n";
                insertInto = insertInto + "           ,@Stock " + "\n";
                insertInto = insertInto + "           ,@Marca " + "\n";
                insertInto = insertInto + "           ,@Categoria)";

                // Crea y configura el comando SQL con la consulta de inserción
                using (var comando = new SqlCommand(insertInto, conexion))
                {
                    // Llama a la función que añade los parámetros del producto al comando
                    int insertados = parametrosProducto(producto, comando);

                    // Retorna el número de filas afectadas por la inserción
                    return insertados;
                }
            }
        }

        public int ActualizarProducto(Producto producto)
        {
            // Establece la conexión a la base de datos usando un bloque using para garantizar su cierre
            using (var conexion = DBConectar.GetSqlConnection())
            {
                // Construye la consulta SQL para actualizar un producto existente por su ID
                String ActualizarProductoPorID = "";

                ActualizarProductoPorID = ActualizarProductoPorID + "UPDATE [dbo].[Productos] " + "\n";
                ActualizarProductoPorID = ActualizarProductoPorID + "   SET [Nombre] = @Nombre " + "\n";        
                ActualizarProductoPorID = ActualizarProductoPorID + "      ,[Descripcion] = @Descripcion " + "\n"; 
                ActualizarProductoPorID = ActualizarProductoPorID + "      ,[Precio] = @Precio " + "\n";         
                ActualizarProductoPorID = ActualizarProductoPorID + "      ,[Stock] = @Stock " + "\n";        
                ActualizarProductoPorID = ActualizarProductoPorID + "      ,[Marca] = @Marca " + "\n";            
                ActualizarProductoPorID = ActualizarProductoPorID + "      ,[Categoria] = @Categoria " + "\n";   
                ActualizarProductoPorID = ActualizarProductoPorID + " WHERE Id= @Id";                             

                // Crea y configura el comando SQL con la consulta de actualización
                using (var comando = new SqlCommand(ActualizarProductoPorID, conexion))
                {
                    // Añade los parámetros al comando, incluyendo el Id para especificar qué producto actualizar
                    comando.Parameters.AddWithValue("@Id", producto.Id);
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", producto.Stock);
                    comando.Parameters.AddWithValue("@Marca", producto.Marca);
                    comando.Parameters.AddWithValue("@Categoria", producto.Categoria);

                    // Ejecuta el comando y obtiene el número de filas afectadas por la actualización
                    int actualizados = comando.ExecuteNonQuery();

                    // Retorna el número de filas afectadas
                    return actualizados;
                }
            }
        }

        public int EliminarProducto(int id)
        {
            // Establece la conexión a la base de datos usando un bloque using para garantizar su cierre
            using (var conexion = DBConectar.GetSqlConnection())
            {
                // Construye la consulta SQL para eliminar un producto por su ID
                String EliminarProducto = "";

                EliminarProducto = EliminarProducto + "DELETE FROM [dbo].[Productos] " + "\n"; 
                EliminarProducto = EliminarProducto + "      WHERE Id = @Id";                

                // Crea y configura el comando SQL con la consulta de eliminación
                using (SqlCommand comando = new SqlCommand(EliminarProducto, conexion))
                {
                    // Añade el parámetro del Id al comando SQL
                    comando.Parameters.AddWithValue("@Id", id);

                    // Ejecuta el comando y obtiene el número de filas afectadas por la eliminación
                    int eliminados = comando.ExecuteNonQuery();

                    // Retorna el número de filas afectadas
                    return eliminados;
                }
            }
        }
    }
}
