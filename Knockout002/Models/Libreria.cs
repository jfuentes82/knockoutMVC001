using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Knockout002.Models
{
    public class Libreria
    {
        private readonly List<Libro> books = new List<Libro>();
        private int nextId = 1;
        public string Name { get; set; }
        public Libreria()
        {
            Name = "My home library";
            AddBook(new Libro
            {
                Titulo = "Oliver Twist",
                Autor = "Charles Dickens",
                Año = 1837
            });
            AddBook(new Libro
            {
                Titulo = "Winnie-the-Pooh",
                Autor = "A. A. Milne",
                Año = 1926
            });
            AddBook(new Libro
            {
                Titulo = "The Hobbit",
                Autor = "JR.R.Tolkien",
                Año = 1937
            });
            AddBook(new Libro
            {
                Titulo = "The Bicentennial Man",
                Autor = "Isaac Asimov",
                Año = 1976
            });
            AddBook(new Libro
            {
                Titulo = "The Green Mile",
                Autor =
              "Stephen King",
                Año = 1996
            });
        }
        public IEnumerable<Libro> GetBooks()
        {
            return books;
        }
        public Libro GetBook(int id)
        {
            return books.Find(b => b.ID == id);
        }
        public void AddBook(Libro book)
        {
            book.ID = nextId++;
            books.Add(book);
        }
        public bool UpdateBook(Libro book)
        {
            var index = books.FindIndex(b => b.ID == book.ID);
            if (index == -1)
                return false;
            books.RemoveAt(index);
            books.Insert(index, book);
            return true;
        }
        public void RemoveBook(int id)
        {
            books.RemoveAll(b => b.ID == id);

        }
    }
}