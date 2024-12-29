using Book_store_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store_Management_System.Operations
{
    
    public static class CustomersOperations
    {
        private static int Id = 1;

        public static void AddNewCustomer()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            var newCustomer = Repositry._customer;
            newCustomer.Add(new Customer
            { 
                Id = Id++, 
                Name = name
            });
           
            Console.WriteLine("Customer Add successfully!");
        }

        public static void UpdateCustomerDetails()
        {
            var AllCustmoer = Repositry._customer;

            Console.Write("Enter Customer Id To Edit: ");
            int id = int.Parse(Console.ReadLine());
            
            Customer customer = AllCustmoer.Where(x => x.Id == id).FirstOrDefault();
            if(customer == null)
            {
                Console.WriteLine("Customer Not Found");
                return;
            }

            Console.Write("Enter New Name: ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrEmpty(newName)) 
            {
                customer.Name = newName;
            }
            Console.WriteLine("Customer details updated successfully!");
        }

        public static void RetrieveCustomerListByPurchaseHistory()
        {
          
        Console.Write("Enter Book ID in Purchase History: ");
            int bookId = int.Parse(Console.ReadLine());
            var results = Repositry._customer.Where(x=> x.PurchaseHistory.Contains(bookId));
            results.Print("Book ID in Purchase History");
        }
    }
}
