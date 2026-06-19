using System;
using System.Collections.Generic;

class Book
{
    public string Name;
    public string Author;
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();

        while (true)
        {
            Console.WriteLine("1- Add Book  2- Show  3- Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Book b = new Book();

                Console.Write("Name: ");
                b.Name = Console.ReadLine();

                Console.Write("Author: ");
                b.Author = Console.ReadLine();

                books.Add(b);
            }
            else if (choice == "2")
            {
                foreach (var b in books)
                    Console.WriteLine($"{b.Name} - {b.Author}");
            }
            else break;
        }
    }
}
