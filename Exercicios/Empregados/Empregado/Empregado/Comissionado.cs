using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empregado
{
    class Comissionado : TipoEmpregado
    {
        private double totalVenda;
        private double taxaComissao;

        public double getTotalVenda()
        {
            return totalVenda;
        }

        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;
        }

        public double getTaxaComissao()
        {
            return taxaComissao;
        }

        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public override double vencimento()
        {
            double salario = (totalVenda * taxaComissao) + totalVenda;
            return salario;
        }

        public override string complemento()
        {
            return " será o salário de " + nome + ". \n";
        }   
    }
}
