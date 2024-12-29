using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store_Management_System.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<int> BookIds { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public override string ToString()
        {
           
            return $"Order Id: {OrderId}\t" +
                $"ID: {CustomerId}\t" +
                $"BookIDs: {string.Join(" " , BookIds)}\t" +
                $"Date: {OrderDate.ToString("dddd")}\t" +
                $"Total: {TotalAmount}\t" ;
        }
    }
}
