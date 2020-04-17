using System;
using System.Collections.Generic;
using System.Text;

namespace FuncWithExtensionMethod.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }

        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
