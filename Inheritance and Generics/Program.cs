using Patterns_2.Adapter;
namespace Inheritance_and_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClientPart client = new ClientPart();
            ClientPart.Main(args);
        }
    }
}
