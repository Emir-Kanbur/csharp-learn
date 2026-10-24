using System;

public class Book
{
    private string title = "";

    public string ISBN { get; }

    public string Title
    {
        get { return title; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Kitap basligi bos olamaz.");
            }

            title = value.Trim();
        }
    }

    public Author Author { get; }

    public bool IsBorrowed { get; private set; }

    public static int CreatedCount { get; private set; }

    public Book(string isbn, string title, Author author)
    {
        if (string.IsNullOrWhiteSpace(isbn))
        {
            throw new ArgumentException("ISBN bos olamaz.");
        }

        if (author == null)
        {
            throw new ArgumentException("Yazar bilgisi bos olamaz.");
        }

        ISBN = isbn.Trim();
        Title = title;
        Author = author;
        IsBorrowed = false;

        CreatedCount++;
    }

    public bool Borrow()
    {
        if (IsBorrowed == true)
        {
            return false;
        }

        IsBorrowed = true;
        return true;
    }

    public bool ReturnBook()
    {
        if (IsBorrowed == false)
        {
            return false;
        }

        IsBorrowed = false;
        return true;
    }
}