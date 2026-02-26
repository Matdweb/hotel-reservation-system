using Matias_Vargas.Abstracciones.AccesoADatos.Habitaciones.AgregarHabitacion;
using Matias_Vargas.Abstracciones.Modelos.Habitaciones;
using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Habitaciones.AgregarHabitacion
{
    public class AgregarHabitacionAD : IAgregarHabitacionAD
    {
        Contexto _elContexto;

        public AgregarHabitacionAD()
        {
            _elContexto = new Contexto();
        }

        public int Agregar(HabitacionesDto laHabitacion)
        {
            HabitacionesEntidad laHabitacionAgregar = ConvertirObjetoAEntidad(laHabitacion);

            _elContexto.HabitacionesEntidad.Add(laHabitacionAgregar);
            int cantidadDeHabitacionesAgregadas = _elContexto.SaveChanges();
            return cantidadDeHabitacionesAgregadas;
        }

        private HabitacionesEntidad ConvertirObjetoAEntidad(HabitacionesDto laHabitacionAgregar)
        {
            return new HabitacionesEntidad
            {
                CodigoDeHabitacion = laHabitacionAgregar.CodigoDeHabitacion,
                NombreDeHabitacion = laHabitacionAgregar.NombreDeHabitacion,
                CantidadDeHuespedesPermitidos = laHabitacionAgregar.CantidadDeHuespedesPermitidos,
                CantidadDeCamas = laHabitacionAgregar.CantidadDeCamas,
                CantidadDeBanos = laHabitacionAgregar.CantidadDeBanos,
                Ubicacion = laHabitacionAgregar.Ubicacion,
                EncargadoDeLimpieza = laHabitacionAgregar.EncargadoDeLimpieza,
                TipoDeHabitacion = laHabitacionAgregar.TipoDeHabitacion,
                CostoDeLimpieza = laHabitacionAgregar.CostoDeLimpieza,
                CostoDeReserva = laHabitacionAgregar.CostoDeReserva,
                FechaDeRegistro = laHabitacionAgregar.FechaDeRegistro,
                Estado = laHabitacionAgregar.Estado
            };
        }
    }
}
