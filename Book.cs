using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Year})";
    }
}

class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Library Books:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        // Adding books to the library
        library.AddBook(new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951 });
        library.AddBook(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 });
        library.AddBook(new Book { Title = "1984", Author = "George Orwell", Year = 1949 });

        // Displaying the books in the library
        library.DisplayBooks();
    }
}
