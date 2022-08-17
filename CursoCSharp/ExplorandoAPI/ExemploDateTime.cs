using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExplorandoAPI
{
    internal class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year:2030, month:2, day:1);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);
            // com Horas
            var dialAtual = DateTime.Now;
            Console.WriteLine(dialAtual);
            Console.WriteLine("Hora: " + dialAtual.Hour);
            Console.WriteLine("Minutes: " + dialAtual.Minute);

            var amanha = dialAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = dialAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(dialAtual.ToString("dd"));
            Console.WriteLine(dialAtual.ToString("d"));
            Console.WriteLine(dialAtual.ToString("D"));
            Console.WriteLine(dialAtual.ToString("g"));
            Console.WriteLine(dialAtual.ToString("O")); 
            Console.WriteLine(dialAtual.ToString("m"));
            Console.WriteLine(dialAtual.ToString("ff"));
            Console.WriteLine(dialAtual.ToString("t"));
            Console.WriteLine(dialAtual.ToString("u"));
            Console.WriteLine(dialAtual.ToString("F"));
            Console.WriteLine(dialAtual.ToString("fffffff"));
            Console.WriteLine(dialAtual.ToString("R"));
            Console.WriteLine(dialAtual.ToString("y"));
            Console.WriteLine(dialAtual.ToString("U"));
            Console.WriteLine(dialAtual.ToString("G"));
            Console.WriteLine(dialAtual.ToString("dd-MM-yyyy HH:mm"));

        }
    }
}
