using System;

public class Author
{
    private string name = "";

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Yazar adi bos olamaz.");
            }

            name = value.Trim();
        }
    }

    public string Country { get; set; }

    public Author(string name) : this(name, "Bilinmiyor")
    {
    }

    public Author(string name, string country)
    {
        Name = name;
        Country = country;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Yazar: " + Name + ", Ulke: " + Country);
    }
}