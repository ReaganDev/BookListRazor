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
    public class EditModel : PageModel
    {
        private readonly BookContext _context;

        public EditModel (BookContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGet(string id)
        {
            Book = await _context.Book.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
