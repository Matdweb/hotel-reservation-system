using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerTodasLasReservas;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Reservaciones.ObtenerTodasLasReservas
{
    public class ObtenerTodasLasReservasAD : IObtenerTodasLasReservasAD
    {
        Contexto _elContexto;

        public ObtenerTodasLasReservasAD()
        {
            _elContexto = new Contexto();
        }

        public List<ReservacionesconHabitacionDto> Obtener()
        {
            var listaReservas = (from laReservaEnBaseDeDatos in _elContexto.ReservacionesEntidad
                                 join laHabitacion in _elContexto.HabitacionesEntidad
                                 on laReservaEnBaseDeDatos.IdHabitacion equals laHabitacion.Id
                                 select new ReservacionesconHabitacionDto
                                 {
                                     Id = laReservaEnBaseDeDatos.Id,
                                     NombreDeLaPersona = laReservaEnBaseDeDatos.NombreDeLaPersona,
                                     Identificacion = laReservaEnBaseDeDatos.Identificacion,
                                     Telefono = laReservaEnBaseDeDatos.Telefono,
                                     Correo = laReservaEnBaseDeDatos.Correo,
                                     FechaNacimiento = laReservaEnBaseDeDatos.FechaNacimiento,
                                     Direccion = laReservaEnBaseDeDatos.Direccion,
                                     MontoTotal = laReservaEnBaseDeDatos.MontoTotal,
                                     FechaInicioReserva = laReservaEnBaseDeDatos.FechaInicioReserva,
                                     FechaFinReserva = laReservaEnBaseDeDatos.FechaFinReserva,
                                     FechaDeRegistro = laReservaEnBaseDeDatos.FechaDeRegistro,
                                     IdHabitacion = laReservaEnBaseDeDatos.IdHabitacion,
                                     NombreDeHabitacion = laHabitacion.NombreDeHabitacion,
                                     CodigoDeHabitacion = laHabitacion.CodigoDeHabitacion,
                                     TipoDeHabitacion = laHabitacion.TipoDeHabitacion,
                                     CantidadDeHuespedesPermitidos = laHabitacion.CantidadDeHuespedesPermitidos,
                                 }).ToList();
            return listaReservas;
        }
    }
}
