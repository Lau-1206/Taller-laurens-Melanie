// Laurens Urbina y Melanie Chacon
using System.Data.SqlClient;

namespace Taller.Capa_Logica
{
    public class Equipos_Logica
    {
        public static int Agregarequipo(int id, string tipo, string modelo, int idusuario)
        {
            int r = 0;
            try
            {
                using (SqlConnection c = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("insert into Equipos (EquipoID, TipoEquipo, Modelo, UsuarioID) values (@id,@tipo,@modelo,@idu)", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@idu", idusuario);
                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { r = 0; }
            return r;
        }

        public static int Modificarequipo(int id, string tipo, string modelo, int idusuario)
        {
            int r = 0;
            try
            {
                using (SqlConnection c = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update Equipos set TipoEquipo=@tipo, Modelo=@modelo, UsuarioID=@idu where EquipoID=@id", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@idu", idusuario);
                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { r = 0; }
            return r;
        }

        public static int Borrarequipo(int id)
        {
            int r = 0;
            try
            {
                using (SqlConnection c = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("delete from Equipos where EquipoID=@id", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { r = 0; }
            return r;
        }
    }
}
