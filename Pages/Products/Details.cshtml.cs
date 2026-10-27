using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_kobzeva.Models;
using wt_lab5_5razor_kobzeva.Data;

namespace wt_lab5_5razor_kobzeva.Pages.Products;

public class DetailsModel : PageModel
{
    public Property? Property { get; set; }

    public IActionResult OnGet(int id)
    {
        Property = PropertyStore.Properties.FirstOrDefault(p => p.Id == id);
        
        if (Property == null)
        {
            return NotFound();
        }
        
        return Page();
    }
}