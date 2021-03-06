using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsF.Models
{
    [Table("Medico")]
    public class Medico
    {

        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        public  int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
        

        [ForeignKey("EspecialidadId")]
        //asi transformo a propiedad de navegación
        public List<Paciente> Pacientes { get; set; }
       
        
    }
}
