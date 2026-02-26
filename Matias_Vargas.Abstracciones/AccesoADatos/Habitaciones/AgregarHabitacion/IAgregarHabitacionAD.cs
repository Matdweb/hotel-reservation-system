using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.AgregarHabitacion
{
    public interface IAgregarHabitacionAD
    {
        int Agregar(HabitacionesDto laHabitacion);
    }
}
