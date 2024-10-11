using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    public class Book
    {
        private string BookId {  get; set; }
        public string GetbookId() 

        { return BookId; }

        public void SetbookId(string value)
        {
            BookId = value;
        }



        private string Title { get; set; }
        public string Gettitle() 
        
        { return Title; }

        public void Settitle(string value)
        {
            Title = value;
        }


        private string Author { get; set; }

        public string Getauthor() 
        
        { return Author; }


        public void Setauthor(string value)
        {
            Author = value;
        }


        private decimal RentalPrice { get; set; }

        public decimal Getrentalprice() 
        
        { return RentalPrice; }


        public void Setrentalprice(decimal value)
        {
            RentalPrice = value;
        }

        
        public Book (string bookId, string title,  string author, decimal rentalPrice)
        {
            BookId=bookId;
            Title=title;
            Author=author;
            RentalPrice = rentalPrice;

        }

        public override string ToString()
        {
            return ($"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}");
        }
    }
}
