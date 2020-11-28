using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LojaDeProdutos
{
    class ProdutoUsd : Produto
    {
        //Declaração da variavel e encapsulamento
        public DateTime Fabricacao { get; set; }
        public ProdutoUsd(string nome, double preco, DateTime fabricacao) : base(nome, preco) //Construtor com parametros
        {
            Fabricacao = fabricacao;
        }
        public override string precoTag() //Etiqueta do produto
        {
            return Nome + " (usado) - R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + "(fabricado: " + Fabricacao.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) + ")";
        }
    }
}
