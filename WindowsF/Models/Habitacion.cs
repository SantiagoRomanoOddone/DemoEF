using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsF.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        [Key]
        public int IdHabitacion { get; set; }
        public int Numero { get; set; }

        [Column(TypeName = "varchar")] // tipo de dato de SQL Server
        [MaxLength(12)]
        public string Estado { get; set; }

        public int ClinicaId { get; set; }

        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }


    }
}
