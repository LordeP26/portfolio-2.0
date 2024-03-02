using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v;
            Console.WriteLine("digite o valor de vendas: ");
            v = Convert.ToDouble(Console.ReadLine());
            if (v < 1000)
            {
                Console.WriteLine("infelizmente não houve vendas o suficiente");
            }
            else if ((v >= 1000) && (v < 3000))
            {
                Console.WriteLine("sua recompensa foi de R$ 150,00. Parabéns!!!");
            }
            else
            {
                Console.WriteLine("sua recompensa foi de R$ 300,00. Parabéns!!!");
            }
        }
    }
}
