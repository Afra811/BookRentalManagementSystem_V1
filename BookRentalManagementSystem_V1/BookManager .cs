using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class BookManager
    {
        public List<Book> books = new List<Book>();



        public void CreateBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book Added Succefully");




        }

        public void ReadBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Available Books");
            }
            else
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }



        public void UpdateBook(string updateId, string newTitle, string newAuthor, decimal newRentalPrice)
        {
            var book = books.Where(b => b.BookId == updateId).FirstOrDefault();
            Console.WriteLine(updateId);
            if (book != null)
            {

                book.Title = newTitle;
                book.Author = newAuthor;
                book.RentalPrice = newRentalPrice;


                Console.WriteLine("\nBook updated successfully...");

            }
            else
            {
                Console.WriteLine("Book not found.....");
            }
        }


        public void DeleteBook(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found....");
            }
        }


    }
}
