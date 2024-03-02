using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_circulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, d, p, r, num1, π;
            Console.WriteLine("Digite o raio: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            r = Math.Pow(num1, 2);
            π = Math.PI;
            a = π * r;
            Console.WriteLine("a area:" + a);
            d = 2 * num1;
            Console.WriteLine("o diametro:" + d);
            p = 2 * π * num1;
            Console.WriteLine("o perimetro:" + p);
            Console.ReadKey();
        }
    }
}
