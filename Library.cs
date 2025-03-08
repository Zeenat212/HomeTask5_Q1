using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects_5_Q1
{
    internal class Library
    {
        private Book[] books;
        private int bookcount;
        public Library()
        {
            books = new Book[100];
            bookcount = 0;
        }
        public void AddBook(Book book1)
        {
            books[bookcount] = book1;
            bookcount++;
            Console.WriteLine("Book Added Successfully");
        }
        public void ListAllBooks()
        {
            Console.WriteLine("List of All Books");
            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("Title: " + books[i].Title);
                Console.WriteLine("Author: " + books[i].Author);
                Console.WriteLine("Genre: " + books[i].Genre);
                Console.WriteLine("PublicationYears: " + books[i].PublicationYears);
                Console.WriteLine("**********************************************");
            } 
        }
         public void SearchBook(string keyword)
        {
            Console.WriteLine($"Search Values for the keyword = {keyword}");
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i].Title == keyword || books[i].Author== keyword || books[i].Genre == keyword)
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("Title: " + books[i].Title);
                    Console.WriteLine("Author: " + books[i].Author);
                    Console.WriteLine("Genre: " + books[i].Genre);
                    Console.WriteLine("PublicationYears: " + books[i].PublicationYears);
                    Console.WriteLine("**********************************************");
                }
            }
        }
       }
    }

