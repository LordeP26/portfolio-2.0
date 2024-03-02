using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisores_com_resto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, resto;
            Console.WriteLine("digite um numero: ");
            n = Convert.ToDouble(Console.ReadLine());
            resto = n % 2;
            if (resto == 2)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }
            Console.ReadKey();
        }
    }
}
