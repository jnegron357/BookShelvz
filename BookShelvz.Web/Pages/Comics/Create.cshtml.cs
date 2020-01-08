using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookShelvz.Data;
using BookShelvz.Domain.Models;

namespace BookShelvz.Web
{
    public class CreateModel : PageModel
    {
        private readonly BookShelvz.Data.BookShelvzContext _context;

        public CreateModel(BookShelvz.Data.BookShelvzContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PublisherId"] = new SelectList(_context.Publishers, "Id", "AddressLine1");
            return Page();
        }

        [BindProperty]
        public ComicBook ComicBook { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ComicBooks.Add(ComicBook);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
