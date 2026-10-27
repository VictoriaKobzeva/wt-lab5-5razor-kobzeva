using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_kobzeva.Models;
using wt_lab5_5razor_kobzeva.Data;

namespace wt_lab5_5razor_kobzeva.Pages.Products;

public class IndexModel : PageModel
{
    public List<Property> Properties { get; set; } = new();

    public void OnGet()
    {
        Properties = PropertyStore.Properties;
    }

    public IActionResult OnPostDelete(int id)
    {
        var property = PropertyStore.Properties.FirstOrDefault(p => p.Id == id);
        if (property != null)
        {
            PropertyStore.Properties.Remove(property);
        }
        return RedirectToPage("./Index");
    }
}