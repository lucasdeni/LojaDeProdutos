using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LojaDeProdutos
{
    class ProdutoImp : Produto
    {
        //Declaração da variavel e encapsulamento
        public double Taxa { get; set; }
        public ProdutoImp(string nome, double preco, double taxa) : base(nome, preco) //Construtor com parametros
        {
            Taxa = taxa;
        }
        public double precoTotal() //Calcular o preço total
        {
            return Preco + Taxa;
        }
        public override string precoTag() //Etiqueta do produto
        {
            return Nome
                + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Taxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
