using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {


            

            Console.WriteLine("Qual tipo de aminal você deseja?");
            Console.WriteLine("Vertebrado ou Imvertebrado");
            
            string resposta = Console.ReadLine();


            if (resposta == "Vertebrado")
            {
                Vertebrado vert = new Vertebrado();
                vert.Escolha();
            }
            else if (resposta == "Invertebrado")
            {
                Invertebrado invert = new Invertebrado();
                invert.Escolha();
            }


        }


    }
}
