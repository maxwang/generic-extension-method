using FuncWithExtensionMethod.Extensions;
using FuncWithExtensionMethod.Models;
using System;

namespace FuncWithExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                BookId = 1,
                BookName = "Test Book",
                Publisher = new Publisher
                {
                    PublisherId = 1,
                    Name = "Publisher"
                }
            };

            book.Publisher.CreateItem<Publisher>((id) => book.PublisherId = id);
            Console.WriteLine(book.PublisherId);
            Console.ReadLine();
        }
    }
}
