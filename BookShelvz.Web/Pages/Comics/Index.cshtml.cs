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
    public class IndexModel : PageModel
    {
        private readonly BookShelvz.Data.BookShelvzContext _context;

        public IndexModel(BookShelvz.Data.BookShelvzContext context)
        {
            _context = context;
        }

        public IList<ComicBook> ComicBook { get;set; }

        public async Task OnGetAsync()
        {
            ComicBook = await _context.ComicBooks
                .Include(c => c.Publisher).ToListAsync();
        }
    }
}
