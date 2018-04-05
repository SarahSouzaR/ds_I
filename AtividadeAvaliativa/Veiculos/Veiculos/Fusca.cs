using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Fusca : Carro
    {
        public override string locomover()
        {
            return "Locomoção: tração 2 rodas";
        }

        public override string abastecer()
        {
            return "Abastecimento: Gasolina";
        }

    }
}
