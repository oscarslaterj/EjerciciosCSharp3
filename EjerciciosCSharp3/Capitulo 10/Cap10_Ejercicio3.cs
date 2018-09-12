using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp3.Capitulo_10
{
    public class Cap10_Ejercicio3
    {
        public class Poligono
        {
            public int NumeroLados { get; set; }
            public int NumeroVertices { get; set; }

            public Poligono()
            {

            }

            public Poligono(int numeroLados, int numeroVertices)
            {
                NumeroLados = numeroLados;
                NumeroVertices = numeroVertices;
            }
        }
    }
}
