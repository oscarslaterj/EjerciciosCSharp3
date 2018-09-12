using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp3.Capitulo_10
{
    public class Cap10_Ejercicio4
    {
        public class Poligono2
        {
            public int NumeroLados
            {
                get
                {
                    return NumeroLados;
                }
                set
                {
                    if (NumeroLados > 0)
                        NumeroLados = value;
                }
            }
            public int NumeroVertices
            {
                get
                {
                    return NumeroLados;
                }
                set
                {
                    if (NumeroLados > 0)
                        NumeroLados = value;
                }
            }

            public Poligono2()
            {

            }

            public Poligono2(int numeroLados, int numeroVertices)
            {
                NumeroLados = numeroLados;
                NumeroVertices = numeroVertices;
            }

        }
    }
}
