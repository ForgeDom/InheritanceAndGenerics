namespace Patterns_3.Command;

public class ClientPart
{
    public void Main(string[] args)
    {
        var helpCommand = new Commands.HelpCommand();
        var deleteCommand = new Commands.DeleteSystem32Command();
        Console.WriteLine(helpCommand.Execute("Maks"));
        Console.WriteLine(deleteCommand.Execute("Maks"));
    }
}