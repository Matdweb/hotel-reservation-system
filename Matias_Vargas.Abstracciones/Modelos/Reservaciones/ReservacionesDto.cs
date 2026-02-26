using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.Abstracciones.Modelos.Reservaciones
{
    public class ReservacionesDto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de la Persona")]
        [Required]
        [MaxLength(150)]
        public string NombreDeLaPersona { get; set; }

        [Display(Name = "Identificación")]
        [Required]
        [MaxLength(30)]
        public string Identificacion { get; set; }

        [Display(Name = "Teléfono")]
        [Required]
        [MaxLength(10)]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        [Required]
        [MaxLength(50)]
        public string Correo { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Dirección")]
        [Required]
        [MaxLength(200)]
        public string Direccion { get; set; }

        [Display(Name = "Monto Total")]
        [Required]
        public decimal MontoTotal { get; set; }

        [Display(Name = "Fecha de Inicio de Reserva")]
        [Required]
        public DateTime FechaInicioReserva { get; set; }

        [Display(Name = "Fecha de Fin de Reserva")]
        [Required]
        public DateTime FechaFinReserva { get; set; }

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaDeRegistro { get; set; }

        [Display(Name = "Id de Habitación")]
        [Required]
        public int IdHabitacion { get; set; }
    }
}
