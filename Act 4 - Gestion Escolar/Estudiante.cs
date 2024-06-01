using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_4___Gestion_Escolar
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Grado { get; set; }
        public List<double> Notas { get; set; }
        public List<bool> Asistencias { get; set; }

        public Estudiante(string nombre, int grado)
        {
            Nombre = nombre;
            Grado = grado;
            Notas = new List<double>();
            Asistencias = new List<bool>();
        }
    }
}
