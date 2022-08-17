using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome= "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() {Nome= "Ana", Idade = 21, Nota = 8.9 },
                new Aluno() {Nome= "João", Idade = 23, Nota = 7.0 },
                new Aluno() {Nome= "Jorge", Idade = 28, Nota = 9.5 },
                new Aluno() {Nome= "Julia", Idade = 18, Nota = 6.8 },
                new Aluno() {Nome= "Marcio", Idade = 19, Nota = 7.7 },
                new Aluno() {Nome= "Andre", Idade = 24, Nota = 4.3 },
                new Aluno() {Nome= "Andre", Idade = 23, Nota = 8.3 }
            };
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));

            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var andre = alunos.First(aluno => aluno.Nome.Equals("Andre"));
            Console.WriteLine(andre.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }
            var outroAndre = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Andre"));
            Console.WriteLine(outroAndre.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaDaTurma2 = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma2);

        }
    }
}
