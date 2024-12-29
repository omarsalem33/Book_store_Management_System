using Book_store_Management_System.Models;
using Book_store_Management_System.Operations;
using System;
using System.Diagnostics;

using static System.Reflection.Metadata.BlobBuilder;

namespace Book_store_Management_System
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("______________________________________");
            Console.WriteLine("Welcome In Book Store Managemnt System");
            Console.WriteLine("______________________________________");

            while (true)
            {
                Console.WriteLine("\nBook Store Management System\n ");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Edit Book Details");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. Search books by title, author, genre, or price range");
                Console.WriteLine("6. Add New Customer");
                Console.WriteLine("7. Edit Custmor Details");
                Console.WriteLine("8. Retrieve Customer List By Purchase History");
                Console.WriteLine("9. Add Order");
                Console.WriteLine("10. Show ALL Orders");
                Console.WriteLine("11. Retrieve Orders Filtered By Date");
                Console.WriteLine("12. Top Selling Books");
                Console.WriteLine("13. All Orders Between Specific Period And Total sales");
                Console.WriteLine("14. Customers With The Most Purchases");
                Console.WriteLine("15. Exit\n");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BooksOperations.AddNewBook();
                        break;
                    case "2":
                        BooksOperations.EditBookDetails();
                        break;
                    case "3":
                        BooksOperations.DeleteBook();
                        break;
                    case "4":
                        BooksOperations.ViewAllBooks();
                        break;
                    case "5":
                        BooksOperations.SearchBooks();
                        break;
                    case "6":
                        CustomersOperations.AddNewCustomer();
                        break;
                    case "7":
                        CustomersOperations.UpdateCustomerDetails();
                        break;
                    case "8":
                        CustomersOperations.RetrieveCustomerListByPurchaseHistory();
                        break;
                    case "9":
                        OrdersOperations.AddOrder();
                        break;
                    case "10":
                        OrdersOperations.ShowAllOrders();
                        break;
                    case "11":
                        OrdersOperations.RetrieveOrdersFilteredByDate();
                        break;
                    case "12":
                        Reports.Reports.Top_Selling_Books();
                        break;
                    case "13":
                        Reports.Reports.AllOrdersBetweenSpecificPeriodAndALLsales();
                        break;
                    case "14":
                        Reports.Reports.CustomersWithTheMostPurchases();
                        break;
                    case "15":
                        Console.WriteLine("Program Ended...");
                        return;
                        
                }
            }
        }
    }
}
