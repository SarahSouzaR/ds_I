using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Fusca v1 = new Fusca();
            PicapeS10 v2 = new PicapeS10();
            CB200 v3 = new CB200();
            Caiaque v4 = new Caiaque();
            Esquilo v5 = new Esquilo();
            Legacy450 v6 = new Legacy450();


            Console.WriteLine("Exemplos de definição dos atributos + métodos: \n");

            v1.setAno(1960);
            v1.setCorCarro("Azul");
            v1.setMarca("Fusca");
            v1.setPneu(4);

            Console.WriteLine(v1.descricao());
            Console.WriteLine(v1.locomover());
            Console.WriteLine(v1.abastecer());

            v2.setAno(1980);
            v2.setCorCarro("Vermelho");
            v2.setMarca("PicapeS10");
            v2.setPneu(4);

            Console.WriteLine("\n");

            Console.WriteLine(v2.descricao());
            Console.WriteLine(v2.locomover());
            Console.WriteLine(v2.abastecer());

            Console.WriteLine("\n");

            v3.setMarca("CB200");

            Console.WriteLine(v3.descricao());
            Console.WriteLine(v3.locomover());
            Console.WriteLine(v3.abastecer());

            Console.WriteLine("\n");

            v4.setMarca("Caiaque");

            Console.WriteLine(v4.descricao());
            Console.WriteLine(v4.locomover());
            Console.WriteLine(v4.abastecer());

            Console.WriteLine("\n");

            v5.setMarca("Esquilo");

            Console.WriteLine(v5.descricao());
            Console.WriteLine(v5.locomover());
            Console.WriteLine(v5.abastecer());

            Console.WriteLine("\n");

            v6.setMarca("Legacy450");

            Console.WriteLine(v6.descricao());
            Console.WriteLine(v6.locomover());
            Console.WriteLine(v6.abastecer());
            Console.WriteLine("\n");
            Console.WriteLine(v6.decolar(16));
            Console.WriteLine("\n");
            Console.WriteLine(v6.decolar(false));
            Console.WriteLine("\n");
            Console.WriteLine(v6.decolar("sol"));
    
            Console.ReadKey();
        }
    }
}
