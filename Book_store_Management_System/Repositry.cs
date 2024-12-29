using Book_store_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store_Management_System
{
    public static class Repositry
    {
        public static List<Book> _book = new List<Book>();
        
        public static List<Customer> _customer = new List<Customer>();
        
        public static List<Order> _orders = new List<Order>();
   
        public static IEnumerable<Book> LoadBooks()
        {
            _book.Add(new Book
            {
                Id = 1,
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Genre = "Fiction",
                Price = 10.99m,
                Stock = 20
            });
            _book.Add(new Book
            {
                Id = 2,
                Title = "1984",
                Author = "George Orwell",
                Genre = "Dystopian",
                Price = 12.99m,
                Stock = 15
            });
            _book.Add(new Book
            {
                Id = 3,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                Price = 9.99m,
                Stock = 30
            });
            _book.Add(new Book
            {
                Id = 4,
                Title = "Moby Dick",
                Author = "Herman Melville",
                Genre = "Adventure",
                Price = 14.50m,
                Stock = 25
            });
            _book.Add(new Book
            {
                Id = 5,
                Title = "War and Peace",
                Author = "Leo Tolstoy",
                Genre = "Drama",
                Price = 19.99m,
                Stock = 10
            });
            _book.Add(new Book
            {
                Id = 6,
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Genre = "Romance",
                Price = 8.49m,
                Stock = 40
            });
            _book.Add(new Book
            {
                Id = 7,
                Title = "The Odyssey",
                Author = "Homer",
                Genre = "Epic",
                Price = 13.75m,
                Stock = 18
            });
            _book.Add(new Book
            {
                Id = 8,
                Title = "Ulysses",
                Author = "James Joyce",
                Genre = "Fiction",
                Price = 15.99m,
                Stock = 12
            });
            _book.Add(new Book
            {
                Id = 9,
                Title = "Hamlet",
                Author = "William Shakespeare",
                Genre = "Tragedy",
                Price = 7.99m,
                Stock = 50
            });
            _book.Add(new Book
            {
                Id = 10,
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                Genre = "Classic",
                Price = 11.99m,
                Stock = 22
            });
            _book.Add(new Book
            {
                Id = 11,
                Title = "Brave New World",
                Author = "Aldous Huxley",
                Genre = "Dystopian",
                Price = 10.49m,
                Stock = 27
            });
            _book.Add(new Book
            {
                Id = 12,
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Genre = "Fantasy",
                Price = 14.99m,
                Stock = 35
            });
            _book.Add(new Book
            {
                Id = 13,
                Title = "Crime and Punishment",
                Author = "Fyodor Dostoevsky",
                Genre = "Classic",
                Price = 13.20m,
                Stock = 17
            });
            _book.Add(new Book
            {
                Id = 14,
                Title = "The Brothers Karamazov",
                Author = "Fyodor Dostoevsky",
                Genre = "Classic",
                Price = 15.75m,
                Stock = 23
            });
            _book.Add(new Book
            {
                Id = 15,
                Title = "Anna Karenina",
                Author = "Leo Tolstoy",
                Genre = "Drama",
                Price = 9.80m,
                Stock = 26
            });
            _book.Add(new Book
            {
                Id = 16,
                Title = "The Divine Comedy",
                Author = "Dante Alighieri",
                Genre = "Epic",
                Price = 16.99m,
                Stock = 14
            });
            _book.Add(new Book
            {
                Id = 17,
                Title = "Great Expectations",
                Author = "Charles Dickens",
                Genre = "Classic",
                Price = 12.45m,
                Stock = 28
            });
            _book.Add(new Book
            {
                Id = 18,
                Title = "Jane Eyre",
                Author = "Charlotte Bronte",
                Genre = "Romance",
                Price = 9.99m,
                Stock = 31
            });
            _book.Add(new Book
            {
                Id = 19,
                Title = "Wuthering Heights",
                Author = "Emily Bronte",
                Genre = "Drama",
                Price = 10.75m,
                Stock = 20
            });
            _book.Add(new Book
            {
                Id = 20,
                Title = "Les Misérables",
                Author = "Victor Hugo",
                Genre = "Classic",
                Price = 19.50m,
                Stock = 12
            });
            _book.Add(new Book
            {
                Id = 21,
                Title = "The Count of Monte Cristo",
                Author = "Alexandre Dumas",
                Genre = "Adventure",
                Price = 18.99m,
                Stock = 13
            });
            _book.Add(new Book
            {
                Id = 22,
                Title = "Dracula",
                Author = "Bram Stoker",
                Genre = "Horror",
                Price = 12.99m,
                Stock = 18
            });
            _book.Add(new Book
            {
                Id = 23,
                Title = "The Picture of Dorian Gray",
                Author = "Oscar Wilde",
                Genre = "Classic",
                Price = 10.99m,
                Stock = 22
            });
            _book.Add(new Book
            {
                Id = 24,
                Title = "The Three Musketeers",
                Author = "Alexandre Dumas",
                Genre = "Adventure",
                Price = 14.50m,
                Stock = 25
            });
            _book.Add(new Book
            {
                Id = 25,
                Title = "The Grapes of Wrath",
                Author = "John Steinbeck",
                Genre = "Fiction",
                Price = 16.99m,
                Stock = 15
            });
            _book.Add(new Book
            {
                Id = 26,
                Title = "Of Mice and Men",
                Author = "John Steinbeck",
                Genre = "Fiction",
                Price = 9.99m,
                Stock = 30
            });
            _book.Add(new Book
            {
                Id = 27,
                Title = "A Tale of Two Cities",
                Author = "Charles Dickens",
                Genre = "Classic",
                Price = 11.99m,
                Stock = 20
            });
            _book.Add(new Book
            {
                Id = 28,
                Title = "The Secret Garden",
                Author = "Frances Hodgson Burnett",
                Genre = "Children's Literature",
                Price = 8.49m,
                Stock = 35
            });
            _book.Add(new Book
            {
                Id = 29,
                Title = "The Adventures of Huckleberry Finn",
                Author = "Mark Twain",
                Genre = "Adventure",
                Price = 10.99m,
                Stock = 28
            });
            _book.Add(new Book
            {
                Id = 30,
                Title = "Little Women",
                Author = "Louisa May Alcott",
                Genre = "Fiction",
                Price = 12.99m,
                Stock = 24
            });



            return _book;
        }
        
        public static IEnumerable<Order> LoadOrders()
        {
            _orders.Add(new Order
            {
                BookIds = new List<int> { 1, 2, 3 },
                CustomerId = 1,
                OrderDate = DateTime.Now.AddDays(10),
                OrderId = 1,
                TotalAmount = 10.99m + 12.99m + 9.99m
            });
            _orders.Add(new Order
            {
                BookIds = new List<int> { 1 },
                CustomerId = 1,
                OrderDate = DateTime.Now.AddDays(10),
                OrderId = 2,
                TotalAmount = 10.99m
            });
            _orders.Add(new Order
            {
                OrderId = 3,
                CustomerId = 1,
                BookIds = new List<int> { 1 },
                OrderDate = DateTime.Now.AddDays(14),
                TotalAmount = 10.99m
            });
            _orders.Add(new Order
            {
                BookIds = new List<int> {3},
                CustomerId = 1,
                OrderDate = DateTime.Now,
                OrderId = 4,
                TotalAmount = 9.99m
            });
            _orders.Add(new Order
            {
                BookIds = new List<int> { 3 },
                CustomerId = 1,
                OrderDate = DateTime.Now,
                OrderId = 5,
                TotalAmount = 9.99m
            }); _orders.Add(new Order
            {
                BookIds = new List<int> { 3 },
                CustomerId = 1,
                OrderDate = DateTime.Now,
                OrderId = 6,
                TotalAmount = 9.99m
            });
            _orders.Add(new Order
            {
                OrderId = 7,
                CustomerId = 1,
                BookIds = new List<int> {2},
                OrderDate = DateTime.Now,
                TotalAmount = 12.99m
            });

            return _orders;
        }


    }
}
