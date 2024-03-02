using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_de_nomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, nomeMB, nomeM2, nomePA, nometr, nomeESP;
            int pos;
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("nome digitado: " + nome);
            nomeMB = nome.ToUpper();
            Console.WriteLine("nome maiusculo: " + nomeMB);
            nomeM2 = nome.ToLower();
            Console.WriteLine("nome minusculo: " + nomeM2);
            pos = nomeMB.IndexOf("L");
            if (pos < 0)
            {//if
                Console.WriteLine("nao encontrou.");
            }//if
            else
            {// else
                Console.WriteLine("A posição do L: " + pos);
            }// else
            nomePA = nome.Substring(4, 5);
            Console.WriteLine("nome cortado: " + nomePA);
            nometr = nome.Replace("a", "o");
            Console.WriteLine("nome trocado: " + nometr);
            nomeESP = nome.Trim();
            Console.WriteLine("nome sem espaços: " + nomeESP);
            Console.ReadKey();
        }
    }
}
