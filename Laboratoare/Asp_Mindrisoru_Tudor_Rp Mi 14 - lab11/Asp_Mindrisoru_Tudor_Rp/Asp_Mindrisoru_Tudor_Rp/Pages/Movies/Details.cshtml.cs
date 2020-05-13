using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp_Mindrisoru_Tudor_Rp.Data;
using Asp_Mindrisoru_Tudor_Rp.Models;

namespace Asp_Mindrisoru_Tudor_Rp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Asp_Mindrisoru_Tudor_Rp.Data.Asp_Mindrisoru_Tudor_RpContext _context;

        public DetailsModel(Asp_Mindrisoru_Tudor_Rp.Data.Asp_Mindrisoru_Tudor_RpContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
