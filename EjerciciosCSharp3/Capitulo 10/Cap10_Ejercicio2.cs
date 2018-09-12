using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp3.Capitulo_10
{
    public class Cap10_Ejercicio2
    {
        public class Estudiante
        {
            public int NumeroOrden { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public List<int> NotasMensuales { get; set; }

            public Estudiante()
            {

            }

            public Estudiante(int numeroOrden, string nombres, string apellidos, DateTime fechaNacimiento)
            {
                NumeroOrden = numeroOrden;
                Nombres = nombres;
                Apellidos = apellidos;
                FechaNacimiento = fechaNacimiento;
                NotasMensuales = new List<int>();
            }

        }
    }
}
