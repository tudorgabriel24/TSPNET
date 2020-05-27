using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntitiFrameworkProject1;

namespace Project3.Data.Data
{
    public class Project3Context : DbContext
    {
        public Project3Context (DbContextOptions<Project3Context> options)
            : base(options)
        {
        }

        public DbSet<EntitiFrameworkProject1.Media> Media { get; set; }

        public DbSet<EntitiFrameworkProject1.Person> Person { get; set; }
    }
}
