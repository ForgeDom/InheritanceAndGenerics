using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.AbstractFactory
{
    public class ClientPart
    {
        public void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose a furniture factory:");
                Console.WriteLine("1. Modern Furniture Factory");
                Console.WriteLine("2. Victorian Furniture Factory");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        var modernFurnitureFactory = new ModernFurnitureFactory();
                        Console.WriteLine("App: Launched with the ModernFurnitureFactory.");
                        ClientMethod(modernFurnitureFactory);
                        break;
                    case "2":
                        var victorianFurnitureFactory = new VictorianFurnitureFactory();
                        Console.WriteLine("App: Launched with the VictorianFurnitureFactory.");
                        ClientMethod(victorianFurnitureFactory);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        public void ClientMethod(AbstrtactFactory factory)
        {
            var chair = factory.CreateChair();
            var sofa = factory.CreateSofa();
            var coffeeTable = factory.CreateCoffeeTable();
            Console.WriteLine(chair.HasLegs());
            Console.WriteLine(chair.SitOn());
            Console.WriteLine(chair.Color());
            Console.WriteLine(sofa.HasLegs());
            Console.WriteLine(sofa.LayOn());
            Console.WriteLine(sofa.Color());
            Console.WriteLine(coffeeTable.HasLegs());
            Console.WriteLine(coffeeTable.PutOn());
            Console.WriteLine(coffeeTable.Color());
        }
    }
}
