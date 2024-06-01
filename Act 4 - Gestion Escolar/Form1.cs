using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Act_4___Gestion_Escolar
{
    public partial class Form1 : Form
    {
        private Escuela escuela;

        public Form1()
        {
            InitializeComponent();
            escuela = new Escuela();
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEstudiante.Text;
            int grado = (int)nudGrado.Value;

            if (!string.IsNullOrEmpty(nombre))
            {
                Estudiante nuevoEstudiante = new Estudiante(nombre, grado);
                escuela.AgregarEstudiante(nuevoEstudiante);
                ActualizarListaEstudiantes();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre de estudiante válido.");
            }
        }

        private void btnRegistrarNotas_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = lstEstudiantes.SelectedItem?.ToString();
            double nota = (double)nudNota.Value;

            if (!string.IsNullOrEmpty(nombreEstudiante))
            {
                escuela.AgregarNota(nombreEstudiante, nota);
                ActualizarListaEstudiantes();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un estudiante.");
            }
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = lstEstudiantes.SelectedItem?.ToString();
            bool asistencia = chkAsistencia.Checked;

            if (!string.IsNullOrEmpty(nombreEstudiante))
            {
                escuela.RegistrarAsistencia(nombreEstudiante, asistencia);
                ActualizarListaEstudiantes();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un estudiante.");
            }
        }

        private void ActualizarListaEstudiantes()
        {
            lstEstudiantes.Items.Clear();
            foreach (Estudiante estudiante in escuela.Estudiantes)
            {
                lstEstudiantes.Items.Add(estudiante.Nombre);
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Limpiar el DataGridView antes de agregar nuevos datos
            dataGridViewReporte.Rows.Clear();
            dataGridViewReporte.Columns.Clear();

            // Agregar las columnas al DataGridView
            dataGridViewReporte.Columns.Add("Nombre", "Nombre");
            dataGridViewReporte.Columns.Add("Grado", "Grado");
            dataGridViewReporte.Columns.Add("PromedioNotas", "Promedio de Notas");
            dataGridViewReporte.Columns.Add("Asistencias", "Asistencias");

            // Recorrer la lista de estudiantes y agregar los datos al DataGridView
            foreach (Estudiante estudiante in escuela.Estudiantes)
            {
                double promedioNotas = estudiante.Notas.Any() ? estudiante.Notas.Average() : 0;
                int asistencias = estudiante.Asistencias.Count(asistencia => asistencia);

                dataGridViewReporte.Rows.Add(estudiante.Nombre, estudiante.Grado, promedioNotas, asistencias);
            }

            // Generar el gráfico
            GenerarGrafico();
        }

        private void GenerarGrafico()
        {
            chartReporte.Series.Clear();
            chartReporte.ChartAreas.Clear();

            var chartArea = new ChartArea("MainArea");
            chartReporte.ChartAreas.Add(chartArea);

            var serieNotas = new Series("Promedio de Notas")
            {
                ChartType = SeriesChartType.Column
            };

            var serieAsistencias = new Series("Asistencias")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (Estudiante estudiante in escuela.Estudiantes)
            {
                double promedioNotas = estudiante.Notas.Any() ? estudiante.Notas.Average() : 0;
                int asistencias = estudiante.Asistencias.Count(asistencia => asistencia);

                serieNotas.Points.AddXY(estudiante.Nombre, promedioNotas);
                serieAsistencias.Points.AddXY(estudiante.Nombre, asistencias);
            }

            chartReporte.Series.Add(serieNotas);
            chartReporte.Series.Add(serieAsistencias);
        }
    }
}
