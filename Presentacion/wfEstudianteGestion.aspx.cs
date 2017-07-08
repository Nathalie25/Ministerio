using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class wfEstudianteGestion : System.Web.UI.Page
    {
        //instamciar la clase controlador
        controlEstudiante objControlEstudiante = new controlEstudiante();

        protected void Page_Load(object sender, EventArgs e)
        {
            string accion = (string)Session["accion"];
            if (accion == "Editar" && !IsPostBack)
            {
                int codPersona = (int)Session["codPersona"];
                txbCI.Text = objControlEstudiante.ObtenerEstudiante(codPersona).Persona.CiPersona.ToString();
                txbNombre.Text = objControlEstudiante.ObtenerEstudiante(codPersona).Persona.Nombre;
                txbPaterno.Text = objControlEstudiante.ObtenerEstudiante(codPersona).Persona.ApellidoPaterno;
                txbMaterno.Text = objControlEstudiante.ObtenerEstudiante(codPersona).Persona.ApellidoMaterno;
                txbCorreo.Text =  objControlEstudiante.ObtenerEstudiante(codPersona).Persona.Correo;
                txbDireccion.Text = objControlEstudiante.ObtenerEstudiante(codPersona).Persona.Direccion;
                txbTelefono.Text =  objControlEstudiante.ObtenerEstudiante(codPersona).Persona.Telefono.ToString();
                txbRude.Text = objControlEstudiante.ObtenerEstudiante(codPersona).RUDE.ToString();
                txbPromedio.Text = objControlEstudiante.ObtenerEstudiante(codPersona).Promedio.ToString();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string accion = (string)Session["accion"];
            int CI = int.Parse(txbCI.Text);
            string nombre = txbNombre.Text;
            string apellidopaterno = txbPaterno.Text;
            string apellidomaterno = txbMaterno.Text;
            string correo = txbCorreo.Text;
            string direccion = txbDireccion.Text;
            int Telefono = int.Parse(txbTelefono.Text);
            int Rude = int.Parse(txbRude.Text);
            int promedio = int.Parse(txbPromedio.Text);
            int estado = 1;

            if (accion == "Nuevo")
            {
                objControlEstudiante.Nuevo(CI, nombre, apellidopaterno, apellidomaterno, correo, direccion, Telefono, Rude, promedio, estado);
                Response.Redirect("wfEstudiante");
            }
            else if (accion == "Editar")
            {
                int codPersona = (int)Session["codPersona"];
                objControlEstudiante.Editar(codPersona, CI, nombre, apellidopaterno, apellidomaterno, correo, direccion, Telefono, Rude, promedio, estado);
                Response.Redirect("wfEstudiante");
            }
        }
    }
}