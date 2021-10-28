using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListRazor.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly BookContext _context;
        public IndexModel (BookContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> Books { get; set; }
        public async Task OnGet()
        {
            Books =await _context.Book.ToListAsync();
        }
    }
}
