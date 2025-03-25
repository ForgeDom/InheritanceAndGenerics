namespace Patterns_3.Iterator;

public class ClientPart
{
    public void Main(string[] args)
    {
        var library = new Library();
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
        library.AddBook(new Book("1984", "George Orwell", 1949));

        var iterator = library.CreateIterator();

        Console.WriteLine("Books in library:");
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}