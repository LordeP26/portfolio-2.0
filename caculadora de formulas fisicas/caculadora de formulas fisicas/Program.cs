using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculadora_de_formulas_fisicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine(" calculo ");
            Console.WriteLine(" escolha sua formula ");
            Console.WriteLine(" 1 - baskara ");
            Console.WriteLine(" 2 - força ");
            Console.WriteLine(" 3 - velocidade ");
            Console.WriteLine(" digite sua opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    double a, b, c, x1, x2, del, del2;
                    Console.WriteLine("a escolha foi baskara");
                    Console.WriteLine("digite a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite c: ");
                    c = Convert.ToDouble(Console.ReadLine());
                    del = (b * b) - (4 * a * c);
                    del2 = Math.Sqrt(del);
                    x1 = (-b + del2) / 2*a;
                    x2 = (-b - del2) / 2*a;
                    Console.WriteLine("seu x1 foi: " + x1);
                    Console.WriteLine("seu x2 foi: " + x2);
                    break;

                case 2:
                    double f, m, ac;
                    Console.WriteLine("a escolha foi força");
                    Console.WriteLine("digite a massa: ");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite a aceleração: ");
                    ac = Convert.ToDouble(Console.ReadLine());
                    f = m * ac;
                    Console.WriteLine("sua força é: " + f + "N");
                    break;

                case 3:
                    double v, vo, t, ac2;
                    Console.WriteLine("a escolha foi velocidade");
                    Console.WriteLine("digite a velocidade inicial");
                    vo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o tempo: ");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite a aceleração: ");
                    ac2 = Convert.ToDouble(Console.ReadLine());
                    v = vo + (ac2 * t);
                    Console.WriteLine("sua velocidade é: " + v + "m/s");
                    break;
            }
            Console.ReadKey();
        }
    }
}
