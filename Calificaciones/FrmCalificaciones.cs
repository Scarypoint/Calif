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
    public partial class FrmCalificaciones : Form
    {
        public FrmCalificaciones()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbalumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbalumno_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void CargarAlumnosEnComboBox()
        {
            DataTable tablita2 = Central.CargarAlumnos();  // Llama al método para obtener los alumnos desde Central

            cmbalumno.Items.Clear();  // Limpia los elementos anteriores

            // Llena el ComboBox con los nombres de los alumnos
            foreach (DataRow row in tablita2.Rows)
            {
                cmbalumno.Items.Add(row["Nombre"].ToString());  // Agrega solo el nombre como string
            }

            // Opcional: Mostrar el primer alumno por defecto
            if (cmbalumno.Items.Count > 0)
            {
                cmbalumno.SelectedIndex = 0;
            }
        }

        private void FrmCalificaciones_Load_1(object sender, EventArgs e)
        {
            // Código que se ejecutará cuando el formulario se cargue
            CargarAlumnosEnComboBox();  // Ejemplo
            CargarMateriasEnComboBox();  // Cargar materias
        }
        private void CargarMateriasEnComboBox()
        {
            DataTable Materias = Central.CargarMaterias();  // Llama al método para obtener las materias desde Central

            cmbmateria.Items.Clear();  // Limpia los elementos anteriores del ComboBox

            // Llena el ComboBox con los nombres de las materias
            foreach (DataRow row in Materias.Rows)
            {
                cmbmateria.Items.Add(row["Nombre"].ToString());  // Agrega solo el nombre como string
            }

            // Opcional: Mostrar la primera materia por defecto
            if (cmbmateria.Items.Count > 0)
            {
                cmbmateria.SelectedIndex = 0;
            }

        }

        private void AsignarC(object sender, EventArgs e)
        {
            // Suponiendo que tienes ComboBox para el nombre del alumno y la materia, y un TextBox para la calificación
            string nombre = cmbalumno.Text; // El nombre del alumno seleccionado
            string materia = cmbmateria.SelectedItem?.ToString(); // Materia seleccionada
            string calificacion = tbcalif.Text; // Calificación ingresada

            // Verifica que los campos no estén vacíos
            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(materia) && !string.IsNullOrWhiteSpace(calificacion))
            {
                // Agrega los datos a la tabla del DataGridView
                dgvcalificaciones.Rows.Add(nombre, materia, calificacion);

                // Opcional: Limpiar los campos después de guardar
                cmbalumno.SelectedIndex = -1; // Deseleccionar el alumno
                cmbmateria.SelectedIndex = -1; // Deseleccionar la materia
                tbcalif.Clear(); // Limpiar el campo de calificación
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }