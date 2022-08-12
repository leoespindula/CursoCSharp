using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        static public void Executar()
        {
            string nome = "Notebook FE15";
            string marca = "Vaio";
            double preco = 4010.99;

            Console.WriteLine("O " + nome +" da marca " + marca +" custa R$" + preco +".");

            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa R${preco}.");
            //Os resultados são os mesmos.

            Console.WriteLine($"1 + 1 = {1+1}.");
        }
    }
}
