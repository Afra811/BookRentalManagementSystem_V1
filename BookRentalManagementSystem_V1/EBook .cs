using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class EBook :Book
    {
        public double FileSize { get; }
        public string Format { get; }


        public EBook(string bookId, string title, string author, decimal rentalPrice, double fileSize, string format) : base(bookId, title, author, rentalPrice)
        {
            FileSize = fileSize;
            Format = format;

        }

        public override string ToString()
        {
            return base.ToString() + $", FileSize: {FileSize}MB, Format: {Format}";
        }

        public override string DisplayBookInfo()
        {
            return base.DisplayBookInfo() + $", FileSize: {FileSize}MB, Format: {Format}";
        }

    }
}
