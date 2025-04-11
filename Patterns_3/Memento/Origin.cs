namespace Patterns_3.Memento;

public class Origin
{
    private string _state;

    public string State
    {
        get => _state;
        set
        {
            _state = value;
            Console.WriteLine($"Поточний стан: {_state}");
        }
    }

    public Memento SaveState()
    {
        Console.WriteLine($"Збережено знімок стану: {_state}");
        return new Memento(_state);
    }

    public void RestoreState(Memento memento)
    {
        _state = memento.State;
        Console.WriteLine($"Відновлено стан: {_state}");
    }
}