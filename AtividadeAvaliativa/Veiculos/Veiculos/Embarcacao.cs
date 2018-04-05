using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Embarcacao : Veiculo
    {
        private string corCasco;

        public string getCorCasco()
        {
            return corCasco;
        }

        public void setCorCasco(string corCasco)
        {
            this.corCasco = corCasco;
        }

        public string ancorar()
        {
            return "Embarcação parada";
        }

        public string descricao()
        {
            return "Embarcação: " + marca;
        }
    }
}
