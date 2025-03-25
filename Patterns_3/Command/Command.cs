namespace Patterns_3.Command;

public interface ICommand<TReturn,TGetArgs>
{
    TReturn Execute(TGetArgs source);
}