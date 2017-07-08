using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfEstudiante : Page
    {
        //instamciar la clase controlador
        controlEstudiante objControlEstudiante = new controlEstudiante();

        protected void Page_Load(object sender, EventArgs e)
        {
            //mostrar los estudiante en el dataGrid
            gvEstudiantes.DataSource = objControlEstudiante.ListarEstudiantes();
            gvEstudiantes.DataBind();
        }

        protected void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            // estableser labandera en NUEVO
            string accion = "Nuevo";
            Session["accion"] = accion;
            // ir alotro formulario
            Response.Redirect("wfEstudianteGestion");
        }

        protected void gvEstudiantes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            // obtener la filaque se hiso clic
            int fila = e.NewSelectedIndex;
            // obtener el ID delestudiante que vamos a editar
            int codPersona = int.Parse(gvEstudiantes.Rows[fila].Cells[2].Text);

            //estableser labandera en EDITAR
            string accion = "Editar";
            Session["accion"] = accion;

            Session["codPersona"] = codPersona;

            //IRAL OTROFORMULARIO
            Response.Redirect("wfEstudianteGestion");
        }

        protected void gvEstudiantes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // obtener la filaque se hiso clic
            int fila = e.RowIndex;
            // obtener el ID delestudiante que vamos a ELIMINAR LOGICAMENTE
            int codPersona = int.Parse(gvEstudiantes.Rows[fila].Cells[2].Text);

            //invocarel metodo eliminar
            objControlEstudiante.ELiminar(codPersona);


            //mostrar los estudiante en el dataGrid
            gvEstudiantes.DataSource = objControlEstudiante.ListarEstudiantes();
            gvEstudiantes.DataBind();

        }
    }
}