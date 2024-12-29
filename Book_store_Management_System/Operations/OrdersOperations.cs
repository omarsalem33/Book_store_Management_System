using Book_store_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Book_store_Management_System.Operations
{
    public static class OrdersOperations
    {
        private static int Id = 8;

        public static void AddOrder()
        {
            var allbooks = Repositry.LoadBooks();
            Console.Write("Enter BookIds: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            List<int> Ids = inputArray.Select(int.Parse).ToList();

            var books = allbooks
                .Where(BookId => Ids.Contains(BookId.Id))
                .ToList();

            Console.Write("Enter your Id: ");
            int custmorId = int.Parse(Console.ReadLine());
            var custmor = Repositry._customer.Where(x => x.Id == custmorId).SingleOrDefault();
          
            if (custmor is null)
            {
                Console.WriteLine("Incorrect Id ");
                return;
            }

            var newOrder = Repositry._orders;
            newOrder.Add(
            new Order
            {
                OrderId = Id++,
                BookIds = Ids,
                CustomerId = custmorId,
                OrderDate = DateTime.Now,
                TotalAmount = books.Sum(x => x.Price)
            });
            
           newOrder.Print("Orders");
        }

        public static void ShowAllOrders()
        {
            var AllOrder = Repositry._orders.ToList();
            AllOrder.Print("All Orders");
        }

        public static void RetrieveOrdersFilteredByDate()
        {
            Console.Write("Enter Order Date: ");
            DateTime OrderDate = DateTime.Parse(Console.ReadLine());

            var Order = Repositry._orders
                .Where(i => i.OrderDate.ToString("dd") == OrderDate.ToString("dd"));

            if (Order is null)
                Console.WriteLine("Id is not fount");
            else
                Order.Print($"{OrderDate.ToString("dddd")} Orders");
        }
    }
}


//Console.Write("Enter the quantity  you want from each book in turn: ");
//string InputQuaatiy = Console.ReadLine();
//string[] InputQuatiyArray = InputQuaatiy.Split(' ');
//List<int> quantity = InputQuatiyArray.Select(int.Parse).ToList();

//var result = quantity
//    .Select((q, i) => new
//    {
//        q = q,
//        Book = books.ElementAtOrDefault(i),
//        IsGreater = books.ElementAtOrDefault(i)? .Stock > q
//    }).Where(x => x.Book != null)
//    .ToList();

//
// 1 2 3
// 2 2 2