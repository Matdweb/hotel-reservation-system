using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.Modelos.Habitaciones
{
    public class HabitacionesDto
    {
        public int Id { get; set; }

        [Display(Name = "Código de la Habitación")]
        [Required]
        [MaxLength(7)]
        public string CodigoDeHabitacion { get; set; }

        [Display(Name = "Nombre de la Habitación")]
        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        public string NombreDeHabitacion { get; set; }

        [Display(Name = "Cantidad de Huéspedes Permitidos")]
        [Required]
        public int CantidadDeHuespedesPermitidos { get; set; }

        [Display(Name = "Cantidad de Camas")]
        [Required]
        public int CantidadDeCamas { get; set; }

        [Display(Name = "Cantidad de Baños")]
        [Required]
        public int CantidadDeBanos { get; set; }

        [Display(Name = "Ubicación")]
        [Required]
        [MaxLength(10)]
        public string Ubicacion { get; set; }

        [Display(Name = "Encargado de Limpieza")]
        [Required]
        [MaxLength(100)]
        public string EncargadoDeLimpieza { get; set; }

        [Display(Name = "Tipo de Habitación")]
        [Required]
        public int TipoDeHabitacion { get; set; } // Junior, Superior, Suite

        [Display(Name = "Costo de Limpieza")]
        [Required]
        public decimal CostoDeLimpieza { get; set; }

        [Display(Name = "Costo de Reserva")]
        [Required]
        public decimal CostoDeReserva { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaDeRegistro { get; set; }

        [Display(Name = "Fecha de Modificacion")]
        public DateTime? FechaDeModificacion { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}
