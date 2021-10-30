using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Models;
using Datos.Admin;

namespace WindowsF
{
    public partial class FrmPaciente : Form
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {
            TraerPacientes();
        }
        private void TraerPacientes()
        {
            gridPacientes.DataSource = AdmPaciente.Listar();
        }
       

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente() { Nombre = "Juan", Apellido = "Sosa", FechaNacimiento = new DateTime(2000, 12, 05), NroHistoriaClinica = 1111, MedicoId = 1 };

            int filasAfectadas = AdmPaciente.Insertar(paciente);
            if (filasAfectadas > 0)
            {
                TraerPacientes();
            }
        }
    }
}
