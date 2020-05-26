using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntitiFrameworkProject1;
using Project3.Data.Data;

namespace Project3.Pages.Medias
{
    public class EditModel : PageModel
    {
        private readonly Project3.Data.Data.Project3Context _context;

        public EditModel(Project3.Data.Data.Project3Context context)
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
           ViewData["LinkMediaPersonId"] = new SelectList(_context.Set<LinkMediaPerson>(), "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Media).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediaExists(Media.Id))
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

        private bool MediaExists(int id)
        {
            return _context.Media.Any(e => e.Id == id);
        }
    }
}
