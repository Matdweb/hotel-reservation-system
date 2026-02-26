using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.EditarHabitacion;
using Matias_Vargas.Abstracciones.LogicaDeNegocio.EditarHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Habitaciones.EditarHabitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.LogicaDeNegocio.Habitaciones.EditarHabitacion
{
    public class EditarHabitacionLN : IEditarHabitacionLN
    {
        IEditarHabitacionAD _editarHabitacionAD;
        public EditarHabitacionLN()
        {
            _editarHabitacionAD = new EditarHabitacionAD();
        }
        public bool Editar(HabitacionesDto laHabitacionEditar)
        {
            laHabitacionEditar.FechaDeModificacion = DateTime.Now;
            int resultadoDeLaEdicion = _editarHabitacionAD.Editar(laHabitacionEditar);
            return resultadoDeLaEdicion > 0;
        }
    }
}
