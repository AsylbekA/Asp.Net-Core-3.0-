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
    public class DeleteModel : PageModel
    {
        private readonly RazorPages.Data.RazorPagesContext _context;

        public DeleteModel(RazorPages.Data.RazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flats = await _context.Flats.FindAsync(id);

            if (Flats != null)
            {
                _context.Flats.Remove(Flats);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
