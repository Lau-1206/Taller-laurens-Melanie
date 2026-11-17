using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Taller.CapaPresentacion
{
    public partial class Equipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        void LlenarGrid()
        {
            string s = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            using (SqlCommand cmd = new SqlCommand("select * from Equipos", con))
            {
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Equipos_Logica.Agregarequipo(int.Parse(txtid.Text), txttipo.Text, txtmodelo.Text, int.Parse(txtidu.Text)) > 0)
            {
                lblmsg.Text = "Equipo agregado";
                LlenarGrid();
            }
            else lblmsg.Text = "No se pudo agregar (existe el usuario?)";
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Equipos_Logica.Modificarequipo(int.Parse(txtid.Text), txttipo.Text, txtmodelo.Text, int.Parse(txtidu.Text)) > 0)
            {
                lblmsg.Text = "Equipo modificado";
                LlenarGrid();
            }
            else lblmsg.Text = "No se pudo modificar";
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (Capa_Logica.Equipos_Logica.Borrarequipo(int.Parse(txtid.Text)) > 0)
            {
                lblmsg.Text = "Equipo borrado";
                LlenarGrid();
            }
            else lblmsg.Text = "No se pudo borrar";
        }
    }
}
