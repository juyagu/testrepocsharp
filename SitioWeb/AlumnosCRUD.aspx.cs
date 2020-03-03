using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObjetosDeNegocios;

namespace SitioWeb
{
    public partial class AlumnosCRUD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*List<AlumnoEntidad> lista = new List<AlumnoEntidad>();
            lista = BLL.AlumnosNet.ListAlumnos();
            ListadoAlumnos.DataSource = lista;
            ListadoAlumnos.DataBind();*/
        }

        protected void ListadoAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}