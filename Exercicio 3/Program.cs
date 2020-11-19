using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Seja Bem-Vindo");
            Console.WriteLine("Favor fornecer os seguintes dados:");

            string nome;
            int idade;
            double salario;
            string estadoCivil;

            do{
                Console.Write("Nome: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                nome = Console.ReadLine();
                Console.ResetColor();

                if(nome == "" || nome == " "){
                    Console.WriteLine("-------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O campo nome não pode ser deixado em branco");
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------------------------");
                }
            } while(nome == "" || nome == " ");

            do{
                Console.Write("Idade: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                idade = int.Parse(Console.ReadLine());
                Console.ResetColor();
                
                if(idade < 0 || idade > 150){
                    Console.WriteLine("------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A idade fornecida é inválida, favor tentar novamente");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------");
                }
            } while(idade < 0 || idade > 150);

            do{
                Console.Write("Salário Atual: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                salario = double.Parse(Console.ReadLine());
                Console.ResetColor();

                if(salario < 0){
                    Console.WriteLine("------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("O valor inserido é inválido, favor tentar novamente");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------");
                }
            } while(salario < 0);

            do{
                Console.Write("Estado Civil ('S' para Solteiro(a), 'C' para Casado(a), 'V' para Viuvo(a), 'D' para Divorciado(a)): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                estadoCivil = Console.ReadLine().ToLower();
                Console.ResetColor();

                if(estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d"){
                    Console.WriteLine("------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Estado civil digitado inválido, favor tentar novamente");
                    Console.ResetColor();
                    Console.WriteLine("------------------------------------------------------");
                }

            }while(estadoCivil != "s" && estadoCivil != "c" && estadoCivil != "v" && estadoCivil != "d");
            
            Console.WriteLine("------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Suas informações foram salvas com sucesso");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
