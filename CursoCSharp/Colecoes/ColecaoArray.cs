using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecaoArray
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Tadeu";
            alunos[2] = "João";
            alunos[3] = "Julio";
            alunos[4] = "Ana";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'a', 'b', 's', 'k', 'i' };
            string palavra = new string(letras);
            Console.WriteLine(palavra); 
        }
    }
}
