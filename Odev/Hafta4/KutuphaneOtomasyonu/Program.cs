
using System;

Library library = new Library();

// Yazarları oluşturuyorum.
Author author1 = new Author("Sabahattin Ali", "Turkiye");
Author author2 = new Author("Yasar Kemal", "Turkiye");

// Başlangıç kitaplarını ekliyorum.
library.AddBook(new Book("1001", "Kurk Mantolu Madonna", author1));
library.AddBook(new Book("1002", "Kuyucakli Yusuf", author1));
library.AddBook(new Book("1003", "Ince Memed", author2));

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine(" KUTUPHANE OTOMASYONU ");
    Console.WriteLine("1 - Kitaplari Listele");
    Console.WriteLine("2 - ISBN ile Kitap Ara");
    Console.WriteLine("3 - Kitap Odunc Al");
    Console.WriteLine("4 - Kitap Iade Et");
    Console.WriteLine("5 - Yeni Kitap Ekle");
    Console.WriteLine("6 - Kitap Sayilarini Goster");
    Console.WriteLine("7 - Cikis");
    Console.Write("Seciminiz: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            library.ListBooks();
            break;

        case "2":
            {
                Console.Write("ISBN giriniz: ");
                string isbn = Console.ReadLine() ?? "";

                Book? book = library.FindBook(isbn);

                if (book == null)
                {
                    Console.WriteLine("Kitap bulunamadi.");
                }
                else
                {
                    Console.WriteLine("ISBN: " + book.ISBN);
                    Console.WriteLine("Baslik: " + book.Title);
                    Console.WriteLine("Yazar: " + book.Author.Name);

                    if (book.IsBorrowed)
                    {
                        Console.WriteLine("Durum: Oduncte");
                    }
                    else
                    {
                        Console.WriteLine("Durum: Musait");
                    }
                }
                break;
            }

        case "3":
            {
                Console.Write("Odunc alinacak ISBN: ");
                string isbn = Console.ReadLine() ?? "";

                Console.WriteLine(library.BorrowBook(isbn));
                break;
            }

        case "4":
            {
                Console.Write("Iade edilecek ISBN: ");
                string isbn = Console.ReadLine() ?? "";

                Console.WriteLine(library.ReturnBook(isbn));
                break;
            }

        case "5":
            {
                try
                {
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine() ?? "";

                    if (library.FindBook(isbn) != null)
                    {
                        Console.WriteLine("Bu ISBN zaten kayitli.");
                        break;
                    }

                    Console.Write("Kitap basligi: ");
                    string title = Console.ReadLine() ?? "";

                    Console.Write("Yazar adi: ");
                    string authorName = Console.ReadLine() ?? "";

                    Console.Write("Yazar ulkesi: ");
                    string country = Console.ReadLine() ?? "";

                    Author newAuthor;

                    if (string.IsNullOrWhiteSpace(country))
                    {
                        newAuthor = new Author(authorName);
                    }
                    else
                    {
                        newAuthor = new Author(authorName, country);
                    }

                    Book newBook = new Book(isbn, title, newAuthor);

                    if (library.AddBook(newBook))
                    {
                        Console.WriteLine("Kitap basariyla eklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Bu ISBN zaten kayitli.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }

                break;
            }

        case "6":
            Console.WriteLine("Toplam kitap: " + library.TotalBooks);
            Console.WriteLine("Odunc verilebilir: " + library.AvailableBooks);
            Console.WriteLine("Olusturulan kitap: " + Book.CreatedCount);
            break;

        case "7":
            Console.WriteLine("Program kapatiliyor...");
            running = false;
            break;

        default:
            Console.WriteLine("Gecersiz secim yaptiniz.");
            break;
    }
}
