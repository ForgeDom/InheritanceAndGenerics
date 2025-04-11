using System.Collections;

namespace Patterns_3.Memento;

public class History
{
    private readonly Stack<Memento> _history = new Stack<Memento>();

    public void AddMemento(Memento memento)
    {
        _history.Push(memento);
    }

    public Memento GetLastMemento()
    {
        if (_history.Count == 0)
        {
            throw new InvalidOperationException("Немає доступних знімків стану для відновлення");
        }
        return _history.Pop();
    }
}