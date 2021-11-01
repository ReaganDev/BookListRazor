using BookListRazor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookListRazor
{
    public class Seeder
    {
        public static async Task SeedData (BookContext context)
        {
            if (!context.Book.Any())
            {
                var bookData = File.ReadAllText("./Json/Books.json");
                var books = JsonSerializer.Deserialize<List<Book>>(bookData);

                foreach (var book in books)
                {
                    context.Book.Add(book);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}
