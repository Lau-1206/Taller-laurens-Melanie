// Laurens Urbina y Melanie Chacon
using System.Data.SqlClient;

namespace Taller.Capa_Logica
{
    public class Usuarios_Logica
    {
        public static int Agregarusuario(int id, string nombre, string correo, string tel)
        {
            int r = 0;
            try
            {
                using (SqlConnection c = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("insert into Usuarios (UsuarioID, Nombre, CorreoElectronico, Telefono) values (@id,@nombre,@correo,@tel)", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { r = 0; }
            return r;
        }

        public static int Modificarusuario(int id, string nombre, string correo, string tel)
        {
            int r = 0;
            try
            {
                using (SqlConnection c = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("update Usuarios set Nombre=@nombre, CorreoElectronico=@correo, Telefono=@tel where UsuarioID=@id", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { r = 0; }
            return r;
        }

        public static int Borrarusuario(int id)
        {
            int r = 0;
            try
            {
                using (SqlConnection c = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("delete from Usuarios where UsuarioID=@id", c);
                    cmd.Parameters.AddWithValue("@id", id);
                    r = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException) { r = 0; }
            return r;
        }
    }
}
