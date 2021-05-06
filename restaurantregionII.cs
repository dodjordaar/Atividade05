using System;
using System.Collections.Generic;
using System.Text;

namespace atividade05
{
    class restaurantregionII
    {
        static void Main(string[] args)
        {
            RestaurantesRegiao regtintaurna = new RestaurantesRegiao("Tintaurna");

            Restaurante r1 = new Restaurante("Lanche Saúdavel", "Rua das Saúvas.", "147");
            Produto p1 = new Produto("Pão com queijo (Triângulo)", "Sanduíche natural.", 5f);
            Produto p2 = new Produto("Bolo de banana com aveia", "Bolo de produtos naturais.", 20.00f);
            Produto p3 = new Produto("Salada de fruta", "Salada de frutas frescas.", 10.00f);
            r1.cardapio.adicionarProduto(p1);
            r1.cardapio.adicionarProduto(p2);
            r1.cardapio.adicionarProduto(p3);
            regtintaurna.adicionarRestaurante(r1);

            Restaurante r2 = new Restaurante("Casadinho Comigo", "Rua Bombeiros Desamparados.", "321");
            Produto p4 = new Produto("Doce de abóbora", "Condimento feito apartir de abóbora.", 12f);
            Produto p5 = new Produto("Casadinho de chocolate", "O famoso casadinho da casa.", 15.50f);
            r2.cardapio.adicionarProduto(p4);
            r2.cardapio.adicionarProduto(p5);
            regtintaurna.adicionarRestaurante(r2);

            regtintaurna.removerRestaurante(r1);
            regtintaurna.mostrarRestaurantes();
            r2.mostrarCardapio();

            Pedido pedido1 = new Pedido("Cliente1");
            pedido1.adicionarProduto(p1);
            pedido1.adicionarProduto(p2);
            pedido1.entregar();
            pedido1.mostrarPedido();
            r2.criarPedido("Cliente2", new Produto[] { p4, p5 });
            r1.criarPedido("Cliente45", new Produto[] { p3 });
            r2.criarPedido("Cliente23", new Produto[] { p4 });
            r2.mostrarPedidos(Restaurante.TipoPedido.NaoEntregado);
            r2.mostrarPedidos(Restaurante.TipoPedido.Entregado);
            r2.mostrarPedidos(Restaurante.TipoPedido.Todos);
        }
    }
}