using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Veiculo
    {
        public string marca;
        public int ano;
        public int pneu;

        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public int getAno()
        {
            return ano;
        }

        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public int getPneu()
        {
            return pneu;
        }

        public void setPneu(int pneu)
        {
            this.pneu = pneu;
        }

        public virtual string locomover()
        {
            return "se locomove";
        }

        public virtual string abastecer()
        {
            return "abastece com";
        }

    }
}
