using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Artworks_ASP.NET.ConnectionManager;

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