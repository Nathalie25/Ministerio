﻿using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class controlEstudiante
    {
        // instanciar la conexion a la base de datos
        dbMinisterioEntities contex = new dbMinisterioEntities();

        public object ListarEstudiantes()
        {
            // LinQ
            var datos = from a in contex.Estudiante
                        where a.Estado == "1"
                        select new
                        {
                            Codigo = a.IdEstudiante,
                            Estudiante = a.Persona.Nombre + a.Persona.ApellidoPaterno + a.Persona.ApellidoMaterno,
                            Promedio = a.Promedio
                        };
            return datos.ToList();
        }

        public Estudiante ObtenerEstudiante(int codPersona)
        {
            Estudiante tuplaEstudiante = contex.Estudiante.Find(codPersona);
            return tuplaEstudiante;
        }

        public void Nuevo(int CI, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, int telefono, int rude, int promedio, int estado)
        {
            //int nuevoID = contex.Persona.Max(a => a.IdPersona) + 1;
            Persona tuplaPersona = new Persona();
            //tuplaPersona.IdPersona = nuevoID;
            tuplaPersona.CiPersona = CI;
            tuplaPersona.Nombre = nombre;
            tuplaPersona.ApellidoPaterno = apellidopaterno;
            tuplaPersona.ApellidoMaterno = apellidomaterno;
            tuplaPersona.Correo = correo;
            tuplaPersona.Direccion = direccion;
            tuplaPersona.Telefono = telefono;
            contex.Persona.Add(tuplaPersona);
            contex.SaveChanges();
            Estudiante tuplaEstudiante = new Estudiante();
            tuplaEstudiante.IdEstudiante = tuplaPersona.IdPersona;
            tuplaEstudiante.RUDE = rude;
            tuplaEstudiante.Promedio = promedio;
            tuplaEstudiante.Estado = estado.ToString();
            contex.Estudiante.Add(tuplaEstudiante);
            contex.SaveChanges();
        }

        public void ELiminar(int codPersona)
        {
            Estudiante tuplaEstudiante = contex.Estudiante.Find(codPersona);
            tuplaEstudiante.Estado = "2";
            contex.SaveChanges();
        }

        public void Editar(int codPersona, int cI, string nombre, string apellidopaterno, string apellidomaterno, string correo, string direccion, int telefono, int rude, int promedio, int estado)
        {
            Persona tuplaPersona = contex.Persona.Find(codPersona);
            tuplaPersona.Nombre = nombre;
            tuplaPersona.ApellidoPaterno = apellidopaterno;
            tuplaPersona.ApellidoMaterno = apellidomaterno;
            tuplaPersona.Correo = correo;
            tuplaPersona.Direccion = direccion;
            tuplaPersona.Telefono = telefono;
            tuplaPersona.Estudiante.IdEstudiante = tuplaPersona.IdPersona;
            tuplaPersona.Estudiante.RUDE = rude;
            tuplaPersona.Estudiante.Promedio = promedio;
            tuplaPersona.Estudiante.Estado = estado.ToString();
            contex.SaveChanges();
        }
    }
}
