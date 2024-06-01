using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_4___Gestion_Escolar
{
    public class Escuela
    {
        public List<Estudiante> Estudiantes { get; set; }

        public Escuela()
        {
            Estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public void AgregarNota(string nombreEstudiante, double nota)
        {
            Estudiante estudiante = Estudiantes.FirstOrDefault(e => e.Nombre == nombreEstudiante);
            if (estudiante != null)
            {
                estudiante.Notas.Add(nota);
            }
        }

        public void RegistrarAsistencia(string nombreEstudiante, bool asistencia)
        {
            Estudiante estudiante = Estudiantes.FirstOrDefault(e => e.Nombre == nombreEstudiante);
            if (estudiante != null)
            {
                estudiante.Asistencias.Add(asistencia);
            }
        }
    }
}
