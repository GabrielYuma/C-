using System;
using System.Collections.Generic;
using System.Text;

namespace App_C3_core
{
   public class Objeto
    {
        private string nome;
        private int codigo;
        private int idade;
        private float sal;

       public string Nome { 
            get { return nome; }
            set { nome = value;  }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public float Sal
        {
            get { return sal; }
            set {sal = value; }
        }

        public string toString() {
            return $"{this.nome} tem {this.idade} anos, e recebe R${this.sal}";
        }
    }
}
