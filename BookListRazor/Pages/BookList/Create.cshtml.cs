using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly BookContext _context;
        public CreateModel (BookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }
        public void OnGet ()
        {

        }

        public async Task<IActionResult> OnPost ()
        {
            if (ModelState.IsValid)
            {
                await _context.Book.AddAsync(Book);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }

        }
    }
}
