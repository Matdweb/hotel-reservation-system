using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenterTodasLasHabitaciones;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.ObtenerTodasLasHabitaciones;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Habitaciones.ObtenerTodasLasHabitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Habitaciones.ObtenerTodasLasHabitaciones
{
    public class ObtenerTodasLasHabitacionesLN : IObtenerTodasLasHabitacionesLN
    {
        IObtenerTodasLasHabitacionesAD _obtenerTodasLasHabitacionesAD;

        public ObtenerTodasLasHabitacionesLN()
        {
            _obtenerTodasLasHabitacionesAD = new ObtenterTodasLasHabitacionesAD();
        }

        public List<HabitacionesDto> Obtener()
        {
            List<HabitacionesDto> listaDeHabitaciones = _obtenerTodasLasHabitacionesAD.Obtener();
            return listaDeHabitaciones;
        }

        public List<HabitacionesDto> ObtenerActivas()
        {
            List<HabitacionesDto> listaDeHabitaciones = _obtenerTodasLasHabitacionesAD.Obtener();
            List<HabitacionesDto> listaDeHabitacionesActivas = listaDeHabitaciones.Where(h => h.Estado == true).ToList();
            return listaDeHabitacionesActivas;
        }
    }
}
