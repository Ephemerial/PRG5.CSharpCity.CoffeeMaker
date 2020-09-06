using PRG5.CSharpCity.CoffeeMaker.Domain;
using System;

namespace PRG5.CSharpCity.CoffeeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var koffieMaker = new JuraBrew();
            koffieMaker.SoortKoffie = BrewType.Cappucino;

            var commandkey = Console.ReadLine();
            while (!commandkey.Equals("X"))
            {
                switch (commandkey)
                {
                    case "1":
                        koffieMaker.SoortKoffie = BrewType.Koffie;
                        Console.WriteLine(koffieMaker.Brew());
                        break;
                    case "2":
                        koffieMaker.SoortKoffie = BrewType.Espresso;
                        Console.WriteLine(koffieMaker.Brew());
                        break;
                    case "3":
                        koffieMaker.SoortKoffie = BrewType.Cappucino;
                        Console.WriteLine(koffieMaker.Brew());
                        break;
                    case "4": 
                        koffieMaker.SoortKoffie = BrewType.Ristretto;
                        Console.WriteLine(koffieMaker.Brew());
                        break;
                    case "O":
                        koffieMaker.Ontkalken();
                        Console.WriteLine($"Aantal bakjes staat weer op {koffieMaker.AantalBakjes}");
                        break;
                    default:
                        koffieMaker.SoortKoffie = BrewType.Koffie;
                        Console.WriteLine($"Onbekende keuze, u krijgt nu {koffieMaker.SoortKoffie}");
                        Console.WriteLine(koffieMaker.Brew());
                        break;
                }
                
                commandkey = Console.ReadLine();
            }
            foreach (BrewType bakje in koffieMaker.BakjesLijst)
            {
                Console.WriteLine(bakje);
            }
            Console.ReadLine();
        }
    }
}
