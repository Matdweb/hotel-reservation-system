using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservaPorId
{
    public interface IObtenerReservaPorIdAD
    {
        ReservacionesconHabitacionDto ObtenerPorId(int id);
    }
}
