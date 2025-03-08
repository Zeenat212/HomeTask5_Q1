using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjects_5_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Oop";
            book1.Author = "Abdul Qadeer";
            book1.Genre = "CS book";
            book1.PublicationYears = 1898;

            Book DietelLandDietel = new Book();
            DietelLandDietel.Title  = "Dietel and Dietel";
            DietelLandDietel.Author = "Abdullah";
            DietelLandDietel.Genre = "SE book";
            DietelLandDietel.PublicationYears = 2003;

            Library library_Object = new Library();
            library_Object.AddBook(book1);
            library_Object.AddBook(DietelLandDietel);
            library_Object.ListAllBooks();
            string Query=Console.ReadLine();
            library_Object.SearchBook(Query);

        }
    }
}
