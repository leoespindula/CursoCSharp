using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class MetodosComRetorno
    {
        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
            public int Dividir(int a, int b)
            {
                return a / b;
            }
        }

        class CalculadoraCadeia
        {
            int memoria;

            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }
            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }
            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }
            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria);
                return this;
            }
            public int Resultado()
            {
                return memoria;
            }
        }

        public static void Executar()
      
        {
            var calculadoracomum = new CalculadoraComum();
            var resultado = calculadoracomum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoracomum.Subtrair(6,9));
            Console.WriteLine(calculadoracomum.Multiplicar(9,7));
            Console.WriteLine(calculadoracomum.Dividir(8,2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(8).Resultado();
            Console.WriteLine(resultado);

        }
    }
}
