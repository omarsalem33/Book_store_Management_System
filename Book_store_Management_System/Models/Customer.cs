using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_store_Management_System.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> PurchaseHistory { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"Id: {Id}\t\t Name: {Name}";
        }
    }
}
