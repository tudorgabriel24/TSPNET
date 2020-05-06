using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp_Mindrisoru_Tudor_Rp.Data;
using Asp_Mindrisoru_Tudor_Rp.Models;

namespace Asp_Mindrisoru_Tudor_Rp
{
    public class IndexModel : PageModel
    {
        private readonly Asp_Mindrisoru_Tudor_Rp.Data.Asp_Mindrisoru_Tudor_RpContext _context;

        public IndexModel(Asp_Mindrisoru_Tudor_Rp.Data.Asp_Mindrisoru_Tudor_RpContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
