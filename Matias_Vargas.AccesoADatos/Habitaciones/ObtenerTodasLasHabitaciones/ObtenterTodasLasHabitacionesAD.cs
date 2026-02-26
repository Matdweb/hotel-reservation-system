using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.ObtenterTodasLasHabitaciones;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Habitaciones.ObtenerTodasLasHabitaciones
{
    public class ObtenterTodasLasHabitacionesAD : IObtenerTodasLasHabitacionesAD
    {
        Contexto _elContexto;

        public ObtenterTodasLasHabitacionesAD()
        {
            _elContexto = new Contexto();
        }

        public List<HabitacionesDto> Obtener()
        {
            List<HabitacionesDto> listaHabitaciones = (from laListaDeHabitacionesEnBaseDeDatos in _elContexto.HabitacionesEntidad
                                                       select new HabitacionesDto
                                                       {
                                                              Id = laListaDeHabitacionesEnBaseDeDatos.Id,
                                                              CodigoDeHabitacion = laListaDeHabitacionesEnBaseDeDatos.CodigoDeHabitacion,
                                                              NombreDeHabitacion = laListaDeHabitacionesEnBaseDeDatos.NombreDeHabitacion,
                                                              CantidadDeHuespedesPermitidos = laListaDeHabitacionesEnBaseDeDatos.CantidadDeHuespedesPermitidos,
                                                              CantidadDeCamas = laListaDeHabitacionesEnBaseDeDatos.CantidadDeCamas,
                                                              CantidadDeBanos = laListaDeHabitacionesEnBaseDeDatos.CantidadDeBanos,
                                                              Ubicacion = laListaDeHabitacionesEnBaseDeDatos.Ubicacion,
                                                              EncargadoDeLimpieza = laListaDeHabitacionesEnBaseDeDatos.EncargadoDeLimpieza,
                                                              TipoDeHabitacion = laListaDeHabitacionesEnBaseDeDatos.TipoDeHabitacion,
                                                              CostoDeLimpieza = laListaDeHabitacionesEnBaseDeDatos.CostoDeLimpieza,
                                                              CostoDeReserva = laListaDeHabitacionesEnBaseDeDatos.CostoDeReserva,
                                                              FechaDeRegistro = laListaDeHabitacionesEnBaseDeDatos.FechaDeRegistro,
                                                              FechaDeModificacion = laListaDeHabitacionesEnBaseDeDatos.FechaDeModificacion,
                                                              Estado = laListaDeHabitacionesEnBaseDeDatos.Estado
                                                         }).ToList();
            return listaHabitaciones;
        }
    }
}
