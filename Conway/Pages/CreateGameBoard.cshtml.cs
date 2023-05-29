using Conway.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Conway.Pages
{
    public class CreateGameBoardModel : PageModel
    {
        [BindProperty]
        public GameBoard GameBoard { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/FillGameBoard");
        }
    }
}
