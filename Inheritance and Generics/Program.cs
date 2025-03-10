using Patterns_1.Singleton;

namespace Inheritance_and_Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClientPart client = new ClientPart();
            ClientPart.Main(args);
        }
    }
}