using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Poo_Pessoa
{
    internal class Pessoa
    {
        String nome;
        String nascimento;
        String cpf;
        String telefone;

    
        public Pessoa(String nome, String nascimento, String cpf, String telefone)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.telefone = telefone;
        }
        public override string ToString()
        {
            return $"Nome: {nome} \nData Nasc: {nascimento} \nCPF: {cpf} \nTelefone: {telefone}";
        }

    }
}







