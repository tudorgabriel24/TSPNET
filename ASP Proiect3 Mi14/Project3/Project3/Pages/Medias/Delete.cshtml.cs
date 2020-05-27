using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntitiFrameworkProject1;
using Project3.Data.Data;

namespace Project3.Pages.Medias
{
    public class DeleteModel : PageModel
    {
        private readonly Project3.Data.Data.Project3Context _context;

        public DeleteModel(Project3.Data.Data.Project3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Media Media { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Media = await _context.Media
                .Include(m => m.LinkMediaPerson).FirstOrDefaultAsync(m => m.Id == id);

            if (Media == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Media = await _context.Media.FindAsync(id);

            if (Media != null)
            {
                _context.Media.Remove(Media);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
