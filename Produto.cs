using System;
using System.Collections.Generic;
using System.Text;

namespace atividade05
{
    class Produto
    {
        public string nome;
        public string descricao;
        public float valor;

        public Produto(string nome, string descricao, float valor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}