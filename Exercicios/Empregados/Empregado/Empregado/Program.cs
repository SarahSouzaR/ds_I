using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empregado
{
    class Program
    {
        static void Main(string[] args)
        {
            Assalariado pessoa1 = new Assalariado();
            Comissionado pessoa2 = new Comissionado();
            Horista pessoa3 = new Horista();
            TipoEmpregado pessoa4 = new TipoEmpregado();

            pessoa1.setNome("Vitoria");
            pessoa1.setSobrenome("Andrade");
            pessoa1.setCpf("456.789.132-11");
            pessoa1.setSalario(1500.00);
            pessoa2.setNome("Joao");
            pessoa2.setSobrenome("Alves");
            pessoa2.setTaxaComissao(0.10);
            pessoa2.setTotalVenda(2000.00);
            pessoa3.setNome("Julia");
            pessoa3.setSobrenome("Cabral");
            pessoa3.setHorasTrabalhadas(98);
            pessoa3.setPrecoHora(30.00);
            pessoa4.setSalario(1700);
            pessoa4.setNome("Ana");

            Console.Write(pessoa1.vencimento());
            Console.WriteLine(pessoa1.complemento());
            Console.Write(pessoa2.vencimento());
            Console.WriteLine(pessoa2.complemento());
            Console.Write(pessoa3.vencimento());
            Console.WriteLine(pessoa3.complemento());
            Console.Write(pessoa4.vencimento());
            Console.WriteLine(pessoa4.complemento());
           

            Console.ReadKey();
        }
    }
}
