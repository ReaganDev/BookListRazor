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
        public async Task OnGet ()
        {
            Books = await _context.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete (string id)
        {
            var book = await _context.Book.FirstOrDefaultAsync(x => x.Id == id);
            if (book != null)
            {
                _context.Book.Remove(book);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return NotFound();
        }
    }
}
