using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorIdAD;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.Habitaciones.ObtenerHabitacionPorId;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using Matias_Vargas.AccesoADatos.Habitaciones.ObtenerHabitacionPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Habitaciones.ObtenerHabitacionPorId
{
    public class ObtenerHabitacionPorIdLN : IObtenerHabitacionPorIdLN
    {
        IObtenerHabitacionPorIdAD _obtenerHabitacionPorIdAD;

        public ObtenerHabitacionPorIdLN()
        {
            _obtenerHabitacionPorIdAD = new ObtenerHabitacionPorIdAD();
        }

        public HabitacionesDto Obtener(int id)
        {
            HabitacionesDto laHabitacionEnBaseDeDatos = _obtenerHabitacionPorIdAD.Obtener(id);
            return laHabitacionEnBaseDeDatos;
        }

    }
}
