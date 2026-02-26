using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerTodasLasReservas;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Reservaciones;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.AccesoADatos.Reservaciones.ObtenerTodasLasReservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Reservaciones.ObtenerTodasLasReservas
{
    public class ObtenerTodasLasReservasLN : IObtenerTodasLasReservasLN
    {
        IObtenerTodasLasReservasAD _obtenterTodasLasReservasAD;

        public ObtenerTodasLasReservasLN()
        {
            _obtenterTodasLasReservasAD = new ObtenerTodasLasReservasAD();
        }

        public List<ReservacionesconHabitacionDto> Obtener()
        {
            var listaReservas = _obtenterTodasLasReservasAD.Obtener();
            return listaReservas;
        }
    }
}
