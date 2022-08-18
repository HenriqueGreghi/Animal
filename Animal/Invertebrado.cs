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
            Console.WriteLine("Anelideo ou Inseto ");
         

            string resposta = Console.ReadLine();
            if (resposta == "Inseto" )
            {
                Anelideo();
            }
            else if (resposta == "Anelideo")
            {
                Inseto();
            }
        }


        public void Inseto()
        {
            Console.WriteLine("Hematofago ou  Herbivoro");

            string resp = Console.ReadLine();

            if (resp == "Hematofago")
            {
                Console.WriteLine("Pulga");
            }
            else if (resp == "Herbivoro")
            {

                Console.WriteLine("Lagarta");
            }
        }
        public void Anelideo()
        {
            Console.WriteLine("Hematofago ou  Onivoro");

            string resp = Console.ReadLine();

            if (resp == "Hematofago")
            {
                Console.WriteLine("Sanguessuga");
            }
            else if (resp == "Onivoro")
            {

                Console.WriteLine("Minhoca");
            }
        }

    }
}
