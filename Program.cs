using System;

namespace Meme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ultilize apenas S/N para dar respostas.");

            Console.Write("Esta se movendo?");
            char movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());

            if( movendo == 'S' )
            {
               Console.Write("Deveria?");
               movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());

               if( movendo == 'S')
               {
                    Console.WriteLine("otimo.");
               }
               else
               {
                    Console.WriteLine("use Silver Tape.");
               }
            }
            else
            {
                Console.Write("Deveria?");
                movendo = Convert.ToChar(Console.ReadLine()!.ToUpper());

                if( movendo == 'S')
                {
                    Console.WriteLine("Use WD-40");
                }
                else
                {
                    Console.WriteLine("otimo.");
                }
            }
        }
    }
}