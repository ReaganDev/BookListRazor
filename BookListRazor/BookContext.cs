using BookListRazor.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
