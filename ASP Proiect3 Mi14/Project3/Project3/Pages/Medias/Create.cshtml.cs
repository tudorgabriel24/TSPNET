using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EntitiFrameworkProject1;
using Project3.Data.Data;

namespace Project3.Pages.Medias
{
    public class CreateModel : PageModel
    {
        private readonly Project3.Data.Data.Project3Context _context;

        public CreateModel(Project3.Data.Data.Project3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["LinkMediaPersonId"] = new SelectList(_context.Set<LinkMediaPerson>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Media Media { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Media.Add(Media);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
