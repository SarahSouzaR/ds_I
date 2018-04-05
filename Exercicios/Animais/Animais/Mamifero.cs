using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Mamifero : Animal
    {
        private string corPelo;
        private string raca;

        public override void locomover()
        {
            Console.WriteLine("Anda");
        }

        public string getCorPelo()
        {
            return corPelo;
        }

        public void setCorPelo(string corPelo)
        {
            this.corPelo = corPelo;
        }

        public string getRaca()
        {
            return raca;
        }

        public void setRaca(string raca)
        {
            this.raca = raca;
        }

        public override string ToString()
        {
            return "Mamifero - " + "cor do pelo = " + corPelo + ", raça = " + raca + ", peso = " + peso + ", idade = " + idade + ", quantidade de membros = " + membros + '.';
        }

    }
}
