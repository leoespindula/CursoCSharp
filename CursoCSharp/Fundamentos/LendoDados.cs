using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu sálario?");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); 

            Console.WriteLine($"{nome} cujo idade é {idade} anos, tem um salario de R${salario}");


        }
    }
}
