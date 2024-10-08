using Calificaciones.Entidades;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VerAlumnos(object sender, EventArgs e)
        {
            Alumnos _alumnos = new Alumnos();
            _alumnos.Show();
        }
        private void VerMaterias(object sender, EventArgs e)
        {
            Materias _materias = new Materias();
            _materias.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void VerCalificiones(object sender, EventArgs e)
        {
            FrmCalificaciones _calif = new FrmCalificaciones();
            _calif.Show();
        }

    }
}

