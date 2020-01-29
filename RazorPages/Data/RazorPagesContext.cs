using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Data
{
    public class RazorPagesContext : DbContext
    {
        public RazorPagesContext(DbContextOptions<RazorPagesContext> options)
            : base(options)
        {
        }

        [BindProperty]
        public DbSet<RazorPages.Models.Flats> Flats { get; set; }
    }
}
