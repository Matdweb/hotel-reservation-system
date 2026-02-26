using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservasPorIdHabitacion;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones.ObtenerReservasPorIdHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.AccesoADatos.Reservaciones.ObtenerReservasPorIdHabitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Reservaciones.ObtenerReservasPorIdHabitacion
{
    public class ObtenerReservasPorIdHabitacionLN : IObtenerReservasPorIdHabitacionLN
    {
        IObtenerReservasPorIdHabitacionAD _obtenerReservasPorIdHabitacionAD;

        public ObtenerReservasPorIdHabitacionLN()
        {
            _obtenerReservasPorIdHabitacionAD = new ObtenerReservasPorIdHabitacionAD();
        }

        public List<ReservacionesDto> Obtener(int idHabitacion)
        {
            var listaReservas = _obtenerReservasPorIdHabitacionAD.Obtener(idHabitacion);
            return listaReservas;
        }
    }
}
