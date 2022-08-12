using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Marcos");
            fila.Enqueue("João");
            fila.Enqueue("Paulo");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine();
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine();
            Console.WriteLine(fila.Peek());
            Console.WriteLine();
            Console.WriteLine(fila.Count);
            Console.WriteLine();

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains(3));


        }
    }
}
