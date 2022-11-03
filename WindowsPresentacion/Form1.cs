using libIntegrador.Models;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarMedicosGrid_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = new List<Medico>();

            medicos = AdmMedico.Listar();

            gridMedicos.DataSource = medicos;
        }

        private void btnListarPacientesGrid_Click(object sender, EventArgs e)
        {
            List<Paciente> pacientes = new List<Paciente>();

            pacientes = AdmPaciente.Listar();

            gridPacientes.DataSource = pacientes;
        }

        private void btnListarMedicosClinicos_Click(object sender, EventArgs e)
        {
            List<Medico> medicos = new List<Medico>();

            medicos = AdmMedico.Listar();

            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad.ToLower() == "clinico")
                {
                    lstMedicos.Items.Add(medico.Apellido + ", " +medico.Nombre);
                }
            }
        }

        private void btnListarHabitaciones_Click(object sender, EventArgs e)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();

            habitaciones = AdmHabitacion.Listar();

            foreach (Habitacion habitacion in habitaciones)
            {
                lstHabitaciones.Items.Add("Habitacion Nro: " + habitacion.Numero + " - " + habitacion.Estado);
            }
        }
    }
}
