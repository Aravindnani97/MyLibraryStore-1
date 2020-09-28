using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibraryStore.Models
{
    public class Book
    {
        public int Id { get; internal set; }
        public string BookName { get; internal set; }
        public string Author { get; internal set; }
        public string ISBN { get; internal set; }
        public DateTime PublishedDate { get; internal set; }
       // public object Genre { get; internal set; }
        //public object Genre { get; internal set; }
    }
}
