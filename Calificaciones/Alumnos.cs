using Calificaciones.Calificaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calificaciones
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AgregarAlumno(object sender, EventArgs e)
        {
            RegistrarAlumno reg = new RegistrarAlumno();
            reg.Show();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            gvalumnos.DataSource = Central.CargarAlumnos();
        }

        private void gvalumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}