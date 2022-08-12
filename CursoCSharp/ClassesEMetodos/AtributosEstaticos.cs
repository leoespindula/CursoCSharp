﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    internal class AtributosEstaticos
    {
       

        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2, 0.1);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.1
            };
            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");
        }
    }
}
