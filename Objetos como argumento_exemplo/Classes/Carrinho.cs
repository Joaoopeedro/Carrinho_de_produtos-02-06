using System;
using System.Collections.Generic;

namespace Objetos_como_argumento_exemplo.Classes
{
    public class Carrinho
    {
        
        public float ValorTotal { get; set; }

        // Criamos uma lista 
        List<Produto> carrinho = new List<Produto>();

        // Criamos um metodo de adcionar um produto ao carrinho
        public void Adcionarproduto(Produto produto)
        {
            carrinho.Add(produto);
        }


        // Criamos um metodo que remove um produto do carrinho
        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{p.Preco:C2} - {p.Nome}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }


        public void MostrarTotal(){
            Console.ForegroundColor = ConsoleColor.Magenta;

            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do Carrinho {ValorTotal:C2}");
            }else
            {
                Console.WriteLine($"Seu carrinho esta Vazio!");
            }
            Console.ResetColor();
        }

        public void AlterarItem(int _codigo, Produto novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = novoProduto.Nome;

            // foreach (Produto x in carrinho)
            // {
            //     if (x.Codigo == _codigo)
            //     {
            //         x.Nome = novoProduto.Nome;
            //     }
            // }
        }

    }
}