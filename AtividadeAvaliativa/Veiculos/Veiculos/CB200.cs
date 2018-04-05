using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class CB200 : Motocicleta
    {
        public override string locomover()
        {
            return "Locomoção: tração roda traseira";
        }

        public override string abastecer()
        {
            return "Abastecimento: Álcool";
        }

    }
}
