using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenerHabitacionPorIdAD;
using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservasPorIdHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Habitaciones.ObtenerHabitacionPorId
{
    public class ObtenerHabitacionPorIdAD : IObtenerHabitacionPorIdAD
    {
        Contexto _elContexto;

        public ObtenerHabitacionPorIdAD()
        {
            _elContexto = new Contexto();
        }

        public HabitacionesDto Obtener(int id)
        {
            HabitacionesDto habitacion = (from laHabitacionEnBaseDeDatos in _elContexto.HabitacionesEntidad
                                                       where laHabitacionEnBaseDeDatos.Id == id
                                                       select new HabitacionesDto
                                                       {
                                                           Id = laHabitacionEnBaseDeDatos.Id,
                                                           CodigoDeHabitacion = laHabitacionEnBaseDeDatos.CodigoDeHabitacion,
                                                           NombreDeHabitacion = laHabitacionEnBaseDeDatos.NombreDeHabitacion,
                                                           CantidadDeHuespedesPermitidos = laHabitacionEnBaseDeDatos.CantidadDeHuespedesPermitidos,
                                                           CantidadDeCamas = laHabitacionEnBaseDeDatos.CantidadDeCamas,
                                                           CantidadDeBanos = laHabitacionEnBaseDeDatos.CantidadDeBanos,
                                                           Ubicacion = laHabitacionEnBaseDeDatos.Ubicacion,
                                                           EncargadoDeLimpieza = laHabitacionEnBaseDeDatos.EncargadoDeLimpieza,
                                                           TipoDeHabitacion = laHabitacionEnBaseDeDatos.TipoDeHabitacion,
                                                           CostoDeLimpieza = laHabitacionEnBaseDeDatos.CostoDeLimpieza,
                                                           CostoDeReserva = laHabitacionEnBaseDeDatos.CostoDeReserva,
                                                           FechaDeRegistro = laHabitacionEnBaseDeDatos.FechaDeRegistro,
                                                           FechaDeModificacion = laHabitacionEnBaseDeDatos.FechaDeModificacion,
                                                           Estado = laHabitacionEnBaseDeDatos.Estado
                                                       }).FirstOrDefault();
            return habitacion;

        }
    }
}
