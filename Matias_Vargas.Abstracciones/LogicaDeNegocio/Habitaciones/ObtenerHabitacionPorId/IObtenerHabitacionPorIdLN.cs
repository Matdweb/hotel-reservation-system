using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.LogicaDeNegocio.Habitaciones.ObtenerHabitacionPorId
{
    public interface IObtenerHabitacionPorIdLN
    {
        HabitacionesDto Obtener(int id);
    }
}
