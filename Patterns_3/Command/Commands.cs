namespace Patterns_3.Command;

public class Commands
{
    public class HelpCommand : ICommand<string, string>
    {
        public string Execute(string name)
        {
            return $"HelpCommand: Executing Help Command for {name}.";
        }
    }
    public class DeleteSystem32Command : ICommand<string, string>
    {
        public string Execute(string name)
        {
            return $"System32Command: Executing System32 Command for {name}.";
        }
    }
}