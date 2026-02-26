using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.EditarHabitacion
{
    public interface IEditarHabitacionAD
    {
        int Editar(HabitacionesDto laHabitacionEditar);
    }
}
