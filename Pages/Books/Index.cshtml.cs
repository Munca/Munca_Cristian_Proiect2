using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munca_Cristian_Proiect2.Data;
using Munca_Cristian_Proiect2.Models;

namespace Munca_Cristian_Proiect2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Munca_Cristian_Proiect2.Data.Munca_Cristian_Proiect2Context _context;

        public IndexModel(Munca_Cristian_Proiect2.Data.Munca_Cristian_Proiect2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context
              .Include(b => b.Publisher)
              .ToListAsync();
        }
    }
}
