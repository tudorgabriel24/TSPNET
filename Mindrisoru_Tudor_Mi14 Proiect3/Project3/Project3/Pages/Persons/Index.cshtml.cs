using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EntitiFrameworkProject1;
using Project3.Data.Data;

namespace Project3.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly Project3.Data.Data.Project3Context _context;

        public IndexModel(Project3.Data.Data.Project3Context context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; }

        public async Task OnGetAsync()
        {
            Person = await _context.Person
                .Include(p => p.LinkMediaPerson).ToListAsync();
        }
    }
}
