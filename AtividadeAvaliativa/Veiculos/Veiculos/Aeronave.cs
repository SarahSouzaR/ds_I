using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Aeronave : Veiculo 
    {
        private string corFuselagem;

        public string getCorFuselagem()
        {
            return corFuselagem;
        }

        public void setCorFuselagem(string corFuselagem)
        {
            this.corFuselagem = corFuselagem;
        }

        public string arremeter()
        {
            return "arremeter";
        }

        public string descricao()
        {
            return "Aeronave: " + marca;
        }
    }
}
