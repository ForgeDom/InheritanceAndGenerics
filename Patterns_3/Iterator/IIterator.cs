namespace Patterns_3.Iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
