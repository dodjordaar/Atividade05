using System;
using System.Collections.Generic;
using System.Text;

namespace atividade05
{
    class Restaurante
    {
        public enum TipoPedido
        {
            Entregado,
            NaoEntregado,
            Todos
        }
        public string nome, endereco, cnpj;
        public Cardapio cardapio;
        public List<Pedido> pedidos;

        public Restaurante(string nome, string endereco, string cnpj)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cnpj = cnpj;
            this.cardapio = new Cardapio();
            this.pedidos = new List<Pedido>();
        }
        public bool aceitaPedido(List<Produto> p)
        {
            if (p.Count > 0 && p.Count <= 5) return true;
            return false;
        }
        public void mostrarCardapio()
        {
            Console.WriteLine($" - Cardápio do restaurante {nome} - ");
            foreach (Produto p in cardapio.produtos)
            {
                Console.WriteLine($"{p.nome} {p.descricao} {p.valor}");
            }
            Console.WriteLine();
        }
        public void adicionarProduto(Produto p)
        {
            this.cardapio.adicionarProduto(p);
        }

        public void removerProduto(Produto p)
        {
            this.cardapio.removerProduto(p);
        }

        public bool adicionarPedido(Pedido p)
        {
            if (this.aceitaPedido(p.produtos))
            {
                this.pedidos.Add(p);
                return true;
            }
            return false;
        }
        public bool removerPedido(Pedido p)
        {
            return this.pedidos.Remove(p);
        }
        public bool criarPedido(string nomeCliente, Produto[] produtos)
        {
            List<Produto> listProdutos = new List<Produto>(produtos);
            Pedido p = new Pedido(nomeCliente, listProdutos);
            return this.adicionarPedido(p);
        }
        public void mostrarPedidos(TipoPedido tipo)
        {
            Console.WriteLine($" - Pedidos do restaurante {nome} - ");
            switch (tipo)
            {
                case TipoPedido.Entregado:
                    Console.WriteLine("Pedidos que foram entregues.");
                    foreach (Pedido p in this.pedidos)
                    {
                        if (p.entregue) p.mostrarPedido();
                    }
                    break;
                case TipoPedido.NaoEntregado:
                    Console.WriteLine("Pedidos que não foram entregues.");
                    foreach (Pedido p in this.pedidos)
                    {
                        if (!p.entregue) p.mostrarPedido();
                    }
                    break;
                case TipoPedido.Todos:
                    Console.WriteLine("Pedidos.");
                    foreach (Pedido p in this.pedidos) p.mostrarPedido();
                    break;
            }
            Console.WriteLine();
        }
    }
}