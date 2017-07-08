using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfColegio1 : System.Web.UI.Page
    {
        controlColegio objControlColegio = new controlColegio();
        protected void Page_Load(object sender, EventArgs e)
        {

            dgvColegio.DataSource = objControlColegio.ListarColegio();
            dgvColegio.DataBind();
        }

        protected void btnGuardarColegio_Click(object sender, EventArgs e)
        {
            string accion = "Nuevo";
            Session["accion"] = accion;
            Response.Redirect("wfColegioGestion");
        }

        protected void dgvColegio_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int fila = e.RowIndex;
            int idColegio = int.Parse(dgvColegio.Rows[fila].Cells[2].Text);

            objControlColegio.ELiminar(idColegio);
            dgvColegio.DataSource = objControlColegio.ListarColegio();
            dgvColegio.DataBind();
        }

        protected void dgvColegio_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int fila = e.NewSelectedIndex;
            string accion = "Editar";
            int idColegio = int.Parse(dgvColegio.Rows[fila].Cells[2].Text);

            Session["accion"] = accion;
            Session["idColegio"] = idColegio;
            Response.Redirect("wfColegioGestion");
        }
    }
}