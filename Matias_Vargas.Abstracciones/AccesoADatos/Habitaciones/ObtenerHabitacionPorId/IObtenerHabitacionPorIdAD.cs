using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorIdAD
{
    public interface IObtenerHabitacionPorIdAD
    {
        HabitacionesDto Obtener(int id);
    }
}
