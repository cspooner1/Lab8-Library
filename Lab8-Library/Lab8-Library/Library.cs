﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8_Library;

namespace Lab8_Library;

public class Library : ILibrary
{
    private Dictionary<string, Book> Storage { get; set; }


    public int Count { get; set; }

    public Library()
    {
        Storage = new Dictionary<string, Book>();
        Book Book1 = new Book("Baki", "Keisuke Itagaki");
        Book Book2 = new Book("Bastard!", "Kazushi Hagiwara");
        Book Book3 = new Book("Misfit of Demon King Academy", "Shu");
        Storage.Add(Book1.Title, Book1);
        Storage.Add(Book2.Title, Book2);
        Storage.Add(Book3.Title, Book3);
    }

    public void Add(string title, string author)
    {
        Book newBook = new Book(title, author);

        Storage.Add(newBook.Title, newBook);
        var result = Storage.Keys;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        var result = Storage.Values;
        foreach (Book book in result)
        {
            yield return book;
        }
    }

    public Book Borrow(string title)
    {
        Book returnedBook = Storage.GetValueOrDefault(title);

        return returnedBook;
    }
    public void Return(Book book)
    {
        Storage.Add(book.Title, book);
    }

    public Book Search(string title)

    {
        bool result = Storage.ContainsKey(title);
        if (result == true)
        {
            return Storage[title];
        }
        return null;
    }

    public void ViewAllBooks()
    {
        var keys = Storage.Keys;
        for (int i = 0; i < keys.Count; i++)
        {
            string key = keys.ElementAt(i);
            Console.WriteLine(key);

        }

    }
}
