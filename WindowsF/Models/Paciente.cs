using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsF.Models
{
    [Table("Paciente")]// EF cuando crea la tabla la llama paciente en singular sino por convensión pluraliza el nombre
    public class Paciente
    {        
        public int Id { get; set; }

        [Required] //Establecer NOT NULL en una columna de tipo cadena
        [Column(TypeName ="varchar")] // tipo de dato de SQL Server
        [MaxLength(50)]//hasta 50 caracteres
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")] 
        [MaxLength(50)]
        public string Apellido { get; set; }
        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }
        public int NroHistoriaClinica { get; set; }

        public int MedicoId { get; set; } // FK clave externa

        // Propiedad de nagevación 
        [ForeignKey("MedicoId")]
        // vamos a hacer la navegación de uno a muchos
        public Medico Medico { get; set; }
    }
}
