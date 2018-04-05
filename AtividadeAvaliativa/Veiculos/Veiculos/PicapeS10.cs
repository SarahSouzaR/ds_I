using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class PicapeS10 : Carro
    {
        public override string locomover()
        {
            return "Locomoção: tração 4 rodas";
        }

        public override string abastecer()
        {
            return "Abastecimento: Diesel";
        }

    }
}
