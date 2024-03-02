using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_nota_com_tratamento_de_erros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, m, contador = 0;
        INICIOp1:
            Console.Write("digite sua p1:");
            p1 = Convert.ToDouble(Console.ReadLine());
            if (p1 >= 0 && p1 <= 10)
            {//if p1
            INICIOp2:
                Console.Write("digite sua p2:");
                p2 = Convert.ToDouble(Console.ReadLine());
                if (p2 >= 0 && p2 <= 10)
                {
                INICIOp3:
                    Console.Write("digite sua previa:");
                    p3 = Convert.ToDouble(Console.ReadLine());
                    if (p3 >= 0 && p3 <= 10)
                    {
                        m = (p1 * 0.4) + (p2 * 0.4) + (p3 * 0.2);
                        Console.WriteLine("sua média é: " + m);

                    }
                    else
                    {
                        Console.WriteLine("Digite novamente...");
                        goto INICIOp3;
                    }

                }
                else
                {
                    Console.WriteLine("Digite novamente...");
                    goto INICIOp2;
                }

            }
            else
            {
                contador = contador + 1;
                if (contador >= 3)
                {
                    Console.WriteLine("Programa será finalizado por segurança.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Digite novamente...");
                    goto INICIOp1;
                }

            }

            if (m >= 5)
            {
                Console.WriteLine("APROVADO!");
            }
            else if (m < 5 && m >= 3)
            {
                Console.WriteLine("EXAME");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
            Console.ReadKey();
        }
    }
}
