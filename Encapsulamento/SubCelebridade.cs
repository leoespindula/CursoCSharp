using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos
        public string InfoPublica = "Tenho um Instagram!";

        //Herança
        protected string CorDoOlho = "Verde";

        //Mesmo Projeto (assembly)
        internal ulong NumeroCelular = 5527999888940;

        //Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        //Mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        //Private é o Padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
