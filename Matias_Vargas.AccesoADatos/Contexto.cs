using Matias_Vargas.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matias_Vargas.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto() { }

        public DbSet<HabitacionesEntidad> HabitacionesEntidad { get; set; }
        public DbSet<ReservacionesEntidad> ReservacionesEntidad { get; set; }
    }
}
