using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;     //Variável
            const double PI = 3.14;     //Constante
            Console.WriteLine(raio);

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

        // Tipos internos
            // inteiros

            bool estaChovendo = true; //true ou false
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; //de 0 a 256
            Console.WriteLine("A idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue; //-128 a 127
            Console.WriteLine("O saldo de gols é " + saldoDeGols);

            short salario = short.MinValue;   //-32768 a 32767
            Console.WriteLine(" O salário é " + salario);

            int menorValorInt = int.MaxValue;  //-2.147.483.648 a 2.147.483.647 (Mais usado dos inteiros)
            Console.WriteLine("O menor valor inteiro é " + menorValorInt);

            uint populacaoBrasileira = uint.MaxValue;//0 a 4.294.967.295 (Paravalores sem sinal)
            Console.WriteLine("População brasileira é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long é " + menorValorLong);

            ulong maiorValorUlong = ulong.MaxValue;//Para valores muito alto sem sinal
            Console.WriteLine("Maior valor ulong é " + maiorValorUlong);

            //Reais

            float precoComputador = 1299.99f;
            Console.WriteLine("O valor do computador é R$" + precoComputador);

            double maiorValorDouble = double.MaxValue;
            Console.WriteLine("O maio valor double é " + double.MaxValue);

            decimal maiorValorDecimal = decimal.MaxValue;
            Console.WriteLine("O maior valor decimal é " + decimal.MaxValue);

            char letra = 'x';
            Console.WriteLine("A letra é " + letra);

            string texto = "Olá mundo!";
            Console.WriteLine(texto);





        }   
    }
}
