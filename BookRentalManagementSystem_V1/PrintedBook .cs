using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class PrintedBook:Book
    {
        public double ISBN { get; }
        public int NumberOfPages { get; }

        public PrintedBook(string bookId, string title, string author, decimal rentalPrice, double isbn, int numberofpage)
            : base(bookId, title, author, rentalPrice)
        {
            ISBN = isbn;
            NumberOfPages = numberofpage;

        }

        public override string ToString()
        {
            return base.ToString() + $", ISBN: {ISBN}, NumberOfPages: {NumberOfPages}";
        }

        public override string DisplayBookInfo()
        {
            return base.DisplayBookInfo() + $", ISBN: {ISBN}, NumberOfPages: {NumberOfPages}";
        }
    }
}
