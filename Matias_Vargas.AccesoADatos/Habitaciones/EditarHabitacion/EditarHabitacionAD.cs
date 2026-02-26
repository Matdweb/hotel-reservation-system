using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.EditarHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Habitaciones.EditarHabitacion
{
    public class EditarHabitacionAD : IEditarHabitacionAD
    {
        Contexto _elContexto;

        public EditarHabitacionAD()
        {
            _elContexto = new Contexto();
        }

            public int Editar(HabitacionesDto laHabitacionEditar)
            {
                HabitacionesEntidad laHabitacionEnBaseDeDatos = _elContexto.HabitacionesEntidad
                .Where(x => x.Id == laHabitacionEditar.Id).FirstOrDefault();

            if (laHabitacionEnBaseDeDatos != null)
            {
                laHabitacionEnBaseDeDatos.CantidadDeHuespedesPermitidos = laHabitacionEditar.CantidadDeHuespedesPermitidos;
                laHabitacionEnBaseDeDatos.CantidadDeCamas = laHabitacionEditar.CantidadDeCamas;
                laHabitacionEnBaseDeDatos.EncargadoDeLimpieza = laHabitacionEditar.EncargadoDeLimpieza;
                laHabitacionEnBaseDeDatos.TipoDeHabitacion = laHabitacionEditar.TipoDeHabitacion;
                laHabitacionEnBaseDeDatos.CostoDeLimpieza = laHabitacionEditar.CostoDeLimpieza;
                laHabitacionEnBaseDeDatos.CostoDeReserva = laHabitacionEditar.CostoDeReserva;
                laHabitacionEnBaseDeDatos.FechaDeModificacion = DateTime.Now;
                laHabitacionEnBaseDeDatos.Estado = laHabitacionEditar.Estado;

                return _elContexto.SaveChanges();
            }
            else
            {
                return 0;
            }
            }
        }
}
