// Laurens Urbina y Melanie Chacon
using System.Data.SqlClient;

namespace Taller.Capa_Logica
{
    public class DBconn
    {
        public static SqlConnection obtenerConexion()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection c = new SqlConnection(s);
            c.Open();
            return c;
        }
    }
}
