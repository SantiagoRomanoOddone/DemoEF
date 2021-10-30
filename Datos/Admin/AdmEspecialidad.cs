using Datos.Models;
using Datos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmEspecialidad
    {
        static DbClinicaContext context = new DbClinicaContext();
        public static List<Especialidad> Listar()
        {

            return context.Especialidades.ToList(); // con esto retornamos todos
        }
    }
}
