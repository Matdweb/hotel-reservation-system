using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.AgregarHabitacion;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.AgregarHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Habitaciones.AgregarHabitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Habitaciones.AgregarHabitacion
{
    public class AgregarHabitacionLN : IAgregarHabitacionLN
    {
            IAgregarHabitacionAD _agregarHabitacionAD;
    
            public AgregarHabitacionLN()
            {
                _agregarHabitacionAD = new AgregarHabitacionAD();
            }
    
            public int Agregar(HabitacionesDto laHabitacion)
            {
                laHabitacion.FechaDeRegistro = DateTime.Now;
                laHabitacion.FechaDeModificacion = DateTime.Now;
                laHabitacion.Estado = true;

                return _agregarHabitacionAD.Agregar(laHabitacion);
        }
    }
}
