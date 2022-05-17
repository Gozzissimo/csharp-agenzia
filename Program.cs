// See https://aka.ms/new-console-template for more information


using System;

namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenzia Tecnocasa = new Agenzia("Tecnocasa");

            Immobile immobile1 = new Immobile("ID1256", "Via belino 12", "20045", "Carbonia", 78);
            Console.WriteLine(immobile1.ToString());

            Tecnocasa.AddImmobile(immobile1);

            //Box box1 = new Box(2, "ID1244", "Via carli 42", "00025", "Saturnia", 100);
            //Console.WriteLine(box1.ToString());

            //Appartamento app1 = new Appartamento(5, 2, "ID1244", "Via carli 42", "00025", "Saturnia", 100);
            //Console.WriteLine(app1.ToString());

            //Villa villa1 = new Villa(100, 6, 1, "ID1244", "Via carli 42", "00025", "Saturnia", 120);
            //Console.WriteLine(villa1.ToString());
        }
    }
}
