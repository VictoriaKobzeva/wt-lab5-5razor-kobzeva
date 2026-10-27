using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_kobzeva.Models;
using wt_lab5_5razor_kobzeva.Data;

namespace wt_lab5_5razor_kobzeva.Pages.Products;

public class EditModel : PageModel
{
    [BindProperty]
    public Property Property { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var existing = PropertyStore.Properties.FirstOrDefault(p => p.Id == id);
        if (existing == null) return NotFound();

        Property = existing;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var existing = PropertyStore.Properties.FirstOrDefault(p => p.Id == Property.Id);
        if (existing == null) return NotFound();

        existing.Address = Property.Address;
        existing.Type = Property.Type;
        existing.Price = Property.Price;
        existing.Area = Property.Area;
        existing.Rooms = Property.Rooms;
        existing.IsAvailable = Property.IsAvailable;

        return RedirectToPage("./Index");
    }
}