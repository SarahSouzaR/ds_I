using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    public class Animal
    {
        public float peso;
        public int idade;
        public int membros;

        public virtual void locomover() 
        {
            Console.WriteLine("move-se...");
        }

        public virtual void alimentar()
        {
            Console.WriteLine("alimenta-se...");
        }

        public virtual void emitirSom()
        {
            Console.WriteLine("emite som...");
        }

        public float getPeso()
        {
            return peso;
        }

        public void setPeso(float peso)
        {
            this.peso = peso;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getMembros()
        {
            return membros;
        }

        public void setMembros(int membros)
        {
            this.membros = membros;
        }

        public override string ToString()
        {
            return "Animal - " + "peso = " + peso + ", idade = " + idade + ", quantidade de membros = " + membros + '.';
        }
    }
}
