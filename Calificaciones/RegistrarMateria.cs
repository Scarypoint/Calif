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
    public partial class RegistrarMateria : Form
    {
        public RegistrarMateria()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistarMateria(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtcodigo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear instancia de materia para pasarla al método de registrar materia
            Materia materia = new Materia()
            {
                Nombre = txtnombre.Text,
                Codigo = txtcodigo.Text
            };

            // Llamar al método para registrar la materia
            Central.RegistrarMateria(materia);

            // Limpiar campos después de registrar
            txtnombre.Text = "";
            txtcodigo.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Este evento está vacío, puedes eliminarlo si no lo necesitas.
        }
    }
}
