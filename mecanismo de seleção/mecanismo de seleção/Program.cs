using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mecanismo_de_seleção
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            int op;
            Console.WriteLine("digite uma opção de 0 a 3: ");
            op = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("opção digitada: " + op);
            if (op == 0)
            {
                Console.WriteLine("digitou zero");
            }
            else if (op == 1)
            {
                Console.WriteLine("digitou um");
            }
            else if (op == 2)
            {
                Console.WriteLine("digitou dois");
            }
            else if (op == 3)
            {
                Console.WriteLine("digitou três");
            }
            else
            {

                Console.WriteLine("nenhum valor encontrado");
                Console.WriteLine("digite 1 para continuar...");
                int op2 = Convert.ToInt32(Console.ReadLine());
                if (op2 == 1)
                {
                    Console.Clear();
                    goto inicio;
                }
                else
                {
                    Console.WriteLine("Tchau!!!!");
                }
            }
            Console.ReadKey();
        }
    }
}
