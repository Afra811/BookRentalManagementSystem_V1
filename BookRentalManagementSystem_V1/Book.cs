using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    public class Book
    {
        private string bookId {  get; set; }
        public string GetbookId() 

        { return bookId; }

        public void SetbookId(string value)
        {
            bookId = value;
        }



        private string title { get; set; }
        public string Gettitle() 
        
        { return title; }

        public void Settitle(string value)
        {
            title = value;
        }


        private string author { get; set; }

        public string Getauthor() 
        
        { return author; }


        public void Setauthor(string value)
        {
            author = value;
        }


        private decimal rentalprice { get; set; }

        public decimal Getrentalprice() 
        
        { return rentalprice; }


        public void Setrentalprice(decimal value)
        {
            rentalprice = value;
        }
    }
}
