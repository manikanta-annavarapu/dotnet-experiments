namespace DesignPatterns.ObjectRelations.Aggregation;

internal class AggregationExample2 : Separator
{
    public new void Run()
    {
        var book1 = new Book("The Alchemist", "Paulo Coelho"); // Component object
        var book2 = new Book("The Da Vinci Code", "Dan Brown"); // Component object
        var book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald"); // Component object
        var library = new Library("Public Library"); // Container object
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.DisplayLibraryInfo();
        base.Run();
    }
}


internal class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Book: {Title} by {Author}");
    }
}

internal class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }

    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book) {
        Books.Remove(book);
    }

    public List<Book> GetBooks() {
        return Books;
    }

    public void DisplayLibraryInfo()
    {
        Console.WriteLine($"Library: {Name}");
        foreach (var book in Books)
        {
            book.DisplayBookInfo();
        }
    }
}
