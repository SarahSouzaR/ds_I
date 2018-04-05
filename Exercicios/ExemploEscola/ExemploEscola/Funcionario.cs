using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploEscola
{
    class Funcionario : Pessoa
    {
        private string setor;
        private Boolean trabalhando;

        public void mudarTrabalho()
        {
            this.trabalhando = !this.trabalhando;
        }

        public string getSetor()
        {
            return setor;
        }

        public Boolean getTrabalhando()
        {
            return trabalhando;
        }

        public void setTrabalhando(Boolean trabalhando)
        {
            this.trabalhando = trabalhando;
        }

        public override string ToString()
        {
            return "Funcionario{"+"setor= "+setor+", trabalhando= "+trabalhando+'}';
        }
    }
}
