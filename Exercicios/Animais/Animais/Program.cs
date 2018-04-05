using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Mamifero animal2 = new Mamifero();
            Reptil animal3 = new Reptil();
            Aves animal4 = new Aves();

            animal1.setPeso(25f);
            animal1.setIdade(5);
            animal1.setMembros(4);
            animal2.setCorPelo("Marrom");
            animal2.setRaca("Labrador");
            animal2.setPeso(20f);
            animal2.setIdade(2);
            animal2.setMembros(4);
            animal3.setCorEscama("Verde");
            animal4.setCorPena("Azul");
            animal4.setIdade(7);
            
            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(animal4.ToString());

            Console.ReadKey();

        }
    }
}
