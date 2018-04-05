using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empregado
{
    class Assalariado : TipoEmpregado
    {
        private double salario;

        public double getSalario()
        {
            return salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public override double vencimento()
        {
             return salario;
        }

        public override string complemento()
        {
            return " será o salário de " + nome + ". \n";
        }    
    }

}
