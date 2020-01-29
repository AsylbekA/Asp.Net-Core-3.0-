using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Flat
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPages.Data.RazorPagesContext _context;

        public DetailsModel(RazorPages.Data.RazorPagesContext context)
        {
            _context = context;
        }

        public Flats Flats { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flats = await _context.Flats.FirstOrDefaultAsync(m => m.ProductID == id);

            if (Flats == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
