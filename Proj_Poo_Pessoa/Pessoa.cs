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
        public Pessoa() // método construtor - guarda local na memória
        {
        }

        //método construtor com parâmetros
        public Pessoa(string n, DateTime nasc, string cp, string tel) 

        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.telefone = telefone;
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

        //método para imprimir os dados na tela
        public override string ToString()//override sobrescreve o conteúdo do método
        {
            return "\nNome: " + this.nome + "\nData de nascimento: " + this.nascimento + "\nCPF: " + this.cpf + "\nTelefone: " + this.telefone;
        }

        //função para cadastrar pessoas
        public void CadastrarPessoa()
        {
            setNome();
            setNascimento();
            setCpf();
            setTelefone();
        }

        //imprime os cadastros -  usar no lugar de get ou ToString().
        public void ImprimirCadastro()
        {
            getNome();
            getNascimento();
            getCpf();
            getTelefone();
        }

    }
}











