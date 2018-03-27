using System;
using System.Collections.Generic;

namespace Aulas1617.EqualsandGetHashCode
{

    public sealed class Book
    {
        private readonly string isbn;

        public string Isbn
        {
            get
            {
                return isbn;
            }
        }

        public Book(string isbn)
        {
            this.isbn = isbn;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (Object.ReferenceEquals(this, obj))
                return true;

            Book book = obj as Book;
            if (book != null)
                return isbn.Equals(book.Isbn);    
            else
                return false;
        }

        public override int GetHashCode() {
            // 1. Not a good implementation: Equal but distinct objects have different addresses (hash codes)
            return base.GetHashCode();
            // 2. Return imutable and unique id, ISBN hash code 
            //return Isbn.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[Book: Isbn = {0}, HashCode = {1}]", Isbn, GetHashCode());
        }

    }

    public class HashCode
    {
        public static void Main()
        {
            // Consider this code that tests two instances of the Book class for equality:
            // Swing Tutorial, 2nd edition

            // 1. Equal but distinct objects have different addresses (hash codes)
            Book book1 = new Book("0201914670");
            Book book2 = new Book("0201914670");
            Console.WriteLine("firstBook = " + book1);
            Console.WriteLine("secondBook = " + book2);

            if (book1.Equals(book2))
            {
                Console.WriteLine("objects are equal");
            }
            else
            {
                Console.WriteLine("objects are not equal");
            }
            HashSet<Book> hashSet = new HashSet<Book>();

            hashSet.Add(book1);
            hashSet.Add(book2);

            // Results
            Console.WriteLine("hashSet.Contains(book1): {0}", hashSet.Contains(book1));
            Console.WriteLine("hashSet.Remove(book1) -> {0}", hashSet.Remove(book1));
            Console.WriteLine("hashSet.Contains(book1): {0}", hashSet.Contains(book1));
            Console.WriteLine("hashSet.Contains(book2): {0}", hashSet.Contains(book2));
        }
    }
}

// Results
// 1.
//firstBook = [Book: Isbn = 0201914670, HashCode = 466873243]
//secondBook = [Book: Isbn = 0201914670, HashCode = -159754066]
//objects are equal
//hashSet.Contains(book1): True
//hashSet.Remove(book1) -> True
//hashSet.Contains(book1): False
//hashSet.Contains(book2): True    // PROBLEM: book with this ISBN was already removed from the hashset

// 2.
//firstBook = [Book: Isbn = 0201914670, HashCode = 1441600692]
//secondBook = [Book: Isbn = 0201914670, HashCode = 1441600692]
//objects are equal
//hashSet.Contains(book1): True
//hashSet.Remove(book1) -> True
//hashSet.Contains(book1): False
//hashSet.Contains(book2): False
