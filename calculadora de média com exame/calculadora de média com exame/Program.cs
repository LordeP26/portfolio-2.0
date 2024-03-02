using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_média_com_exame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, m;
            Console.Write("digite sua p1:");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite sua p2:");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("digite sua previa:");
            p3 = Convert.ToDouble(Console.ReadLine());
            m = (p1 * 0.4) + (p2 * 0.4) + (p3 * 0.2);
            Console.WriteLine("sua média é: " + m);
            if (m >= 7)
            {//if inicio 
                Console.WriteLine("Você foi aprovado!!");
            }//if final
            else
            {//else inicio 
                Console.WriteLine("Você esta de exame");
                Console.ReadKey();
            }
            }
    }
}
