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
            

            var bookManager = new BookManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\n---- Book Rental Management System:------");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Update a Book");
                Console.WriteLine("4. Delete a Book");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();



                switch (option)
                {
                    case "1":
                        Console.WriteLine("Add New Book");
                        Console.Write("Enter Title: ");
                        string title = (Console.ReadLine());
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Rental Price: ");
                        decimal rentalprice = decimal.Parse(Console.ReadLine());



                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("View All Books");
                        Console.ReadLine(); // Wait for user input before continuing
                        break;

                    case "3":
                        Console.Clear();
                        Console.Write("Enter Book ID to update: ");
                        string updateId = Console.ReadLine();
                        Console.Write("Enter New Title: ");
                        string newTitle = (Console.ReadLine());
                        Console.Write("Enter New Author: ");
                        string newAuthor = Console.ReadLine();
                        Console.Write("Enter New Rental Price: ");
                        decimal newRentalPrice = decimal.Parse (Console.ReadLine());


                        break;

                    case "4":
                        Console.Clear();
                        Console.Write("Enter Book ID to delete: ");
                       

                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                };

                Console.WriteLine("\n press any key to continue.....");
                Console.ReadKey();
            }
        }
    }
}
