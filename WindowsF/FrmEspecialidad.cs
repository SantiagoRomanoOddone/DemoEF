using Datos.Admin;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsF
{
    public partial class FrmEspecialidad : Form
    {
        public FrmEspecialidad()
        {
            InitializeComponent();
        }

        private void FrmEspecialidad_Load(object sender, EventArgs e)
        {
            TraerEspecialidades();
            llenarComboTraerEspecialidad();
        }
        private void TraerEspecialidades()
        {
            gridEspecialidades.DataSource = AdmEspecialidad.Listar();
        }
        private void llenarComboTraerEspecialidad()
        {
            List<Especialidad> especialidades = AdmEspecialidad.Listar();
            especialidades.Insert(0, new Especialidad()
            {
                EspecialidadId = 0,
                Nombre = "[TODAS]"
            });
            cbBuscarEspecialidad.DataSource = especialidades;
            cbBuscarEspecialidad.DisplayMember = "Nombre";
            cbBuscarEspecialidad.ValueMember = "EspecialidadId";

        }

        private void cbBuscarEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int especialidadId = Convert.ToInt32(cbBuscarEspecialidad.SelectedValue);
            if (especialidadId == 0)
            {
                TraerEspecialidades();
            }
            else
            {
                gridEspecialidades.DataSource = AdmEspecialidad.TraerPorId(especialidadId);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                Nombre = txtNombre.Text

            };
            int filasAfectadas = AdmEspecialidad.Insertar(especialidad);
            if (filasAfectadas > 0)
            {
                TraerEspecialidades();
                llenarComboTraerEspecialidad();
            }
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                EspecialidadId = Convert.ToInt32(txtEspecialidadId.Text),
                Nombre = txtNombre.Text

            };
            int filasAfectadas = AdmEspecialidad.Modificar(especialidad);
            if (filasAfectadas > 0)
            {
                TraerEspecialidades();
                llenarComboTraerEspecialidad();
            }


        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            int EspecialidadId = Convert.ToInt32(txtEspecialidadId.Text);
            int filasAfectadas = AdmEspecialidad.Eliminar(EspecialidadId);
            if (filasAfectadas > 0)
            {
                TraerEspecialidades();
                llenarComboTraerEspecialidad();

            }

        }
    }
}
