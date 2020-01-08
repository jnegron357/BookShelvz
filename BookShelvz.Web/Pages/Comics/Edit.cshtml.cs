using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookShelvz.Data;
using BookShelvz.Domain.Models;

namespace BookShelvz.Web
{
    public class EditModel : PageModel
    {
        private readonly BookShelvz.Data.BookShelvzContext _context;

        public EditModel(BookShelvz.Data.BookShelvzContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ComicBook ComicBook { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ComicBook = await _context.ComicBooks
                .Include(c => c.Publisher).FirstOrDefaultAsync(m => m.Id == id);

            if (ComicBook == null)
            {
                return NotFound();
            }
           ViewData["PublisherId"] = new SelectList(_context.Publishers, "Id", "AddressLine1");
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ComicBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComicBookExists(ComicBook.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ComicBookExists(int id)
        {
            return _context.ComicBooks.Any(e => e.Id == id);
        }
    }
}
