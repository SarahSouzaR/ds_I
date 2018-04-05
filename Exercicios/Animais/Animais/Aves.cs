using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Aves : Animal
    {
        private string corPena;

        public override void locomover()
        {
            Console.WriteLine("Voa");
        }

        public void fazerNinho()
        {
            Console.WriteLine("faz seu próprio ninho.");
        }

        public string getCorPena()
        {
            return corPena;
        }

        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }

        public override string ToString()
        {
            return "Aves - " + "cor da pena = " + corPena + ", idade = " + idade + '.';
        }

    }
}
