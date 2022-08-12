using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            Console.Write("Digite sua nota: ");
            double nota = Double.Parse(Console.ReadLine());
            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a obrigação");

            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
