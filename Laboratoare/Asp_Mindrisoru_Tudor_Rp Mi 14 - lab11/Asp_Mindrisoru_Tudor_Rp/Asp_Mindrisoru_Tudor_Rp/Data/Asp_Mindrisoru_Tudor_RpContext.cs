using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Mindrisoru_Tudor_Rp.Models;

namespace Asp_Mindrisoru_Tudor_Rp.Data
{
    public class Asp_Mindrisoru_Tudor_RpContext : DbContext
    {
        public Asp_Mindrisoru_Tudor_RpContext (DbContextOptions<Asp_Mindrisoru_Tudor_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Mindrisoru_Tudor_Rp.Models.Movie> Movie { get; set; }
    }
}
