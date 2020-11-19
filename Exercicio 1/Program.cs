using System;

namespace Nota
{
    class Program
    {
        static void Main(string[] args)
        {

            int nota;

            do{
                Console.WriteLine("--------------------------------");
                Console.Write("Digite uma nota de 0 a 10: ");
                nota = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                if(nota < 0 || nota > 10){
                    Console.WriteLine("Número inválido, tente novamente.");
                }
            } while(nota < 0 || nota > 10);

            Console.WriteLine("Nota aceita, tenha um bom dia!");
            Console.WriteLine("--------------------------------");
        }
    }
}
