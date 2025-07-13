using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;


public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    // Fix: Add the missing property definition for 'Products'  
    public IList<Product> Products { get; set; }

    public async Task OnGetAsync()
    {
        Products = await _context.Products.ToListAsync();
    }
}
