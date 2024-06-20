﻿namespace DesignPatterns.ObjectRelations.Aggregation;

internal class AggregationExample2
{
    public void Run()
    {
        var book1 = new Book("The Alchemist", "Paulo Coelho");
        var book2 = new Book("The Da Vinci Code", "Dan Brown");
        var book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        var library = new Library("Public Library");
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.DisplayLibraryInfo();
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
