using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Linq;

namespace Logica
{
    public class controlColegio
    {
        dbMinisterioEntities contex = new dbMinisterioEntities();

        public object ListarColegio()
        {
            var datos = from a in contex.Colegio
                        select new
                        {
                            Codigo = a.IdColegio,
                            Sie = a.SIE,
                            Nombre = a.Nombre,
                            Resolucion = a.Resolucion,
                            FechaResolucion = a.FechaResolucion,
                            Direccion =a.Direccion,
                            Detalle = a.Detalle,
                            Distrito = a.Distrito,
                            Turno = a.Turno,
                            Tipo = a.TipoColegio,
                     
                        };
            return datos.ToList();
        }

        public Colegio ObtenerColegio(int idColegio)
        {
            Colegio tuplaColegio = contex.Colegio.Find(idColegio);
            return tuplaColegio;

        }
        public void Nuevo(int sIE, string nombre, string resolucion, DateTime fechaResolucion, int telefono, string direccion, string detalle, int idDistrito, int idTurno,int idTipo,int estado)
        {
            Colegio tuplaColegio = new Colegio();
            tuplaColegio.SIE = sIE;
            tuplaColegio.Nombre = nombre;
            tuplaColegio.Resolucion = resolucion;
            tuplaColegio.FechaResolucion = fechaResolucion;
            tuplaColegio.Direccion = direccion;
            tuplaColegio.Detalle = detalle;
            tuplaColegio.IdDistrito = idDistrito;
            tuplaColegio.IdTurno =idTurno;
            tuplaColegio.IdTipoColegio = idTipo;
            tuplaColegio.Estado = estado;
            contex.Colegio.Add(tuplaColegio);
            contex.SaveChanges();
        }

        

        public void Editar(int idColegio, int sIE, string nombre, string resolucion, DateTime fechaResolucion, int telefono, string direccion, string detalle, int idDistrito, int idTurno, int idTipo, int estado)
        {
            Colegio tuplaColegio = contex.Colegio.Find(idColegio);
            tuplaColegio.SIE = sIE;
            tuplaColegio.Nombre = nombre;
            tuplaColegio.Resolucion = resolucion;
            tuplaColegio.FechaResolucion = fechaResolucion;
            tuplaColegio.Direccion = direccion;
            tuplaColegio.Detalle = detalle;
            tuplaColegio.IdDistrito = idDistrito;
            tuplaColegio.IdTurno = idTurno;
            tuplaColegio.IdTipoColegio = idTurno;
            tuplaColegio.Estado = estado;
            
            contex.SaveChanges();
        }
        public void ELiminar(int idColegio)
        {
            Colegio tuplaColegio = contex.Colegio.Find(idColegio);
            tuplaColegio.Estado = 2;
            contex.SaveChanges();
        }
    }
}
