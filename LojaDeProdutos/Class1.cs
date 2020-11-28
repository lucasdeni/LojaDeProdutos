using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LojaDeProdutos
{
    class Produto
    {
        //Declaração das variaveis e encapsulamento
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Produto(string nome, double preco) //Construtor com parametros
        {
            Nome = nome;
            Preco = preco;
        }
        public virtual string precoTag() //Etiqueta do produto
        {
            return Nome + " - R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
