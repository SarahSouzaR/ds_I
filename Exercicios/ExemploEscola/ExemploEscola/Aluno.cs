using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploEscola
{
    class Aluno : Pessoa
    {
        private int matricula;
        private string curso;

        public void cancelarMatricula()
        {
            Console.WriteLine("Matrícula cancelada!");
        }

        public int getMatricula()
        {
            return matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string getCurso()
        {
            return curso;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public override string ToString()
        {
            return "Aluno{"+"matrícula="+matricula+", curso="+curso+'}';
        }
    }
}
