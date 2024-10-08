using Calificaciones.Calificaciones;
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
    public partial class RegistrarAlumno : Form
    {
        public RegistrarAlumno()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Registar(object sender, EventArgs e)
        {
            //forma 1
            Alumno alumno = new Alumno();
            alumno.Nombre = txtnombre.Text;
            alumno.Apellidos = txtapellidos.Text;
            alumno.Matricula = txtmatricula.Text;

            //forma 2
            Alumno alumno2 = new Alumno()
            {
                Nombre = txtnombre.Text,
                Apellidos = txtapellidos.Text,
                Matricula = txtmatricula.Text
            };

            Central.RegistrarAlumno(alumno);
        }
    }
}
