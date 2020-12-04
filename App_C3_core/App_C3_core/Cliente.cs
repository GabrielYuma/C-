using System;
using System.Collections.Generic;
using System.Text;

namespace App_C3_core
{
    public class Cliente
    {
        private string nome;
        private int cpf;
        private int idade;
        private string email;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Cpf
        {
            get { return this.cpf; }
            set { this.cpf = value; }
        }

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string toString()
        {
            return $"Nome do Cliente {this.nome} de idade {this.idade}\n CPF do Cliente: {this.cpf}\nEmail:{this.email}";
        }
    }
}
