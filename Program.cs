// See https://aka.ms/new-console-template for more information


using System;

namespace csharp_agenzia // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenzia Tecnocasa = new Agenzia("Tecnocasa");

            Appartamento appartamento1 = new Appartamento(5, 3, "ID1256", "Via belino 12", "20045", "Carbonia", 78);
            Villa villa1 = new Villa(30, 4, 2, "50JHFG", "Via maroni 13", "00045", "Nettuno", 10);
            Box box1 = new Box(2, "ID1244", "Via carli 42", "00025", "Saturnia", 100);

            Tecnocasa.AddImmobile(appartamento1);
            Tecnocasa.AddImmobile(villa1);
            Tecnocasa.AddImmobile(box1);

            List<Immobile> list = Tecnocasa.SearchImmobili("");

            foreach (Immobile i in list)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("-------------------------------------------");
            }
            Console.WriteLine("---End---");
        }
    }
}
