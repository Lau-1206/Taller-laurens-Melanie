using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Taller.CapaPresentacion
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        void LlenarGrid()
        {
            string s = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            using (SqlCommand cmd = new SqlCommand("select * from Usuarios", con))
            {
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Usuarios_Logica.Agregarusuario(int.Parse(txtid.Text), txtnombre.Text, txtcorreo.Text, txttel.Text) > 0)
            {
                lblmsg.Text = "Usuario agregado";
                LlenarGrid();
            }
            else lblmsg.Text = "No se pudo agregar";
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Usuarios_Logica.Modificarusuario(int.Parse(txtid.Text), txtnombre.Text, txtcorreo.Text, txttel.Text) > 0)
            {
                lblmsg.Text = "Usuario modificado";
                LlenarGrid();
            }
            else lblmsg.Text = "No se pudo modificar";
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Usuarios_Logica.Borrarusuario(int.Parse(txtid.Text)) > 0)
            {
                lblmsg.Text = "Usuario borrado";
                LlenarGrid();
            }
            else lblmsg.Text = "No se pudo borrar (tiene equipos?)";
        }
    }
}
