using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //EF
using WindowsF.Models; // ver los modelos

namespace WindowsF.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbClinicaContext() : base("KeyDbClinica") { }

        // propiedades DbSet<m>
        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }


    }
}
