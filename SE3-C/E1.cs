using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class E1
    {
        static void Main(string[] args)
        {
            string n, c;
            Console.WriteLine("Ingrese Nombre:");
            n=Console.ReadLine();
            Console.WriteLine("Ingrese carrera:");
            c = Console.ReadLine();

            Console.WriteLine($"{n}, Bienvenido al curso de Fundamentos de Algoritmos de la carrera {c}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
