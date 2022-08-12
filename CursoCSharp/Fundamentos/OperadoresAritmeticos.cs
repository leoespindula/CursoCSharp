using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço original do produto é R${total}, e o preco com desconto é R${totalComDesconto}");

            //IMC 
            Console.WriteLine("TABELA DE IMC");
            Console.WriteLine("Digite o seu peso:");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura:");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Seu IMC é {imc}");

            //Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine($"{par}/2 tem o resto {par % 2}");
            Console.WriteLine($"{impar}/2 tem o resto {impar % 2}");


        }
    }
}
