using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empregado
{
    class TipoEmpregado
    {
        public string nome;
        private string sobrenome;
        private string cpf;
        private double salario;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome) 
        {
            this.nome = nome;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public double getSalario()
        {
            return salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public virtual double vencimento()
        {
            return salario;
        }

        public virtual string complemento()
        {
            return " será o salário de " + nome + ". \n";
        }        
    }
}
