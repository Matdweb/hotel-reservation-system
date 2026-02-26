using Matias_Vargas.Abstracciones.AccesoADatos.Reservaciones.ObtenerReservaPorId;
using Matias_Vargas.Abstracciones.Modelos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Reservaciones.ObtenerReservaPorId
{
    public class ObtenerReservaPorIdAD : IObtenerReservaPorIdAD
    {
        Contexto _elContexto;

        public ObtenerReservaPorIdAD()
        {
            _elContexto = new Contexto();
        }

        public ReservacionesconHabitacionDto ObtenerPorId(int id)
        {
            var laReserva = (from laReservaEnBaseDeDatos in _elContexto.ReservacionesEntidad
                             join h in _elContexto.HabitacionesEntidad
                             on laReservaEnBaseDeDatos.IdHabitacion equals h.Id
                             where laReservaEnBaseDeDatos.Id == id
                             select new ReservacionesconHabitacionDto
                             {
                                 Id = laReservaEnBaseDeDatos.Id,
                                 NombreDeLaPersona = laReservaEnBaseDeDatos.NombreDeLaPersona,
                                 Identificacion = laReservaEnBaseDeDatos.Identificacion,
                                              Telefono = laReservaEnBaseDeDatos.Telefono,
                                              Correo = laReservaEnBaseDeDatos.Correo,
                                              FechaNacimiento = laReservaEnBaseDeDatos.FechaNacimiento,
                                              Direccion = laReservaEnBaseDeDatos.Direccion,
                                              CodigoDeHabitacion = h.CodigoDeHabitacion,
                                              TipoDeHabitacion = h.TipoDeHabitacion,
                                              CantidadDeHuespedesPermitidos = h.CantidadDeHuespedesPermitidos,
                                              MontoTotal = laReservaEnBaseDeDatos.MontoTotal,
                                              FechaInicioReserva = laReservaEnBaseDeDatos.FechaInicioReserva,
                                              FechaFinReserva = laReservaEnBaseDeDatos.FechaFinReserva,
                                              FechaDeRegistro = laReservaEnBaseDeDatos.FechaDeRegistro,
                                          }).FirstOrDefault();
            return laReserva;
        }
    }
}
