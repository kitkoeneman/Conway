using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Conway.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        [Range(10,100)]
        public int Height { get; set; }

        [BindProperty]
        [Range(10,100)]
        public int Width { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}