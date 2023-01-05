using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Artworks_ASP.NET.Pages
{
    public class ArtworkModel : PageModel
    {
        private readonly ILogger<ArtworkModel> _logger;

        public ArtworkModel(ILogger<ArtworkModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}