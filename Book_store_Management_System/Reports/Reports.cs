using Book_store_Management_System.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store_Management_System.Reports
{
    public class Reports
    {
        public static void Top_Selling_Books()
        {
            var topSallingBooks = Repositry._orders
                .SelectMany(order => order.BookIds)
                .GroupBy(bookId => bookId)
                .Select(group => new
                {
                    BookID = group.Key,
                    QuantitySold = group.Count()
                }).OrderByDescending(result => result.QuantitySold)
                .ToList().Take(1);

            topSallingBooks.Print("Top #1");
        }

        public static void AllOrdersBetweenSpecificPeriodAndALLsales()
        {
            Console.Write("Enter your First_Period (e.g., 1/1/2024): ");
            var Frist_Period = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter your Second Period(e.g., 1/1/2024): ");
            var Second_Period = DateTime.Parse(Console.ReadLine());

            var AllOrdersInPeriod = Repositry.LoadOrders()
                .Where(frist => frist.OrderDate >= Frist_Period
                       && frist.OrderDate <= Second_Period)
                .ToList();

            AllOrdersInPeriod.Print($"All Orders between {Frist_Period.ToString("dd/MM/yyyy")}" +
                $" to {Second_Period.ToString("dd/MM/yyyy")}" +
                $"\n\tTotal sales:  {AllOrdersInPeriod.Sum(x => x.TotalAmount)}");
        }

        public static void BooksOutOfStock() { }
        
        public static void CustomersWithTheMostPurchases()
        {
            var AllOrders = Repositry._orders;

            var customerWiththemostPurchases = AllOrders
                .GroupBy(bookId => bookId.CustomerId)
                .Select(group => new
                {
                    CustomerID = group.Key,
                    TotalBooks = group.Sum(order => order.BookIds.Count)
                }).OrderByDescending(x => x.TotalBooks);

            if (customerWiththemostPurchases != null)
            {
                customerWiththemostPurchases.Print("---------Customers With The Most Purchases------------");
            }
            else
            {
                Console.WriteLine("No orders found.");
            }

            
                
        }

      
    }
}
