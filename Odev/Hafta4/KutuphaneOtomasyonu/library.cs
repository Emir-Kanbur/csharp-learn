using System;
using System.Collections.Generic;

public class Library
{
    private readonly List<Book> books = new List<Book>();

    public int TotalBooks
    {
        get { return books.Count; }
    }

    public int AvailableBooks
    {
        get
        {
            int count = 0;

            foreach (Book book in books)
            {
                if (book.IsBorrowed == false)
                {
                    count++;
                }
            }

            return count;
        }
    }

    public bool AddBook(Book book)
    {
        if (FindBook(book.ISBN) != null)
        {
            return false;
        }

        books.Add(book);
        return true;
    }

    public Book? FindBook(string isbn)
    {
        foreach (Book book in books)
        {
            if (book.ISBN == isbn.Trim())
            {
                return book;
            }
        }

        return null;
    }

    public string BorrowBook(string isbn)
    {
        Book? book = FindBook(isbn);

        if (book == null)
        {
            return "Kitap bulunamadi.";
        }

        if (book.Borrow() == false)
        {
            return "Kitap zaten odunc alinmis.";
        }

        return "Kitap basariyla odunc alindi.";
    }

    public string ReturnBook(string isbn)
    {
        Book? book = FindBook(isbn);

        if (book == null)
        {
            return "Kitap bulunamadi.";
        }

        if (book.ReturnBook() == false)
        {
            return "Kitap zaten kutuphanede.";
        }

        return "Kitap basariyla iade edildi.";
    }

    public void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Kutuphane bos.");
            return;
        }

        foreach (Book book in books)
        {
            Console.WriteLine("ISBN: " + book.ISBN);
            Console.WriteLine("Baslik: " + book.Title);
            Console.WriteLine("Yazar: " + book.Author.Name);

            if (book.IsBorrowed == true)
            {
                Console.WriteLine("Durum: Oduncte");
            }
            else
            {
                Console.WriteLine("Durum: Musait");
            }

        }
    }
}
