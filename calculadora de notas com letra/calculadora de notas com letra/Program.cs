using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_notas_com_letra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, p4, m, exame, final;
            Console.WriteLine("digite sua p1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite sua p2: ");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite sua p3: ");
            p3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite sua p4: ");
            p4 = Convert.ToDouble(Console.ReadLine());
            m = ((p1 * 0.3) + (p2 * 0.3) + (p3 * 0.3) + (p4 * 0.1));
            Console.WriteLine("digite sua media: " + m);

            if (m >= 9.0)
            {
                Console.WriteLine("sua média é A, parabéns!!");
            }
            else if ((m >= 7.5) && (m < 9.0))
            {
                Console.WriteLine("sua média é b, parabéns!!");
            }
            else if ((m >= 6.0) && (m < 7.5))
            {
                Console.WriteLine("sua média é c");
            }
            else
            {
                Console.WriteLine("sua média é D");
                Console.WriteLine("o aluno nao atingiu a nota necessaria e esta de exame");
                Console.WriteLine("insira a nota do exame: ");
                exame = Convert.ToDouble(Console.ReadLine());
                final = ((m * 0.6) + (exame * 0.4));
                if (final >= 6)
                {
                    Console.WriteLine("aprovado");
                }
                else
                {
                    Console.WriteLine("reprovado");
                }
            }
        }
    }
}
