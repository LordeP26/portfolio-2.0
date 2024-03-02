using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carteira_de_motorista_com_visual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//inicio 
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(3, 3);
                Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════╗");
                Console.SetCursorPosition(3, 4);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 6);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 7);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 8);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 9);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 10);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 11);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 12);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 13);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 14);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 15);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 16);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 17);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 18);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 19);
                Console.WriteLine("║                                                                          ║");
                Console.SetCursorPosition(3, 20);
                Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════╝");
            ini1:
                Console.SetCursorPosition(4, 5);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Double idd = 0;
                Console.Write("Digite sua idade: ");
                try
                {
                    idd = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.SetCursorPosition(4, 19);
                    Console.Write("Erro detectado, digite novamente");
                    goto ini1;
                }
                Console.SetCursorPosition(4, 19);
                Console.Write("                                      ");
                if (idd >= 21)
                {
                    Console.SetCursorPosition(4, 6);
                    Console.Write("Você esta apto.");
                }
                else
                {
                    Console.SetCursorPosition(4, 6);
                    Console.Write("Você esta inapto.");
                    goto ini1;
                }
                Console.SetCursorPosition(19, 6);
                Console.Write("    ");
            ini2:
                Double t1 = 0;
                Console.SetCursorPosition(4, 8);
                Console.Write("Possui a carteira B ha quantos anos? ");
                try
                {
                    t1 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.SetCursorPosition(4, 19);
                    Console.Write("Erro detectado, digite novamente");
                    goto ini2;
                }
                Console.SetCursorPosition(4, 19);
                Console.Write("                                      ");
                if (t1 < 2)
                {
                    Console.SetCursorPosition(4, 9);
                    Console.Write("Você esta inapto");
                inix:
                    Double t2 = 0;
                    Console.SetCursorPosition(4, 10);
                    Console.Write("Possui a carteira C ha quantos anos? ");
                    try
                    {
                        t2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.SetCursorPosition(4, 19);
                        Console.Write("Erro detectado, digite novamente");
                        goto inix;
                    }

                    if (t2 >= 1)
                    {
                        Console.SetCursorPosition(4, 11);
                        Console.Write("Você esta apto");
                    }
                    else
                    {
                        Console.SetCursorPosition(4, 11);
                        Console.Write("Você esta inapto");
                    }
                }
                else
                {
                    Console.SetCursorPosition(4, 9);
                    Console.Write("Você esta apto");
                }
            ini3:
                Double t3 = 0;
                Console.SetCursorPosition(4, 13);
                Console.Write("Ha quantos meses foi sua ultima infração? ");
                try
                {
                    t3 = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.SetCursorPosition(4, 19);
                    Console.Write("Erro detectado, digite novamente");
                    goto ini3;
                }
                Console.SetCursorPosition(4, 19);
                Console.Write("                                      ");
                if (t3 >= 12)
                {
                    Console.SetCursorPosition(4, 14);
                    Console.Write("parabens você cumpre todos os requisitos");
                }
                else
                {
                    Console.SetCursorPosition(4, 14);
                    Console.Write("voce esta inapto.");
                }
                Console.ReadKey();
            }
        }
    }
}
