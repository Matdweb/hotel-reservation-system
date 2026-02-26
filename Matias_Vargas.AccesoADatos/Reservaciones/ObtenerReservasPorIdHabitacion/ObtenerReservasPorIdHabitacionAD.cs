using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservasPorIdHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Reservaciones.ObtenerReservasPorIdHabitacion
{
    public class ObtenerReservasPorIdHabitacionAD : IObtenerReservasPorIdHabitacionAD
    {
        Contexto _elContexto;

        public ObtenerReservasPorIdHabitacionAD()
        {
            _elContexto = new Contexto();
        }

        public List<ReservacionesDto> Obtener(int idHabitacion)
        {
            var listaReservas = (from r in _elContexto.ReservacionesEntidad
                                 join h in _elContexto.HabitacionesEntidad on r.IdHabitacion equals h.Id
                                 where r.IdHabitacion == idHabitacion
                                 select new ReservacionesDto
                                 {
                                     Id = r.Id,
                                     NombreDeLaPersona = r.NombreDeLaPersona,
                                     Identificacion = r.Identificacion,
                                     Telefono = r.Telefono,
                                     Correo = r.Correo,
                                     FechaNacimiento = r.FechaNacimiento,
                                     MontoTotal = r.MontoTotal,
                                     FechaInicioReserva = r.FechaInicioReserva,
                                     FechaFinReserva = r.FechaFinReserva,
                                     FechaDeRegistro = r.FechaDeRegistro,
                                 }).ToList();
            return listaReservas;
        }
    }
}
