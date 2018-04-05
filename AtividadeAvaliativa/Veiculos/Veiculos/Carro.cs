using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Carro : Veiculo
    {
        public string corCarro;

        public string getCorCarro()
        {
            return corCarro;
        }

        public void setCorCarro(string corCarro)
        {
            this.corCarro = corCarro;
        }

        public string descricao()
        {
            return "Marca do carro: " + marca + "\nCor: " + corCarro + "\nAno: " + ano + "\nQuantidade de pneus: " + pneu;
        }
    }
}
