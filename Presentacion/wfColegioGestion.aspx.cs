using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Logica;


namespace Presentacion
{
    public partial class wfColegioGestion : System.Web.UI.Page
    {
        controlColegio objcontrolcolegio = new controlColegio();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string accion = (string)Session["accion"];
            int SIE = int.Parse(txbSIE.Text);
            string nombre = txbNombre.Text;
            string resolucion = txbResolucion.Text;
            DateTime FechaResolucion = DateTime.Parse(txbFechaRes.Text);
            int telefono = int.Parse(txbTelefono.Text);
            string direccion = txbDireccion.Text;
            string detalle = txbDetalle.Text;
            int idDistrito = 1;//int.Parse( ddlDistrito.SelectedValue);
            int idTurno = 1;/// int.Parse( ddlTurno.SelectedValue);
            int idTipo = 1;//int.Parse( ddlTipo.SelectedValue);
            int estado = 1;

            if (accion == "Nuevo")
            {

                objcontrolcolegio.Nuevo(SIE,nombre,resolucion,FechaResolucion,telefono,direccion,detalle,idDistrito,idTurno,idTipo,estado);
                Response.Redirect("wfColegio");
            }
            else if (accion == "Editar")
            {
                int idColegio = (int)Session["idColegio"];
                objcontrolcolegio.Editar(idColegio,SIE,nombre,resolucion,FechaResolucion,telefono,direccion, detalle, idDistrito, idTurno, idTipo,estado);
                Response.Redirect("wfColegio");
            }
        }
    }
}