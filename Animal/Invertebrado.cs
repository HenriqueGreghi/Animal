using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Invertebrado
    {
        public string Animal;
        public string Hematofago;
        public string Onivoro;
        public string Herbivoro;
        


        public Invertebrado(string animal, string hematofago, string onivoro, string herbivoro)
        {
            Animal = animal;
            Hematofago = hematofago;
            Onivoro = onivoro;
            Herbivoro = herbivoro;
            
           

        }

        public Invertebrado()
        {
        }
        public void Escolha()
        {
            Console.WriteLine("Anelideo = 1");
            Console.WriteLine("Inseto = 2");

            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1 )
            {
                Anelideo();
            }
            else if (resposta == 2)
            {
                Inseto();
            }
        }


        public void Inseto()
        {
            Console.WriteLine("Hematofago ou  Herbivoro");

            string resp = Console.ReadLine();

            if (resp == Hematofago)
            {
                Console.WriteLine("Pulga");
            }
            else if (resp == Herbivoro)
            {

                Console.WriteLine("Lagarta");
            }
        }
        public void Anelideo()
        {
            Console.WriteLine("Hematofago ou  Onivoro");

            string resp = Console.ReadLine();

            if (resp == Hematofago)
            {
                Console.WriteLine("Sanguessuga");
            }
            else if (resp == Onivoro)
            {

                Console.WriteLine("Minhoca");
            }
        }

    }
}
