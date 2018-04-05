using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Legacy450 : Aeronave
    {
        public override string locomover()
        {
            return "Locomoção: por Turbina";
        }

        public override string abastecer()
        {
            return "Abastecimento: Querosene";
        }

        public string decolar(string clima)
        {
            if (clima == "sol")
            {
                return "Voo normal";
            }

            if (clima == "chuva" && clima == "nublado")
            {
                return "Voo por instrumento";
            }

            else
            {
                return "Sem voo";
            }
        }

        public int decolar(int horario)
        {
            if (horario >= 1 && horario <= 12)
            {
                Console.WriteLine("Período da manhã - altitude mais alta");
            }

            if (horario > 12 && horario <= 18)
            {
                Console.WriteLine("Período da tarde - altitude média");
            }

            else
            {
                Console.WriteLine("Período da noite - altitude baixa");
            }
            return horario;
        }

        public Boolean decolar(Boolean passageiro)
        {
            if (passageiro == true)
            {
                Console.WriteLine("Servir refeição");
            }

            else
            {
                Console.WriteLine("Amarrar bem a carga");
            }
            return passageiro;
        }
    }
}
