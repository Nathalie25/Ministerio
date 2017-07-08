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
            gvEstudiantes.DataSource = objControlEstudiante.ListarEstudiantes();
            gvEstudiantes.DataBind();
        }

        protected void btnNuevoEstudiante_Click(object sender, EventArgs e)
        {
            string accion = "Nuevo";
            Session["accion"] = accion;
            Response.Redirect("wfEstudianteGestion");
        }

        protected void gvEstudiantes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int fila = e.NewSelectedIndex;
            string accion = "Editar";
            int codPersona = int.Parse(gvEstudiantes.Rows[fila].Cells[2].Text);

            Session["accion"] = accion;
            Session["codPersona"] = codPersona;
            Response.Redirect("wfEstudianteGestion");
        }

        protected void gvEstudiantes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int fila = e.RowIndex;
            int codPersona = int.Parse(gvEstudiantes.Rows[fila].Cells[2].Text);

            objControlEstudiante.ELiminar(codPersona);
            gvEstudiantes.DataSource = objControlEstudiante.ListarEstudiantes();
            gvEstudiantes.DataBind();

        }
    }
}