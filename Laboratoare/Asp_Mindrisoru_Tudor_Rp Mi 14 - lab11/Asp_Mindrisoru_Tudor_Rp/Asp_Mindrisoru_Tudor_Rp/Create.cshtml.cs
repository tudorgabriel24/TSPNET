using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Asp_Mindrisoru_Tudor_Rp.Data;
using Asp_Mindrisoru_Tudor_Rp.Models;

namespace Asp_Mindrisoru_Tudor_Rp
{
    public class CreateModel : PageModel
    {
        private readonly Asp_Mindrisoru_Tudor_Rp.Data.Asp_Mindrisoru_Tudor_RpContext _context;

        public CreateModel(Asp_Mindrisoru_Tudor_Rp.Data.Asp_Mindrisoru_Tudor_RpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
