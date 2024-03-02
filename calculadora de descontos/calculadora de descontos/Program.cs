using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_descontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double qt, pru, tt, tp, desc, tp1, desc1, tp2, desc2;
            Console.WriteLine("Digite o nome do produto");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade adquirida");
            qt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o preço unitario");
            pru = Convert.ToDouble(Console.ReadLine());
            tt = qt * pru;
            desc = 2.0 / 100.0;
            tp = tt - (desc * tt);
            desc1 = 3.0 / 100.0;
            tp1 = tt - (desc1 * tt);
            desc2 = 5.0 / 100.0;
            tp2 = tt - (desc2 * tt);
            if (qt <= 5)
            {
                Console.WriteLine("seu desconto foi de 2%");
                Console.WriteLine("voce deve pagar: " + tp + " reais");
            }
            else if ((qt > 5) && (qt <= 10))
            {
                Console.WriteLine("seu desconto foi de 3% ");
                Console.WriteLine("voce deve pagar: " + tp + " reais");
            }
            else
            {
                Console.WriteLine("seu desconto foi de 5% ");
                Console.WriteLine("voce deve pagar: " + tp2 + " reais");
            }
        }
    }
}
