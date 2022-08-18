using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Vertebrado
    {
        public string Animal;
        public string Carnivoro;
        public string Onivoro;
        public string Herbivoro;
        public string Escolher;
        public string Passaro;
        private string ave;
        private string mamifero;
        public  Vertebrado(string animal, string carnivoro, string onivoro, string herbivoro)
        {
            Animal = animal;
            Carnivoro = carnivoro;
            Onivoro = onivoro;
            Herbivoro = herbivoro;
            
           
        }

        public Vertebrado()
        {
        }

        public void Escolha()
        {
            Console.WriteLine("Mamifero ou Ave?");
            string Escolher = Console.ReadLine();

            if (Escolher == ave)
            {
                Ave();
            }
            else if (Escolher == mamifero)
            {
                Mamifero();
            }
        }

        public void Ave()
        {
            if (Animal == Carnivoro)
            {
                Console.WriteLine(  "Aguia" );
            }
            else if (Animal == Onivoro)
            {

                Console.WriteLine("Pomba");
            }
        }
        public void Mamifero()
        {
            if (Animal == Herbivoro)
            {
                Console.WriteLine("Vaca");
            }
            else if (Animal == Onivoro)
            {

                Console.WriteLine("Homem");
            }
        }

    }
}
