using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp3.Capitulo_9
{
    public class Cap9_Ejercicio4
    {
        public enum Neumaticos { Para_Coche, Para_Furgoneta, Para_4X4 };
        public void TipoNeumatico()
        {

            Console.Clear();
            Console.WriteLine("Tipos de Neumaticos: \n\n");
            Console.WriteLine(Neumaticos.Para_4X4.ToString());
            Console.WriteLine(Neumaticos.Para_Coche.ToString());
            Console.WriteLine(Neumaticos.Para_Furgoneta.ToString());

            Console.ReadKey();
        }
    }
}
