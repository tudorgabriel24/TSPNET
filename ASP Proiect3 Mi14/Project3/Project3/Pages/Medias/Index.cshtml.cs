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
    public class IndexModel : PageModel
    {
        private readonly Project3.Data.Data.Project3Context _context;

        public IndexModel(Project3.Data.Data.Project3Context context)
        {
            _context = context;
        }

        public IList<Media> Media { get;set; }

        public async Task OnGetAsync()
        {
            Media = await _context.Media
                .Include(m => m.LinkMediaPerson).ToListAsync();
        }
    }
}
