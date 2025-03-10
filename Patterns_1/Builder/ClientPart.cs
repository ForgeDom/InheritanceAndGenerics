namespace Patterns_1.Builder;

public class ClientPart
{
    public static void Main(string[] args)
    {
        var builder = new ComputerBuilder();
        var director = new Director(builder);
        
        Console.WriteLine("Building minimal configuration:");
        director.BuildMinimalPc();
        Console.WriteLine("Minimal configuration built:");
        builder.Product.ShowParts();
        
        Console.WriteLine("");
        
        Console.WriteLine("Building gaming configuration:");
        director.BuildGamingPc();
        Console.WriteLine("Gaming configuration built:");
        builder.Product.ShowParts();
        
        Console.WriteLine("");
        
        Console.WriteLine("Destroying minimal configuration:");
        director.DestroyMinimalPc();
        Console.WriteLine("Minimal configuration destroyed:");
        builder.Product.ShowParts();
        
        Console.WriteLine("");
        
        Console.WriteLine("Destroying gaming configuration:");
        director.DestroyGamingPc();
        Console.WriteLine("Gaming configuration destroyed:");
        builder.Product.ShowParts();
    }
}