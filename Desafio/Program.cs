using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-----------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Gerando uma série do algoritmo Fibonacci que ultrapasse 500");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            int num1 = 0, num2 = 1, num3 = 0;

            Console.Write(num1 + ", " + num2);

            do{
                num3 = num1 + num2;

                num1 = num2;

                num2 = num3;

                Console.Write(", " + num2);

            } while(num2 < 500);

            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
