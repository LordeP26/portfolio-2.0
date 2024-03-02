using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos_de_3_e_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, n1, n2;
            Console.WriteLine("digite o seu numero: ");
            n = Convert.ToDouble(Console.ReadLine());
            n1 = n % 3;
            n2 = n % 7;
            if ((n1 == 0) && (n2 == 0))
            {
                Console.WriteLine("multiplo de 3 e 7");
            }
            else
            {
                Console.WriteLine("não é multiplo");
            }
        }
    }
}
