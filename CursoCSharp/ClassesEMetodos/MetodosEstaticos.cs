using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosEstaticos
    {
        public class calculadoraEstatica
        {
            public static int Somar(int a, int b)
            {
                return a + b;
            }

            public static int Multiplicar( int a, int b)
            {
                return a * b;
            }
        }

        public static void Executar()
        {
            var resultado = calculadoraEstatica.Multiplicar(8, 3);

            Console.WriteLine($"Resultado da multiplicação: {resultado}");
            Console.WriteLine($"Resultado da soma: {calculadoraEstatica.Somar(8, 6)}");
        }
    }
}
