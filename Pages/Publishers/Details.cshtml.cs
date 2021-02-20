using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munca_Cristian_Proiect2.Data;
using Munca_Cristian_Proiect2.Models;

namespace Munca_Cristian_Proiect2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Munca_Cristian_Proiect2.Data.Munca_Cristian_Proiect2Context _context;

        public DetailsModel(Munca_Cristian_Proiect2.Data.Munca_Cristian_Proiect2Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
