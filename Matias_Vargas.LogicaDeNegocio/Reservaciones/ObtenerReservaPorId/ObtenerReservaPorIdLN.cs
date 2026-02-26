using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenterTodasLasHabitaciones;
using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservaPorId;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.AccesoADatos.Habitaciones.ObtenerTodasLasHabitaciones;
using Matias_Vargas.AccesoADatos.Reservaciones.ObtenerReservaPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Reservaciones.ObtenerReservaPorId
{
    public class ObtenerReservaPorIdLN : IObtenerReservaPorIdLN
    {
        IObtenerReservaPorIdAD _obtenerReservaPorIdAD;

        public ObtenerReservaPorIdLN()
        {
            _obtenerReservaPorIdAD = new ObtenerReservaPorIdAD();
        }
        public ReservacionesconHabitacionDto ObtenerPorId(int id)
        {
            ReservacionesconHabitacionDto laReserva = _obtenerReservaPorIdAD.ObtenerPorId(id);
            return laReserva;
        }
    }
}
