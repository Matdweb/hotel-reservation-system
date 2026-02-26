using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorIdAD;
using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.AgregarReservacion;
using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservaPorId;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones.AgregarReservacionLN;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.AccesoADatos.Habitaciones.ObtenerHabitacionPorId;
using Matias_Vargas.AccesoADatos.Reservaciones.AgregarReservacion;
using Matias_Vargas.AccesoADatos.Reservaciones.ObtenerReservaPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Reservaciones.AgregarReservacion
{
    public class AgregarReservacionLN : IAgregarReservacionLN
    {
        IAgregarReservacionAD _agregarReservacionAD;
        IObtenerHabitacionPorIdAD _obtenerHabitacionPorIdAD;

        public AgregarReservacionLN()
        {
            _agregarReservacionAD = new AgregarReservacionAD();
            _obtenerHabitacionPorIdAD = new ObtenerHabitacionPorIdAD();
        }

        public int Agregar(ReservacionesDto reservacion)
        {
            reservacion.FechaDeRegistro = DateTime.Now;
            HabitacionesDto habitacion = _obtenerHabitacionPorIdAD.Obtener(reservacion.IdHabitacion);
            int costoPorDia = (int)habitacion.CostoDeReserva;
            int costoDeLimpieza = (int)habitacion.CostoDeLimpieza;
            reservacion.MontoTotal = CalcularMontoTotal(reservacion.FechaInicioReserva, reservacion.FechaFinReserva, costoPorDia, costoDeLimpieza);
            return _agregarReservacionAD.AgregarReservacion(reservacion);
        }

        private decimal CalcularMontoTotal(DateTime fechaInicioReserva, DateTime fechaFinReserva, decimal costoPorDia, decimal costoDeLimpieza)
        {
            TimeSpan duracionReserva = fechaFinReserva - fechaInicioReserva;
            int cantidadDeDias = duracionReserva.Days;
            return (cantidadDeDias * costoPorDia)+costoDeLimpieza;
        }
    }
}
