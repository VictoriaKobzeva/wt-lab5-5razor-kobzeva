using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_kobzeva.Models;
using wt_lab5_5razor_kobzeva.Data;

namespace wt_lab5_5razor_kobzeva.Pages.Products;

public class CreateModel : PageModel
{
    [BindProperty]
    public Property Property { get; set; } = new();

    public void OnGet()
    {
        // GET: показать пустую форму
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Генерация нового Id
        Property.Id = PropertyStore.Properties.Any()
            ? PropertyStore.Properties.Max(x => x.Id) + 1
            : 1;

        PropertyStore.Properties.Add(Property);

        return RedirectToPage("./Index");
    }
}