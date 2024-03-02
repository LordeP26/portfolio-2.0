using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_média
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            double p1, p2, p3, m;
            Console.WriteLine("entrar com P1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("entrar com P2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("entrar com P3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            m = ((p1 * 0.4) + (p2 * 0.4) + (p3 * 0.2));
            Console.WriteLine("média:" + m);
            if (m >= 7)
            {//if1
                Console.WriteLine("aprovado!!");
            }//if1
            else
            {//else1
                Console.WriteLine("reprovado!!");
            }//else1
            Console.ReadKey();
        }//fim
    }
}
