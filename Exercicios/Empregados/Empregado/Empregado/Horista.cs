using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empregado
{
    class Horista : TipoEmpregado
    {
        private double precoHora;
        private double horasTrabalhadas; 

        public double getPrecoHora()
        {
            return precoHora;
        }

        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;
        }

        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }

        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double vencimento()
        {
            double salario = precoHora * horasTrabalhadas;
            return salario;
        }

        public override string complemento()
        {
            return " será o salário de " + nome + ". \n";
        }   
    }
}
