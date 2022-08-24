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
            

            p1.CadastrarPessoa();

            //p1.setNome();
            //p1.setNascimento();
            //p1.setCpf();
            //p1.setTelefone();

            p1.ImprimirCadastro(); // opção para imprimir as infos no lugar do get/ToString

            Console.ReadKey();

            p2.setNome();
            p2.setNascimento();
            p2.setCpf();
            p2.setTelefone();

            Console.WriteLine(p2.ToString());
            Console.ReadKey();

            p3.setNome();
            p3.setNascimento();
            p3.setCpf();
            p3.setTelefone();

            //Console.WriteLine(p3.ToString());
            //Console.ReadKey();

            p1.getNome();
            p1.getNascimento();
            p1.getCpf();
            p1.getTelefone();

            //Console.ReadKey();

            //p2.getNome();
            //p2.getNascimento();
            //p2.getCpf();
            //p2.getTelefone();

            //Console.ReadKey();

            //p3.getNome();
            //p3.getNascimento();
            //p3.getCpf();
            //p3.getTelefone();

            //Console.ReadKey();

            //p4 utilizando o 2º método construtor
            Console.WriteLine("Nome: ");
            string n = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            DateTime nasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("CPF: ");
            string cp = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            string tel = Console.ReadLine();

            Pessoa p4 = new Pessoa(n, nasc, cp, tel);

            p4.ImprimirCadastro();

        }
    }
}
