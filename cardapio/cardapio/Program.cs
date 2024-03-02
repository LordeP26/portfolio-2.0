using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardapio
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.Clear();
            int op, op1, op2;
            string massa, molho;
            Console.WriteLine(" restaurante do peda ");
            Console.WriteLine(" escolha sua massa ");
            Console.WriteLine(" 1 - penne ");
            Console.WriteLine(" 2 - fusilli ");
            Console.WriteLine(" 3 - gnocchi ");
            Console.WriteLine(" 4 - fetuccine ");
            Console.WriteLine(" digite sua opção: ");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {//inicio switch
                case 1:
                    Console.WriteLine("A escolha de massa foi penne");
                    massa = "penne";
                    break;
                case 2:
                    Console.WriteLine("A escolha de massa foi fussili");
                    massa = "fussili";
                    break;
                case 3:
                    Console.WriteLine("A escolha de massa foi gnocchi");
                    massa = "gnocchi";
                    break;
                case 4:
                    Console.WriteLine("A escolha da massa foi fettucine");
                    massa = "fettucine";
                    break;
                default:
                    Console.WriteLine(" opção errada, digite qualquer coisa para voltar ");
                    Console.ReadKey();
                    goto inicio;
            }//fim switch
        molhos:
            Console.WriteLine(" escolha seu molho ");
            Console.WriteLine(" 1 - bolonhesa ");
            Console.WriteLine(" 2 - 4 queijos ");
            Console.WriteLine(" 3 - alfredo ");
            Console.WriteLine(" 4 - pesto ");
            Console.WriteLine(" digite sua opção: ");
            op1 = Convert.ToInt32(Console.ReadLine());
            switch (op1)
            {//inicio switch2
                case 1:
                    Console.WriteLine("A escolha do molho foi bolonhesa");
                    molho = "bolonhesa";
                    break;
                case 2:
                    Console.WriteLine("A escolha do molho foi 4 queijos");
                    molho = "4 queijos";
                    break;
                case 3:
                    Console.WriteLine("A escolha do molho foi alfredo");
                    molho = "alfredo";
                    break;
                case 4:
                    Console.WriteLine("A escolha do molho foi pesto");
                    molho = "pesto";
                    break;
                default:
                    Console.WriteLine(" opção errada, digite qualquer coisa para voltar ");
                    Console.ReadKey();
                    goto molhos;
            }//fim switch2
            Console.WriteLine("Seu prato escolhido foi: " + " " + massa + " " + molho + " Bon appetit!!");

        }
    }
}
