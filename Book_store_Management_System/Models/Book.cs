using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Book_store_Management_System.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return string.Format(
                 $"{Id}\t" +
                 $"{Title.PadRight(25,' ')}\t" +
                 $"{Author.PadRight(25, ' ')}\t" +
                 $"{Genre.PadRight(25, ' ')}\t" +
                 $"{Price.ToString("0.00")}\t" +
                 $"{Stock}");
        }

        
    }
}
