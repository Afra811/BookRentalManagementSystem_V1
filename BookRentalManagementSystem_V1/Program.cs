using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();
            int choice;

            Console.WriteLine("\n---- Book Rental Management System:------");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Update a Book");
            Console.WriteLine("4. Delete a Book");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            Console.ReadLine();
        }
    }
}
