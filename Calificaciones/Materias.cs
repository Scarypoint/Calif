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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            gvmaterias.DataSource = Central.CargarMaterias();
        }  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarMateria(object sender, EventArgs e)
        {
            RegistrarMateria reg = new RegistrarMateria();
            reg.Show();
        }
    }
}
