using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomes_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, primeiro, nomesb, nomect, nomere;
            int pos, pos2;
            Console.WriteLine("Digite seu nome completo:");
            nome = Console.ReadLine();
            pos = nome.IndexOf("o");
            pos2 = nome.IndexOf("F");
            primeiro = nome.Substring(0, 5);
            Console.WriteLine("primeiro nome: " + primeiro);
            nomesb = nome.Substring(pos2);
            Console.WriteLine("ultimo nome: " + nomesb);
            nomect = nome.Substring(5, 10);
            Console.WriteLine("nome do caracter 5 ao 10:" + nomect);
            nomere = nome.Replace("a", "o");
            Console.WriteLine("nome com letras trocadas:" + nomere);
        }//final
    }
    
}
