using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ExplorandoAPI
{
    internal class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos:" + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos:" + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);

            //Não altera o valor do TimeSpan, cria um novo TimeSpan com o novo valor
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(10)));
            Console.WriteLine(intervalo);

            Console.WriteLine("ToString 1: " + intervalo.ToString("g"));
            Console.WriteLine("ToString 1: " + intervalo.ToString("G"));
            Console.WriteLine("ToString 1: " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:25:45").TotalMilliseconds);
        }
    }
}
