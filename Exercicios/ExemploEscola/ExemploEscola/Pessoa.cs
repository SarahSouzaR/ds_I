using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploEscola
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string sexo;

        public void fazerAniversario()
        {
            this.idade++;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public string getSexo()
        {
            return sexo;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo; 
        }

        public override string ToString()
        {
            return "Pessoa{" + "nome=" + nome + ", idade=" + idade + ", sexo=" + sexo + '}';
        }
    }
}
