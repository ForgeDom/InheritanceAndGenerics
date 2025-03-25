namespace Patterns_3.Iterator;

public interface ILibraryCollection
{
    IIterator<Book> CreateIterator();
    int Count { get; }
    Book this[int index] { get; set; }
}