using System;
using Objetos_como_argumento_exemplo.Classes;

namespace Objetos_como_argumento_exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!! LISTA DE PRODUTOS !!\n");
            

            // Criamos alguns produtos 
            Produto p1 =new Produto(1, "Forza", 499f);
            Produto p2 =new Produto(2, "GTA 5", 56.90f);
            Produto p3 =new Produto(3, "Free Fire", 0f);
            Produto p4 =new Produto(4, "Caleste", 22.99f);

            // Adcionar eles no carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.Adcionarproduto(p1);
            carrinho.Adcionarproduto(p2);
            carrinho.Adcionarproduto(p3);
            carrinho.Adcionarproduto(p4);
            
            // Mostrar nosso carrinho completo:
            carrinho.MostrarProdutos();
        }
    }
}
