using System;

namespace Proj_Poo_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome = "";
            String nascimento = "";
            String cpf = "";
            String telefone = "";

            Pessoa[] pessoas = new Pessoa[3];


            for(int i = 0; i < pessoas.Length; i++)
            {
                pessoas[i] = new Pessoa(nome,nascimento,cpf,telefone);

                Console.WriteLine($"Digite o nome da pessoa {i+1}: ");
                nome = Console.ReadLine();

                Console.WriteLine($"\nDigite data de nascimento da pessoa {i+1}:");
                nascimento = Console.ReadLine();

                Console.WriteLine($"\nDigite o cpf da pessoa {i+1}: \n");
                cpf = Console.ReadLine();

                Console.WriteLine($"\nDigite o telefone da pessoa {i+1}: \n");
                telefone = Console.ReadLine();

                Console.WriteLine();
            }

            for(int i = 0; i <pessoas.Length; i++)
            {
                Console.WriteLine(pessoas[i]);
            }







        }
    }
}