﻿using System;
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

        public static int TotalBooks = 0;


        public Book(string bookId, string title, string author, decimal rentalPrice)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
            TotalBooks++;
        }

        public override string ToString()
        {
            return ($"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}");
        }

        public virtual string DisplayBookInfo()
        {
            return $"bookId: {BookId}, Title: {Title}, Author: {Author}, RentalPrice: {RentalPrice}";
        }



    }
}
