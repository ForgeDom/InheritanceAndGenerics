namespace Patterns_3.Iterator;

public class Library : ILibraryCollection
{
    private readonly List<Book> _books = new List<Book>();

    public void AddBook(Book book) => _books.Add(book);

    public IIterator<Book> CreateIterator() => new LibraryIterator(this);

    public int Count => _books.Count;
        
    public Book this[int index]
    {
        get => _books[index];
        set => _books[index] = value;
    }
}