using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double V1, V2, V3;

            Console.WriteLine("V1= ");
            V1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("V2= ");
            V2 = Convert.ToDouble(Console.ReadLine());
            V3 = V1 + V2;
            Console.WriteLine("Suma= " + V3);
            V3 = V1 - V2;
            Console.WriteLine("Resta= " + V3);
            V3 = V1 * V2;
            Console.WriteLine("Multiplicacion= " + V3);
            V3 = V1 / V2;
            Console.WriteLine("Division= " + V3);

            Console.ReadKey();
        }
    }
}

