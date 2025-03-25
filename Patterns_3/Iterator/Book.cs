namespace Patterns_3.Iterator;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString() => $"{Title} by {Author} ({Year})";
}

public class LibraryIterator : IIterator<Book>
{
    private readonly ILibraryCollection _library;
    private int _current = 0;

    public LibraryIterator(ILibraryCollection library)
    {
        _library = library;
    }

    public bool HasNext() => _current < _library.Count;

    public Book Next()
    {
        if (!HasNext())
            throw new InvalidOperationException("No more books in collection");
        return _library[_current++];
    }
}
