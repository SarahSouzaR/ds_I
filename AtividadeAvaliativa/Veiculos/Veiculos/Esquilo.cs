using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Esquilo : Aeronave
    {
        public override string locomover()
        {
            return "Locomoção: por Hélice";
        }

        public override string abastecer()
        {
            return "Abastecimento: Diesel";
        }

    }
}
