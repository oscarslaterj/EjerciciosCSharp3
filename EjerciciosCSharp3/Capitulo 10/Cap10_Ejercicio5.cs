using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp3.Capitulo_10
{
    public class Cap10_Ejercicio5
    {
        public class Poligono3
        {
            public int NumeroLados { get; set; }
            public int NumeroVertices { get; set; }

            public Poligono3()
            {

            }

            public Poligono3(int numeroLados, int numeroVertices)
            {
                NumeroLados = numeroLados;
                NumeroVertices = numeroVertices;
            }

            public override string ToString()
            {
                return "Numero Lados: " + NumeroLados + " , Numero Vertices: " + NumeroVertices;
            }
        }
    }
}
