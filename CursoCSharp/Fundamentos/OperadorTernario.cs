﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            Console.WriteLine("Qual a sua nota?");
            var nota = double.Parse(Console.ReadLine());
            // var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento? "Aprovado" : "Reprovado";
            Console.WriteLine($"Você foi {resultado}");

        }
    }
}
