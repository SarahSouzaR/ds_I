using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Caiaque : Embarcacao
    {
        public override string locomover()
        {
            return "Locomoção: a remo";
        }

        public override string abastecer()
        {
            return "Velocidade de locomoção: depende da força do remador";
        }

    }
}
