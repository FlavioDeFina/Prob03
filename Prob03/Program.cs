using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float suma = 0f;
            float promedio = 0f;
            float total = 0f;
            Console.WriteLine("Año\tPoblación");
            for (int t = 20; t <= 50; t++)
            {
                float poblacion = 6.0f * (float)Math.Exp(0.02 * (t));
                Console.WriteLine($"20{t}\t{poblacion}");
                suma = suma + poblacion;
                if ( t >= 31 && t <= 40 ) 
                {
                    promedio = promedio + poblacion; 
                }
            }
            total = promedio / 9;
            Console.WriteLine("La Suma de la poblacion total entre los años 2020 y 2050 es: "+suma);
            Console.WriteLine("El promedio entre los años 2031 y 2040 es: "+total);
            Console.ReadKey();
        }
    }
}
