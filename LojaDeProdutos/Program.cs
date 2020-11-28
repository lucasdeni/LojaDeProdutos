using System;
using System.Collections.Generic;
using System.Globalization;

namespace LojaDeProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> prod = new List<Produto>(); //Lista para conter os produtos
            Console.Write("Entre com o número de produtos: "); //Número de produtos
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduto #{i}:");
                Console.Write("Comum, Usado ou Importado (C/U/I)? "); //Tipo de produto
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: "); //Nome do produto
                string nome = Console.ReadLine();
                Console.Write("Preço: "); //Preço do produto
                double preco = double.Parse(Console.ReadLine());
                if (tipo == 'U')
                {
                    Console.Write("Fabricação (DD/MM/AA): "); //Data de fabricação do produto
                    DateTime fabricacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yy", CultureInfo.InvariantCulture);
                    prod.Add(new ProdutoUsd(nome, preco, fabricacao)); //Adiciona na lista
                }
                else if (tipo == 'I')
                {
                    Console.Write("Taxa: "); //Taxa do produto
                    double taxa = double.Parse(Console.ReadLine());
                    prod.Add(new ProdutoImp(nome, preco, taxa)); //Adicionar na lista
                }
                else
                {
                    prod.Add(new Produto(nome, preco)); //Adicionar na lista
                }
            }
            Console.WriteLine("\nEtiquetas:"); //Imprime a etiqueta
            foreach (Produto produto in prod)
            {
                Console.WriteLine(produto.precoTag());
            }
            Console.ReadKey();
        }
    }
}
