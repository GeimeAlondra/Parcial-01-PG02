using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DBConectar
    {
        // Propiedad para tiempo de espera de conexión
        public static int ConnectionTimeout { get; set; }

        // Propiedad para nombre de la aplicación
        public static string ApplicationName { get; set; }

        // Propiedad que construye y retorna la cadena de conexión
        public static string ConnectionString
        {
            get
            {
                // Obtiene la cadena de conexión desde el archivo de configuración
                string CadenaConexion = ConfigurationManager.ConnectionStrings["ParcialConnection"].ConnectionString;

                // Crea un objeto para manipular la cadena de conexión
                SqlConnectionStringBuilder conexionBuilder = new SqlConnectionStringBuilder(CadenaConexion);

                // Asigna el nombre de la aplicación si está establecido
                conexionBuilder.ApplicationName = ApplicationName ?? conexionBuilder.ApplicationName;

                // Asigna el tiempo de espera si es mayor que 0
                conexionBuilder.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : conexionBuilder.ConnectTimeout;

                // Retorna la cadena de conexión completa
                return conexionBuilder.ToString();
            }
        }

        // Método que devuelve una conexión SQL abierta
        public static SqlConnection GetSqlConnection()
        {
            // Crea una conexión SQL con la cadena de conexión personalizada
            SqlConnection conexion = new SqlConnection(ConnectionString);

            // Abre la conexión
            conexion.Open();

            // Retorna la conexión abierta
            return conexion;
        }
    }
}
