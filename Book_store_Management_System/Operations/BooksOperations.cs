using Book_store_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store_Management_System.Operations
{
    public static class BooksOperations
    {
        private static int nextBookId = Repositry._book.Count();
        private static IEnumerable<Book> AllBooks = Repositry.LoadBooks();
       
        public static void SearchBooks()
        {
            Console.WriteLine("\nSearch Books");
            Console.WriteLine("1. By Title");
            Console.WriteLine("2. By Author");
            Console.WriteLine("3. By Genre");
            Console.WriteLine("4. By Price Range");
            Console.Write("Choose an option: ");

            string searchOption = Console.ReadLine();
            switch (searchOption)
            {
                case "1":
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();
                    var BookByTitle = AllBooks.Where(x => x.Title == title);
                    BookByTitle.Print("The Book you want");

                    break;

                case "2":
                    Console.Write("Enter Author: ");
                    string Author = Console.ReadLine();
                    var BookByAuthor = AllBooks.Where(x => x.Author == Author);
                    BookByAuthor.Print("The Book you want");
                    break;

                case "3":
                    Console.Write("Enter Genre: ");
                    string Genre = Console.ReadLine();
                    var BookByGenre = AllBooks.Where(x => x.Genre == Genre);
                    BookByGenre.Print("The Book you want");
                    break;

                case "4":
                    Console.Write("Enter Minimum Price: ");
                    decimal MinimumPrice = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter Maximum Price: ");
                    decimal MaximumPrice = decimal.Parse(Console.ReadLine());
                    var BookByPriceRange = AllBooks.Where(x => x.Price >= MinimumPrice && x.Price <= MaximumPrice);
                    BookByPriceRange.Print("The Books you want");
                    break;
            }
        }

        public static void ViewAllBooks()
        {
            AllBooks.Print("View All Books");
        }

        public static void DeleteBook()
        {
            Console.WriteLine("\nDelete Book");
            Console.Write("Enter Book ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            Book book = AllBooks.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            Repositry._book.Remove(book);
            Console.WriteLine("Book deleted successfully!");
        }

        public static void EditBookDetails()
        {
            Console.WriteLine("\nEdit Book Details");
            Console.Write("Enter Book Id To Edit: ");

            int id = int.Parse(Console.ReadLine());
            Book book = AllBooks.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            Console.Write("Enter New Title: ");
            string NewTitle = Console.ReadLine();
            if (!string.IsNullOrEmpty(NewTitle))
            {
                book.Title = NewTitle;
            }

            Console.Write("Enter New Author: ");
            string newAuthor = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newAuthor))
            {
                book.Author = newAuthor;
            }

            Console.Write("Enter New Genre: ");
            string newGenre = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newGenre))
            {
                book.Genre = newGenre;
            }

            Console.Write("Enter New Salary: ");
            string Salary = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(Salary))
            {
                book.Price = decimal.Parse(Salary);
            }

            Console.Write("Enter New Stock Quantity: ");
            string StockQuantity = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(StockQuantity))
            {
                book.Stock = int.Parse(StockQuantity);
            }
        }

        public static void AddNewBook()
        {
            Console.WriteLine("\nAdd New Book");
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Console.Write("Enter Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Stock Quantity: ");
            int stockQuantity = int.Parse(Console.ReadLine());

            var newBook = Repositry._book;
            newBook.Add(
                new Book
                {
                    Id = nextBookId++,
                    Title = title,
                    Author = author,
                    Genre = genre,
                    Price = price,
                    Stock = stockQuantity
                });

            Console.WriteLine("Book Add successfully!");
        }
    }
}
