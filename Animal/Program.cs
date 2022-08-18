using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {


            string vertebrado;
            string invertebrado;

            Console.WriteLine("Qual tipo de aminal você deseja?");
            Console.WriteLine("Vertebrado  ");
            Console.WriteLine("Imvertebrado");
            string resposta = Console.ReadLine().ToLower();


            if (resposta == vertebrado)
            {
                Vertebrado vert = new Vertebrado();
                vert.Escolha();
            }
            else if (resposta == invertebrado)
            {
                Invertebrado invert = new Invertebrado();
                invert.Escolha();
            }


        }


    }
}
