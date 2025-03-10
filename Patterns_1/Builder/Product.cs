namespace Patterns_1.Builder;

public interface IProduct<T>
{
    void AddPart(T part);
    void RemovePart(T part);
    void ShowParts();
}

public class Product<T> : IProduct<T>
{
    protected List<T> _parts = new List<T>();

    public virtual void AddPart(T part)
    {
        _parts.Add(part);
    }

    public virtual void RemovePart(T part)
    {
        _parts.Remove(part);
    }

    public virtual void ShowParts()
    {
        Console.WriteLine("Product parts:");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}

public class Computer : Product<string>
{
    public override void ShowParts()
    {
        Console.WriteLine("Computer parts:");
        foreach (var part in _parts)
        {
            Console.WriteLine(part);
        }
    }
}