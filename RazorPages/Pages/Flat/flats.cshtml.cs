using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;

namespace RazorPages.Pages.Flat
{
    public class flatsModel : PageModel
    {       
    [TempData]
    public string totolprice { get; set; }
    
    [Required]
    [BindProperty]
    public string biznesprice { get; set; }
    [Required]
    [BindProperty]
    public string vol { get; set; }

    public void OnGet()
    {
    }
    public async Task<IActionResult> OnPostAsync()
    {
        totolprice = (Convert.ToDouble(biznesprice) * Convert.ToDouble(vol)).ToString();

    return RedirectToPage();
    }
    }
}