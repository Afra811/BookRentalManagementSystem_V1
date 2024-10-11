using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    public class Book
    {
        public string BookId { get; set; }
      
        public string Title { get; set; }
       
        public string Author { get; set; }

        public decimal RentalPrice { get; set; }

      


        public Book(string bookId, string title, string author, decimal rentalPrice)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;

        }

        public override string ToString()
        {
            return ($"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}");
        }




    }
}
