using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionarios_e_salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nc;
            double au, sl, df;
        INICIO:
            Console.WriteLine(" digite o cargo do funcionario");
            Console.WriteLine("1 - gerente ");
            Console.WriteLine(" 2 - analista");
            Console.WriteLine(" 3 - tecnico");
            Console.WriteLine(" 4 - não está na lista ");
            nc = Convert.ToInt32(Console.ReadLine());
            switch (nc)
            {
                case 1:
                    Console.WriteLine(" cargo de gerente");
                    Console.WriteLine(" salario de 4500");
                    sl = 4500;
                    au = sl * 0.1;
                    df = au - sl;
                    Console.WriteLine("salario:4500 você recebeu um aumento e passara a receber " + sl + " diferença:" + df);
                    break;
                case 2:
                    Console.WriteLine(" cargo de analista");
                    Console.WriteLine(" salario de 3000");
                    sl = 3000;
                    au = sl * 0.2;
                    df = au + sl;
                    Console.WriteLine("salario:3000, você recebeu um aumento e passara a receber " + df + " diferença:" + au);
                    break;
                case 3:
                    Console.WriteLine(" cargo de tecnico");
                    Console.WriteLine(" salario de 2300");
                    sl = 2300;
                    au = sl * 0.3;
                    df = au + sl;
                    Console.WriteLine("salario:2300 você recebeu um aumento e passara a receber " + df + " diferença:" + au);
                    break;
                case 4:
                    Console.WriteLine(" cargo não registrado");
                    Console.WriteLine(" salario de 1500");
                    sl = 1500;
                    au = sl * 0.4;
                    df = au + sl;
                    Console.WriteLine("salario:1500 você recebeu um aumento e passara a receber " + df + " diferença:" + au);
                    break;
                default:
                    Console.WriteLine("Opção errada, digite qualquer tecla para volar"); Console.ReadKey();
                    goto INICIO;
            }
            Console.ReadKey();
        }
    }
}
