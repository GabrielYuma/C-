using System;
using System.Collections.Generic;
using System.Text;

namespace App_C3_core
{
    public class Produto
    {
        private string nome;
        private float preco;
        private int cod;
        private int qnt;
        private string desc;

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value;}
        }

        public float Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }

        public int Cod
        {
            get { return this.cod; }
            set { this.cod = value; }
        }

        public int Qnt
        {
            get { return this.qnt; }
            set { this.qnt = value; }
        }

        public string Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
        }

        public string toString()
        {
            return $"Jogo: {this.nome} || Código: {this.cod}\n Preço: R${this.preco}\n Quantidade Disponível: {this.qnt}\n Descrição: {this.desc}";
        }
    }
}
