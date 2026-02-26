using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos.Entidades
{
    [Table("HABITACIONES")]
    public class HabitacionesEntidad
    {
        [Column("Id")]

        public int Id { get; set; }

        [Column("CodigoDeHabitacion")]
        public string CodigoDeHabitacion { get; set; }

        [Column("NombreDeHabitacion")]

        public string NombreDeHabitacion { get; set; }

        [Column("CantidadDeHuespedesPermitidos")]

        public int CantidadDeHuespedesPermitidos { get; set; }

        [Column("CantidadDeCamas")]

        public int CantidadDeCamas { get; set; }

        [Column("CantidadDeBanos")]

        public int CantidadDeBanos { get; set; }

        [Column("Ubicacion")]

        public string Ubicacion { get; set; }

        [Column("EncargadoDeLimpieza")]

        public string EncargadoDeLimpieza { get; set; }

        [Column("TipoDeHabitacion")]

        public int TipoDeHabitacion { get; set; } // Junior, Superior, Suite

        [Column("CostoDeLimpieza")]

        public decimal CostoDeLimpieza { get; set; }

        [Column("CostoDeReserva")]

        public decimal CostoDeReserva { get; set; }

        [Column("FechaDeRegistro")]

        public DateTime FechaDeRegistro { get; set; }

        [Column("FechaDeModificacion")]

        public DateTime? FechaDeModificacion { get; set; }

        [Column("Estado")]
        public bool Estado { get; set; }
    }
}
