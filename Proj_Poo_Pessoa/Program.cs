using System;

namespace Proj_Poo_Pessoa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            DateTime nascimento;
            String cpf;
            String telefone;

            Pessoa p1 = new Pessoa(); // classe + nome obj = método construtor
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();
            

            p1.setNome();
            p1.setNascimento();
            p1.setCpf();
            p1.setTelefone();

            Console.ReadKey();

            p2.setNome();
            p2.setNascimento();
            p2.setCpf();
            p2.setTelefone();

            Console.ReadKey();

            p3.setNome();
            p3.setNascimento();
            p3.setCpf();
            p3.setTelefone();

            Console.ReadKey();

            p1.getNome();
            p1.getNascimento();
            p1.getCpf();
            p1.getTelefone();

            Console.ReadKey();

            p2.getNome();
            p2.getNascimento();
            p2.getCpf();
            p2.getTelefone();

            Console.ReadKey();

            p3.getNome();
            p3.getNascimento();
            p3.getCpf();
            p3.getTelefone();

            Console.ReadKey();


        }
    }
}
