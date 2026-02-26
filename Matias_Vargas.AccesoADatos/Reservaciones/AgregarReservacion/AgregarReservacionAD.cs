using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.AgregarReservacion;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Reservaciones.AgregarReservacion
{
    public class AgregarReservacionAD : IAgregarReservacionAD
    {
        Contexto _elContexto;

        public AgregarReservacionAD()
        {
            _elContexto = new Contexto();
        }

        public int AgregarReservacion(ReservacionesDto reservacion)
        {
            ReservacionesEntidad laReservaAgregar = ConvertirObjetoAEntidad(reservacion);

            _elContexto.ReservacionesEntidad.Add(laReservaAgregar);
            int cantidadReservacionesAgregadas = _elContexto.SaveChanges();
            return cantidadReservacionesAgregadas;
        }

        public ReservacionesEntidad ConvertirObjetoAEntidad(ReservacionesDto reservacion)
        {
            return new ReservacionesEntidad
            {
                Id = reservacion.Id,
                NombreDeLaPersona = reservacion.NombreDeLaPersona,
                Identificacion = reservacion.Identificacion,
                Telefono = reservacion.Telefono,
                Correo = reservacion.Correo,
                FechaNacimiento = reservacion.FechaNacimiento,
                Direccion = reservacion.Direccion,
                MontoTotal = reservacion.MontoTotal,
                FechaInicioReserva = reservacion.FechaInicioReserva,
                FechaFinReserva = reservacion.FechaFinReserva,
                FechaDeRegistro = reservacion.FechaDeRegistro,
                IdHabitacion = reservacion.IdHabitacion
            };
        }
    }
}
