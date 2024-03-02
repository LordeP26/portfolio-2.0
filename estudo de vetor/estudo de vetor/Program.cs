using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_de_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[15];
            int c;
            for (c = 0; c <= 14; c++)
            {
                Console.Write("digite o numero: ");
                vet[c] = Convert.ToDouble(Console.ReadLine());
            }
            Array.Sort(vet);
            Console.WriteLine("             ");
            Console.WriteLine("o maior:");
            Console.WriteLine("             ");
            for (int i = 0; i <= 14; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.WriteLine("             ");
            Console.WriteLine("descrescente");
            Console.WriteLine("             ");
            for (int x = 14; x >= 0; x--)
            {
                Console.WriteLine(vet[x]);
            }
            Console.ReadKey();
        }
    }
}
