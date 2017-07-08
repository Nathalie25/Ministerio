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
            //obtiene la bandera
            string accion = (string)Session["accion"];
            //pregunta silabandera esta en modo EDITAR
            if (accion == "Editar" && !IsPostBack)
            {
                //obtiene el ID persona
                int codPersona = (int)Session["codPersona"];

                //obtener datos
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
            // obtener la bandera
            string accion = (string)Session["accion"];
            // obtengo los datos
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

            // pregunto si la bandera esta para editar o nuevo
            if (accion == "Nuevo")
            {
                // invoco elmetodo NUEVO mandandoletodos los datos
                objControlEstudiante.Nuevo(CI, nombre, apellidopaterno, apellidomaterno, correo, direccion, Telefono, Rude, promedio, estado);
                // ir al otroformulario
                Response.Redirect("wfEstudiante");
            }
            else if (accion == "Editar")
            {
                // obtener elID del estudiante
                int codPersona = (int)Session["codPersona"];
                // invoco elmetodo EDITAR mandandoletodos los datos mas el ID del estudiante que voy a editar
                objControlEstudiante.Editar(codPersona, CI, nombre, apellidopaterno, apellidomaterno, correo, direccion, Telefono, Rude, promedio, estado);
                //ir al otro formulario
                Response.Redirect("wfEstudiante");
            }
        }
    }
}