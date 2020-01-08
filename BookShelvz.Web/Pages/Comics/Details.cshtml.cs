using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookShelvz.Data;
using BookShelvz.Domain.Models;

namespace BookShelvz.Web
{
    public class DetailsModel : PageModel
    {
        private readonly BookShelvz.Data.BookShelvzContext _context;

        public DetailsModel(BookShelvz.Data.BookShelvzContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
