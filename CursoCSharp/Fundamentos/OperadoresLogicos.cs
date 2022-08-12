﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou a Tv de 50? {comprouTv50}");

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou Tv de 32? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");
        }
    }
}
