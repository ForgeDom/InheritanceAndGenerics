using System;

namespace Patterns_2.Adapter
{
    public class ClientPart
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a figure form:");
                Console.WriteLine("1. Cubed");
                Console.WriteLine("2. Round");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                var figureChoice = Console.ReadLine();

                FigureForm selectedForm;
                switch (figureChoice)
                {
                    case "1":
                        selectedForm = FigureForm.Cubed;
                        break;
                    case "2":
                        selectedForm = FigureForm.Round;
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                CurrentFigureForm currentFigure = new CurrentFigureForm();
                IFormChanger adapter = new Adapter(currentFigure);

                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Convert to Round");
                    Console.WriteLine("2. Convert to Cubed");
                    Console.WriteLine("3. Apply Color");
                    Console.WriteLine("4. Back to figure selection");
                    Console.Write("Enter your choice: ");
                    var conversionChoice = Console.ReadLine();

                    switch (conversionChoice)
                    {
                        case "1":
                            Console.WriteLine(adapter.CubedToRound(selectedForm));
                            break;
                        case "2":
                            Console.WriteLine(adapter.RoundToCubed(selectedForm));
                            break;
                        case "3":
                            ApplyColor(selectedForm);
                            break;
                        case "4":
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            continue;
                    }

                    if (conversionChoice == "4")
                    {
                        break;
                    }

                    Console.WriteLine();
                }
            }
        }

        private static void ApplyColor(FigureForm form)
        {
            IColor color = new RedColor();
            IFigure figure;

            if (form == FigureForm.Cubed)
            {
                figure = new CubedFigure(color);
            }
            else
            {
                figure = new RoundFigure(color);
            }

            figure.ApplyColor();
        }
    }
}