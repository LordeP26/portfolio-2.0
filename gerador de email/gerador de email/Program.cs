using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerador_de_email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, email, email2;
            int pos, pos1;
            Console.WriteLine("digite seu nome completo: ");
            nome = Console.ReadLine();
            nome = nome.Trim();
            nome = nome.ToLower();
            pos = nome.IndexOf(" ");
            pos1 = nome.LastIndexOf(" ");
            email = nome.Substring(0, pos);
            email2 = nome.Substring(pos1);
            Console.WriteLine("seu email é: " + email + email2.Replace(" ", ".") + "@esamc.br");
            Console.ReadKey();
        }
    }
}
