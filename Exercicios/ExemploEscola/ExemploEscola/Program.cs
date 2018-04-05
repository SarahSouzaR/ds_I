using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Aluno pessoa2 = new Aluno();
            Professor pessoa3 = new Professor();
            Funcionario pessoa4 = new Funcionario();
            Professor pessoa5 = new Professor();

            pessoa1.setNome("Luis");
            pessoa1.setIdade(30);
            pessoa2.setNome("Maria");
            pessoa2.setCurso("TI");
            pessoa3.setNome("Luisa");
            pessoa3.setSalario(3000.50f);
            pessoa4.setNome("João");
            pessoa4.setSexo("Masculino");
            pessoa4.setTrabalhando(false);
            pessoa5.setNome("Caio");
            pessoa5.setIdade(35);
            pessoa5.setSexo("Masculino");
            pessoa5.setEspecialidade("Word");
            pessoa5.setSalario(2500.68f);

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine(pessoa3.ToString());
            Console.WriteLine(pessoa4.ToString());
            Console.WriteLine(pessoa5.ToString());

            Console.ReadKey();

        }
    }
}
