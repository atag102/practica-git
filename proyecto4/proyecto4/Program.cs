using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int A,B,C;
                Console.WriteLine("Numero A ?= ");
                A = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Numero B ?= ");
                B = Convert.ToInt16(Console.ReadLine());

                C = A + B;

                Console.WriteLine("Reultado= " + C);
            }
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadLine();
        }
    }
}
