using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Poo_Pessoa

{
    internal class Pessoa
    {
        //atributos da classe = variáveis da classe / primeira letra maiúscula.
        String nome;
        DateTime nascimento;
        String cpf;
        String telefone;

        //métodos = funções da classe
        public Pessoa() // método construtor
        {
        }

        public void setNome()
        {
            Console.WriteLine("Informe o nome: ");
            this.nome = Console.ReadLine();
        }
        public void getNome()
        {
            Console.WriteLine(this.nome);
        }
        public void setNascimento()
        {
            Console.WriteLine("Digite a data de nascimento: ");
            this.nascimento = System.DateTime.Parse(Console.ReadLine());
        }
        public void getNascimento()
        {
            Console.WriteLine(this.nascimento.ToShortDateString());
        }
        public void setCpf()
        {
            Console.WriteLine("Digite o CPF: ");
            this.cpf = Console.ReadLine();
        }
        public void getCpf()
        {
            Console.WriteLine(this.cpf);
        }
        public void setTelefone()
        {
            Console.WriteLine("Digite o telefone: ");
            this.telefone = Console.ReadLine();
        }
        public void getTelefone()
        {
            Console.WriteLine(this.telefone);
        }

    }
}











