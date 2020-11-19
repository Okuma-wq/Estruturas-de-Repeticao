using System;

namespace Nome_e_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Olá, seja bem-vindo!");
            Console.Write("Digite o nome de usuário desejado: ");
            string nome = Console.ReadLine().ToLower();

            string senha = "";

            do{
                Console.Write("Digite a senha desejada: ");
                senha = Console.ReadLine().ToLower();

                if (nome == senha){
                    Console.WriteLine("O nome de usuário e senha não podem ser iguais, favor inserir uma senha válida");
                }
            } while(nome == senha);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Seu cadastro foi realizado com sucesso!");
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
