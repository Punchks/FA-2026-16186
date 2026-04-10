using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class E3
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Ingrese primer número entero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo número entero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma: {num1 + num2}");
            Console.WriteLine($"Resta: {num1 - num2}");
            Console.WriteLine($"Multiplicación: {num1 * num2}");

            if (num2 != 0)
                Console.WriteLine($"División: {(double)num1 / num2}");
            else
                Console.WriteLine("División: No se puede dividir entre cero");
            Console.WriteLine();
        }
    }
}
